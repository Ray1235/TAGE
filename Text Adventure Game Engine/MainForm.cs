/*
===========================================================================

TAGE GPL Source Code
Copyright (C) 2016 Ray1235

This file is part of the TAGE GPL Source Code.  

TAGE Source Code is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

TAGE Source Code is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with TAGE Source Code.  If not, see <http://www.gnu.org/licenses/>.

===========================================================================
*/

/* File:        MainForm.cs
 * Purpose:     This is where all the action happens
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using MoonSharp.Interpreter;
using MoonSharp.RemoteDebugger;
using SharpGL;

namespace Text_Adventure_Game_Engine
{
    public partial class MainForm : Form
    {
        public string[] Ascript;
        public string[][] StringList;
        public string[][] SettingList;
        // PLAYER
        public int Karma = 0;
        public int choice_id = -1;
        public string Name = "";
        public bool isMale = true;
        public CharacterData character { get; set; }
        // END PLAYER
        public Thread choiceWorker;
        public Script luaScript;
        public RemoteDebuggerService remoteDebugger;
        public MainForm()
        {
            InitializeComponent();
            defineLuaGlobals();
            this.ResizeChoiceButtons();
            remoteDebugger = new RemoteDebuggerService();
#if DEBUG
            //luaScript.Options.DebugPrint = s => this.richTextBox1.AppendText(s + "\n");
            this.tToolStripMenuItem.Visible = true;
            if (MessageBox.Show("Do you want to start the debugger?\nA browser window will be opened", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                remoteDebugger.Attach(luaScript, "Main game script");
                Process.Start(remoteDebugger.HttpUrlStringLocalHost);
            }
#endif
            //AddItem("Test", "Test Item", null);
            //initSkill("survival", "SKL_SURVIVAL",10);
            //initSkill("speech", "SKL_SPEECH");
            if(LoadGame(Program.GameName))
            {

            }
            else
            {
                MessageBox.Show("The game failed to load it's files!","Error loading game!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void initSkill(string name, string localizedName)
        {
            Skill skl = new Skill(name, localizedName);
            skillBindingSource.Add(skl);
        }
        public void initSkill(string name, string localizedName, int initialVal)
        {
            Skill skl = new Skill(name, localizedName);
            skl.Points = initialVal;
            skillBindingSource.Add(skl);
        }
        public void defineLuaGlobals()
        {
            luaScript = new Script();
            luaScript.Globals["dialogue"] = (Func<string, float, string, bool>)Dialogue;
            luaScript.Globals["karmaAdd"] = (Func<int, bool>)KarmaAdd;
            luaScript.Globals["karmaSubtract"] = (Func<int, bool>)KarmaSubtract;
            luaScript.Globals["sleep"] = (Func<float, bool>)waittill;
            luaScript.Globals["choice"] = (Func<float, string, string, string, string, int>)ChoiceHandle;
            luaScript.Globals["karma"] = (Func<int>)GetKarma;
            luaScript.Globals["createCharacter"] = (Func<string,bool,bool>)NameDialog;
            luaScript.Globals["isIntroSkipped"] = (Func<bool>)IsIntroSkipped;
            luaScript.Globals["CName"] = (Func<string>)CName;
            luaScript.Globals["CIsMale"] = (Func<bool>)CIsMale;
            luaScript.Globals["addItem"] = (Func<string, string, string, bool>)AddItem;
        }
        public bool IsIntroSkipped()
        {
            return false;
        }
        public string CName()
        {
            return character.Name;
        }
        public bool CIsMale()
        {
            return character.isMale;
        }
        public bool NameDialog(string name, bool isMale)
        {
            if (name == null) name = "";
            if (isMale == null) isMale = true;
            CharacterCreate cc = new CharacterCreate(name, isMale);
            cc.ShowDialog();
            character = cc.Plr;
            return true;
        }
        public int ChoiceHandle(float time, string c1, string c2, string c3, string c4)
        {
            ChoiceStruct choice = new ChoiceStruct();
            choice.timer = time;
            choice.c1 = c1;
            choice.c2 = c2;
            choice.c3 = c3;
            choice.c4 = c4;
            if(choice.c1 != null)
            {
                choice.Count++;
                if(choice.c2 != null)
                {
                    choice.Count++;
                    if (choice.c3 != null)
                    {
                        choice.Count++;
                        if(choice.c4 != null)
                        {
                            choice.Count++;
                        }
                    }
                }
            }
            if (choiceHandler.IsBusy)
            {
                choiceHandler.CancelAsync();
                choiceWorker.Abort();
                choiceHandler.Dispose();
            }
            dialogueHandler.ReportProgress(0, new LCmd("choice", choice));
            choice_id = -1;
            choiceHandler.RunWorkerAsync(choice);
            while (choice_id == -1) System.Threading.Thread.Sleep(100);
            if (choiceHandler.IsBusy)
            {
                choiceWorker.Abort();
                choiceHandler.Dispose();
            }
            dialogueHandler.ReportProgress(0, new LCmd("reset_btn", null));
            if (choice_id > choice.Count) choice_id = 0;
            return choice_id;
        }
        public bool LoadGame(string game)
        {
            try
            {
                Ascript = File.ReadAllLines(Application.StartupPath + "/" + Program.GameName + "/main.asc");
                return true;
            } catch(ScriptRuntimeException ex)
            {
                MessageBox.Show(ex.DecoratedMessage, "An exception occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Dialogue(string reference, float time, string soundalias)
        {
            LCmd command = new LCmd();
            command.Cmd = "write";
            command.Arg = reference as string;
            dialogueHandler.ReportProgress(0, command);
            if(time > 0)
            {
                waittill(time);
            }
            return true;
        }
        public int GetKarma()
        {
            return Karma;
        }
        public bool KarmaAdd(int value)
        {
            if(value < 1)
            {
                Karma++;
                return true;
            }
            Karma += value;
            LCmd command = new LCmd();
            command.Cmd = "write";
            command.Arg = "^2You've gained Karma!";
#if DEBUG
            command.Arg += " +" + value.ToString();
#endif
            dialogueHandler.ReportProgress(0, command);
            return true;
        }
        public bool AddItem(string name, string localizedName, string imagePath)
        {
            InventoryItem newItem = new InventoryItem();
            newItem.Name = name;
            newItem.LocalizedName = localizedName;
            if(imagePath != null)
                newItem.Icon = System.Drawing.Image.FromFile(Application.StartupPath + "/" + Program.GameName + "/img/" + imagePath);
            dialogueHandler.ReportProgress(0, new LCmd("addItem", newItem));
            return true;
        }
        public bool KarmaSubtract(int value)
        {
            if (value < 1)
            {
                Karma--;
                return true;
            }
            Karma -= value;
            LCmd command = new LCmd();
            command.Cmd = "write";
            command.Arg = "^1You've lost Karma!";
#if DEBUG
            command.Arg += " -"+value.ToString();
#endif
            dialogueHandler.ReportProgress(0, command);
            return true;
        }
        public void ResizeChoiceButtons()
        {
            Console.WriteLine(this.Width);
            int singleButtonWidth = ((this.Width) / 2) - (8 * 3);
            Console.WriteLine(singleButtonWidth);
            this.ChoiceButton1.Width = singleButtonWidth;
            this.ChoiceButton2.Width = singleButtonWidth;
            this.ChoiceButton3.Width = singleButtonWidth;
            this.ChoiceButton4.Width = singleButtonWidth;
            this.ChoiceButton2.Location = new System.Drawing.Point((this.Width - singleButtonWidth) - 30, this.ChoiceButton2.Location.Y);
            this.ChoiceButton4.Location = new System.Drawing.Point((this.Width - singleButtonWidth) - 30, this.ChoiceButton4.Location.Y);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeChoiceButtons();
        }

        private void changeSaveSlotToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("start game", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dialogueHandler.RunWorkerAsync(Application.StartupPath + "/" + Program.GameName + "/main.asc");
                //luaScript.DoFile(Application.StartupPath + "/" + Program.GameName + "/main.asc");
                //Stream script = Stream.Null;
                //File.Open(Application.StartupPath + "/" + Program.GameName + "/main.asc",FileMode.Open).CopyTo(script);
                //luaScript.DoStreamAsync(script);
            }
            this.toolStripMenuItem1.Enabled = false;
        }
   
        private void dialogueHandler_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string path = e.Argument as string;
                luaScript.DoFile(path);
            } catch (ScriptRuntimeException ex)
            {
                MessageBox.Show(ex.DecoratedMessage);
            }
            MessageBox.Show("The game has ended");
            LCmd endCmd = new LCmd();
            endCmd.Cmd = "endgame";
            dialogueHandler.ReportProgress(100,endCmd);
        }

        private bool waittill(float time)
        {
            System.Threading.Thread.Sleep((int)(time * 1000f));
            return true;
        }

        private void dialogueHandler_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void dialogueHandler_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            LCmd command = e.UserState as LCmd;
            if(command.Cmd == "prog")
            {
                if(e.ProgressPercentage+1 <= 100)
                    this.progressBar1.Value = e.ProgressPercentage+1;
                this.progressBar1.Value = e.ProgressPercentage;
            } else if(command.Cmd == "write")
            {
                string text = command.Arg as string;
                this.richTextBox1.SelectionColor = Color.Black;
                if(text.Contains('^'))
                {
                    for(int i = 0; i < text.Split('^').Length; i++)
                    {
                        string colored = text.Split('^')[i];
                        if (colored.Length == 0 || i == 0)
                        {
                            this.richTextBox1.AppendText(colored);
                            this.richTextBox1.Update();
                            this.richTextBox1.ScrollToCaret();
                            continue;
                        }
                        if (colored[0] == '1')
                        {
                            this.richTextBox1.SelectionColor = Color.Red;
                        } else if(colored[0] == '2')
                        {
                            this.richTextBox1.SelectionColor = Color.Green;
                        } else if(colored[0] == '3')
                        {
                            this.richTextBox1.SelectionColor = Color.Yellow;
                        } else if(colored[0] == '4')
                        {
                            this.richTextBox1.SelectionColor = Color.Blue;
                        } else if (colored[0] == '5')
                        {
                            this.richTextBox1.SelectionColor = Color.Black;
                        }
                        this.richTextBox1.AppendText(colored.Remove(0,1));
                        this.richTextBox1.Update();
                        this.richTextBox1.ScrollToCaret();
                    }
                    this.richTextBox1.AppendText("\n");
                    this.richTextBox1.Update();
                    this.richTextBox1.ScrollToCaret();
                }
                else
                {
                    this.richTextBox1.AppendText(text + "\n");
                    this.richTextBox1.Update();
                    this.richTextBox1.ScrollToCaret();
                }
            } else if(command.Cmd == "endgame")
            {
                this.toolStripMenuItem1.Enabled = true;
            }
            else if (command.Cmd == "addItem")
            {
                InventoryItem newItem = command.Arg as InventoryItem;
                inventoryItemBindingSource.Add(newItem);
                this.richTextBox1.AppendText(newItem.LocalizedName+" was added to the inventory\n");
                this.richTextBox1.ScrollToCaret();
            }
            else if (command.Cmd == "choice")
            {
                ChoiceStruct choice = command.Arg as ChoiceStruct;
                this.ChoiceButton1.Enabled = true;
                this.ChoiceButton2.Enabled = true;
                this.ChoiceButton3.Enabled = true;
                this.ChoiceButton4.Enabled = true;
                if (choice.c1 == null)
                {
                    choice.c1 = "...";
                    this.ChoiceButton1.Text = choice.c1;
                    this.ChoiceButton1.Enabled = false;
                }
                else
                {
                    this.ChoiceButton1.Text = choice.c1;
                    choice.Count++;
                }
                if (choice.c2 == null)
                {
                    choice.c2 = "...";
                    this.ChoiceButton2.Text = choice.c2;
                    this.ChoiceButton2.Enabled = false;
                }
                else
                {
                    this.ChoiceButton2.Text = choice.c2;
                    choice.Count++;
                }
                if (choice.c3 == null)
                {
                    choice.c3 = "...";
                    this.ChoiceButton3.Text = choice.c3;
                    this.ChoiceButton3.Enabled = false;
                }
                else
                {
                    this.ChoiceButton3.Text = choice.c3;
                    choice.Count++;
                }
                if (choice.c4 == null)
                {
                    choice.c4 = "...";
                    this.ChoiceButton4.Text = choice.c4;
                    this.ChoiceButton4.Enabled = false;
                }
                else
                {
                    this.ChoiceButton4.Text = choice.c4;
                    choice.Count++;
                }
            }
            else if (command.Cmd == "reset_btn")
            {
                this.ChoiceButton1.Enabled = false;
                this.ChoiceButton2.Enabled = false;
                this.ChoiceButton3.Enabled = false;
                this.ChoiceButton4.Enabled = false;
            }
        }

        private void checkScriptValidityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Script errorCheck = new Script();
            errorCheck.Globals["dialogue"] = (Func<bool>)NullFunc;
            errorCheck.Globals["karmaAdd"] = (Func<bool>)NullFunc;
            errorCheck.Globals["karmaSubtract"] = (Func<bool>)NullFunc;
            errorCheck.Globals["sleep"] = (Func<bool>)NullFunc;
            errorCheck.Globals["choice"] = (Func<int>)NullInt;
            errorCheck.Globals["karma"] = (Func<bool>)NullFunc;
            errorCheck.Globals["createCharacter"] = (Func<bool>)NullFunc;
            errorCheck.Globals["isIntroSkipped"] = (Func<bool>)NullFunc;
            errorCheck.Globals["CName"] = (Func<string>)NullString;
            errorCheck.Globals["CIsMale"] = (Func<bool>)NullFunc;
            errorCheck.Globals["addItem"] = (Func<bool>)NullFunc;
            try
            {
                errorCheck.DoFile(Application.StartupPath + "/" + Program.GameName + "/main.asc");
                MessageBox.Show("Script contains no errors", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (ScriptRuntimeException ex)
            {
                MessageBox.Show(ex.DecoratedMessage, "SCRIPT CHECK FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool NullFunc()
        {
            return true;
        }
        private string NullString()
        {
            return "";
        }
        private int NullInt()
        {
            return 0;
        }
        private void choiceHandler_DoWork(object sender, DoWorkEventArgs e)
        {
            choiceWorker = Thread.CurrentThread;
            try
            {
                ChoiceStruct inp = e.Argument as ChoiceStruct;
                for (int i = 1; i <= 100; i++)
                {
                    System.Threading.Thread.Sleep((int)(inp.timer * 10));
                    choiceHandler.ReportProgress(i);
                }
                choice_id = 0;
            } catch (ThreadAbortException ex)
            {
                e.Cancel = true;
                Thread.ResetAbort();
            }
        }

        private void choiceHandler_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            dialogueHandler.ReportProgress(e.ProgressPercentage, new LCmd("prog",null));
        }

        private void ChoiceButton1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button input = sender as System.Windows.Forms.Button;
            choice_id = int.Parse(input.Name[input.Name.Length - 1].ToString());
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ResizeChoiceButtons();
            openGLControl.Update();
            openGLControl1.Update();
            openGLInv_Resized(null,null);
            openGLControl_Resized(null, null);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                (skillBindingSource.List[e.RowIndex] as Skill).Points++;
                this.Update();
                this.Width++;
                this.Width--;
                dataGridView2.Update();
            }
        }

        private void openGLControl_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the OpenGLDraw event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RenderEventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Load the identity matrix.
            gl.LoadIdentity();

            //  Rotate around the Y axis.
            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            //  Draw a coloured pyramid.
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.End();

            //  Nudge the rotation.
            rotation += 1.0f;
        }



        /// <summary>
        /// Handles the OpenGLInitialized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the clear color.
            //gl.ClearColor(0, 0, 0, 0);
            gl.ClearColor(this.BackColor.R,this.BackColor.G,this.BackColor.B,this.BackColor.A);
        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  TODO: Set the projection matrix here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            //  Create a perspective transformation.
            gl.Perspective(60.0f, (double)openGLControl.Width / (double)openGLControl.Height, 0.01, 100.0);

            //  Use the 'look at' helper function to position and aim the camera.
            gl.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);

            //  Set the modelview matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        /// <summary>
        /// The current rotation.
        /// </summary>
        private float rotation = 0.0f;

        private void openGLInv_OpenGLDraw(object sender, RenderEventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gl = openGLControl1.OpenGL;

            //  Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Load the identity matrix.
            gl.LoadIdentity();

            //  Rotate around the Y axis.
            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            //  Draw a coloured pyramid.
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Color(0.0f, 0.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Color(1.0f, 0.5f, 0.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Color(1.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Color(0.0f, 0.0f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Color(1.0f, 0.5f, 0.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Color(1.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.End();
            gl.AttachShader(OpenGL.GL_FRAGMENT_SHADER, test.ShaderObject);

            //  Nudge the rotation.
            rotation += 1.0f;
        }



        /// <summary>
        /// Handles the OpenGLInitialized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        SharpGL.Shaders.Shader test;
        private void openGLInv_OpenGLInitialized(object sender, EventArgs e)
        {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            OpenGL gl = openGLControl1.OpenGL;

            //  Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
            gl.ClearColor(this.BackColor.R, this.BackColor.G, this.BackColor.B, this.BackColor.A);
            test = new SharpGL.Shaders.Shader();
            test.Create(gl, OpenGL.GL_FRAGMENT_SHADER, File.ReadAllText(Application.StartupPath + "/modelPreview.glsl"));
            gl.AttachShader(OpenGL.GL_FRAGMENT_SHADER, test.ShaderObject);
        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLInv_Resized(object sender, EventArgs e)
        {
            //  TODO: Set the projection matrix here.
            //  Get the OpenGL object.
            OpenGL gl = openGLControl1.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            //  Create a perspective transformation.
            gl.Perspective(60.0f, (double)openGLControl1.Width / (double)openGLControl1.Height, 0.01, 100.0);

            //  Use the 'look at' helper function to position and aim the camera.
            gl.LookAt(-5, -5, -5, 0, 0, 0, 0, 1, 0);

            //  Set the modelview matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
    }
}
