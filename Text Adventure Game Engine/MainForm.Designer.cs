namespace Text_Adventure_Game_Engine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.changeSaveSlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSlot1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSlot2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSlot3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeSlot4 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.checkScriptValidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ChoiceButton4 = new System.Windows.Forms.Button();
            this.ChoiceButton2 = new System.Windows.Forms.Button();
            this.ChoiceButton1 = new System.Windows.Forms.Button();
            this.ChoiceButton3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.InventoryTab = new System.Windows.Forms.TabPage();
            this.SkillTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CharacterTab = new System.Windows.Forms.TabPage();
            this.dialogueHandler = new System.ComponentModel.BackgroundWorker();
            this.choiceHandler = new System.ComponentModel.BackgroundWorker();
            this.openGLControl = new SharpGL.OpenGLControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.iconDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.localizedNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localizedNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.increaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.skillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.InventoryTab.SuspendLayout();
            this.SkillTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.CharacterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.tToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.changeSaveSlotToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem1.Text = "Start game";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // changeSaveSlotToolStripMenuItem
            // 
            this.changeSaveSlotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeSlot1,
            this.ChangeSlot2,
            this.ChangeSlot3,
            this.ChangeSlot4});
            this.changeSaveSlotToolStripMenuItem.Name = "changeSaveSlotToolStripMenuItem";
            this.changeSaveSlotToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.changeSaveSlotToolStripMenuItem.Text = "Change save slot...";
            this.changeSaveSlotToolStripMenuItem.Click += new System.EventHandler(this.changeSaveSlotToolStripMenuItem_Click);
            // 
            // ChangeSlot1
            // 
            this.ChangeSlot1.CheckOnClick = true;
            this.ChangeSlot1.Name = "ChangeSlot1";
            this.ChangeSlot1.Size = new System.Drawing.Size(103, 22);
            this.ChangeSlot1.Text = "Slot 1";
            // 
            // ChangeSlot2
            // 
            this.ChangeSlot2.CheckOnClick = true;
            this.ChangeSlot2.Name = "ChangeSlot2";
            this.ChangeSlot2.Size = new System.Drawing.Size(103, 22);
            this.ChangeSlot2.Text = "Slot 2";
            // 
            // ChangeSlot3
            // 
            this.ChangeSlot3.CheckOnClick = true;
            this.ChangeSlot3.Name = "ChangeSlot3";
            this.ChangeSlot3.Size = new System.Drawing.Size(103, 22);
            this.ChangeSlot3.Text = "Slot 3";
            // 
            // ChangeSlot4
            // 
            this.ChangeSlot4.CheckOnClick = true;
            this.ChangeSlot4.Name = "ChangeSlot4";
            this.ChangeSlot4.Size = new System.Drawing.Size(103, 22);
            this.ChangeSlot4.Text = "Slot 4";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // tToolStripMenuItem
            // 
            this.tToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringEditorToolStripMenuItem,
            this.translationEditorToolStripMenuItem,
            this.gameSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.checkScriptValidityToolStripMenuItem});
            this.tToolStripMenuItem.Name = "tToolStripMenuItem";
            this.tToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tToolStripMenuItem.Text = "Tools";
            this.tToolStripMenuItem.Visible = false;
            // 
            // stringEditorToolStripMenuItem
            // 
            this.stringEditorToolStripMenuItem.Name = "stringEditorToolStripMenuItem";
            this.stringEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stringEditorToolStripMenuItem.Text = "String Editor";
            // 
            // translationEditorToolStripMenuItem
            // 
            this.translationEditorToolStripMenuItem.Name = "translationEditorToolStripMenuItem";
            this.translationEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.translationEditorToolStripMenuItem.Text = "Translation Editor";
            // 
            // gameSettingsToolStripMenuItem
            // 
            this.gameSettingsToolStripMenuItem.Name = "gameSettingsToolStripMenuItem";
            this.gameSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gameSettingsToolStripMenuItem.Text = "Game settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // checkScriptValidityToolStripMenuItem
            // 
            this.checkScriptValidityToolStripMenuItem.Name = "checkScriptValidityToolStripMenuItem";
            this.checkScriptValidityToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkScriptValidityToolStripMenuItem.Text = "Check script validity";
            this.checkScriptValidityToolStripMenuItem.Click += new System.EventHandler(this.checkScriptValidityToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.InventoryTab);
            this.tabControl1.Controls.Add(this.SkillTab);
            this.tabControl1.Controls.Add(this.CharacterTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 407);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.ChoiceButton4);
            this.tabPage2.Controls.Add(this.ChoiceButton2);
            this.tabPage2.Controls.Add(this.ChoiceButton1);
            this.tabPage2.Controls.Add(this.ChoiceButton3);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Story";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(8, 307);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(396, 10);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 5;
            // 
            // ChoiceButton4
            // 
            this.ChoiceButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoiceButton4.Enabled = false;
            this.ChoiceButton4.Location = new System.Drawing.Point(278, 352);
            this.ChoiceButton4.Name = "ChoiceButton4";
            this.ChoiceButton4.Size = new System.Drawing.Size(126, 23);
            this.ChoiceButton4.TabIndex = 4;
            this.ChoiceButton4.Text = "...";
            this.ChoiceButton4.UseVisualStyleBackColor = true;
            this.ChoiceButton4.Click += new System.EventHandler(this.ChoiceButton1_Click);
            // 
            // ChoiceButton2
            // 
            this.ChoiceButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoiceButton2.Enabled = false;
            this.ChoiceButton2.Location = new System.Drawing.Point(278, 323);
            this.ChoiceButton2.Name = "ChoiceButton2";
            this.ChoiceButton2.Size = new System.Drawing.Size(126, 23);
            this.ChoiceButton2.TabIndex = 3;
            this.ChoiceButton2.Text = "Choice 2";
            this.ChoiceButton2.UseVisualStyleBackColor = true;
            this.ChoiceButton2.Click += new System.EventHandler(this.ChoiceButton1_Click);
            // 
            // ChoiceButton1
            // 
            this.ChoiceButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChoiceButton1.Enabled = false;
            this.ChoiceButton1.Location = new System.Drawing.Point(8, 323);
            this.ChoiceButton1.Name = "ChoiceButton1";
            this.ChoiceButton1.Size = new System.Drawing.Size(126, 23);
            this.ChoiceButton1.TabIndex = 2;
            this.ChoiceButton1.Text = "Choice 1";
            this.ChoiceButton1.UseVisualStyleBackColor = true;
            this.ChoiceButton1.Click += new System.EventHandler(this.ChoiceButton1_Click);
            // 
            // ChoiceButton3
            // 
            this.ChoiceButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChoiceButton3.Enabled = false;
            this.ChoiceButton3.Location = new System.Drawing.Point(8, 352);
            this.ChoiceButton3.Name = "ChoiceButton3";
            this.ChoiceButton3.Size = new System.Drawing.Size(126, 23);
            this.ChoiceButton3.TabIndex = 1;
            this.ChoiceButton3.Text = "Choice 3";
            this.ChoiceButton3.UseVisualStyleBackColor = true;
            this.ChoiceButton3.Click += new System.EventHandler(this.ChoiceButton1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(396, 295);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // InventoryTab
            // 
            this.InventoryTab.Controls.Add(this.splitContainer1);
            this.InventoryTab.Location = new System.Drawing.Point(4, 22);
            this.InventoryTab.Name = "InventoryTab";
            this.InventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.InventoryTab.Size = new System.Drawing.Size(412, 381);
            this.InventoryTab.TabIndex = 2;
            this.InventoryTab.Text = "Inventory";
            this.InventoryTab.UseVisualStyleBackColor = true;
            // 
            // SkillTab
            // 
            this.SkillTab.Controls.Add(this.dataGridView2);
            this.SkillTab.Location = new System.Drawing.Point(4, 22);
            this.SkillTab.Name = "SkillTab";
            this.SkillTab.Size = new System.Drawing.Size(412, 381);
            this.SkillTab.TabIndex = 3;
            this.SkillTab.Text = "Skills";
            this.SkillTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.localizedNameDataGridViewTextBoxColumn1,
            this.pointsDataGridViewTextBoxColumn,
            this.increaseDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.skillBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(412, 381);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // CharacterTab
            // 
            this.CharacterTab.Controls.Add(this.openGLControl);
            this.CharacterTab.Location = new System.Drawing.Point(4, 22);
            this.CharacterTab.Name = "CharacterTab";
            this.CharacterTab.Size = new System.Drawing.Size(412, 381);
            this.CharacterTab.TabIndex = 4;
            this.CharacterTab.Text = "Character";
            this.CharacterTab.UseVisualStyleBackColor = true;
            // 
            // dialogueHandler
            // 
            this.dialogueHandler.WorkerReportsProgress = true;
            this.dialogueHandler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dialogueHandler_DoWork);
            this.dialogueHandler.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.dialogueHandler_ProgressChanged);
            this.dialogueHandler.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dialogueHandler_RunWorkerCompleted);
            // 
            // choiceHandler
            // 
            this.choiceHandler.WorkerReportsProgress = true;
            this.choiceHandler.WorkerSupportsCancellation = true;
            this.choiceHandler.DoWork += new System.ComponentModel.DoWorkEventHandler(this.choiceHandler_DoWork);
            this.choiceHandler.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.choiceHandler_ProgressChanged);
            // 
            // openGLControl
            // 
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.Location = new System.Drawing.Point(0, 0);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(412, 381);
            this.openGLControl.TabIndex = 1;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Load += new System.EventHandler(this.openGLControl_Load);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iconDataGridViewImageColumn,
            this.localizedNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryItemBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(267, 375);
            this.dataGridView1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.openGLControl1);
            this.splitContainer1.Size = new System.Drawing.Size(406, 375);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 2;
            // 
            // openGLControl1
            // 
            this.openGLControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.FrameRate = 30;
            this.openGLControl1.Location = new System.Drawing.Point(0, 0);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(135, 375);
            this.openGLControl1.TabIndex = 2;
            this.openGLControl1.OpenGLInitialized += new System.EventHandler(this.openGLInv_OpenGLInitialized);
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLInv_OpenGLDraw);
            this.openGLControl1.Resized += new System.EventHandler(this.openGLInv_Resized);
            // 
            // iconDataGridViewImageColumn
            // 
            this.iconDataGridViewImageColumn.DataPropertyName = "Icon";
            this.iconDataGridViewImageColumn.HeaderText = "Image";
            this.iconDataGridViewImageColumn.Name = "iconDataGridViewImageColumn";
            this.iconDataGridViewImageColumn.ReadOnly = true;
            // 
            // localizedNameDataGridViewTextBoxColumn
            // 
            this.localizedNameDataGridViewTextBoxColumn.DataPropertyName = "LocalizedName";
            this.localizedNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.localizedNameDataGridViewTextBoxColumn.Name = "localizedNameDataGridViewTextBoxColumn";
            this.localizedNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // inventoryItemBindingSource
            // 
            this.inventoryItemBindingSource.DataSource = typeof(Text_Adventure_Game_Engine.InventoryItem);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // localizedNameDataGridViewTextBoxColumn1
            // 
            this.localizedNameDataGridViewTextBoxColumn1.DataPropertyName = "LocalizedName";
            this.localizedNameDataGridViewTextBoxColumn1.HeaderText = "Skill";
            this.localizedNameDataGridViewTextBoxColumn1.Name = "localizedNameDataGridViewTextBoxColumn1";
            this.localizedNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pointsDataGridViewTextBoxColumn
            // 
            this.pointsDataGridViewTextBoxColumn.DataPropertyName = "Points";
            this.pointsDataGridViewTextBoxColumn.HeaderText = "Points";
            this.pointsDataGridViewTextBoxColumn.Name = "pointsDataGridViewTextBoxColumn";
            this.pointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // increaseDataGridViewTextBoxColumn
            // 
            this.increaseDataGridViewTextBoxColumn.DataPropertyName = "Increase";
            this.increaseDataGridViewTextBoxColumn.HeaderText = "Add skill point";
            this.increaseDataGridViewTextBoxColumn.Name = "increaseDataGridViewTextBoxColumn";
            this.increaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.increaseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.increaseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.increaseDataGridViewTextBoxColumn.Text = "+1";
            this.increaseDataGridViewTextBoxColumn.UseColumnTextForButtonValue = true;
            // 
            // skillBindingSource
            // 
            this.skillBindingSource.DataSource = typeof(Text_Adventure_Game_Engine.Skill);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 434);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.InventoryTab.ResumeLayout(false);
            this.SkillTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.CharacterTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSaveSlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeSlot1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeSlot2;
        private System.Windows.Forms.ToolStripMenuItem ChangeSlot3;
        private System.Windows.Forms.ToolStripMenuItem ChangeSlot4;
        private System.Windows.Forms.ToolStripMenuItem tToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameSettingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem checkScriptValidityToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ChoiceButton4;
        private System.Windows.Forms.Button ChoiceButton2;
        private System.Windows.Forms.Button ChoiceButton1;
        private System.Windows.Forms.Button ChoiceButton3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.ComponentModel.BackgroundWorker dialogueHandler;
        private System.ComponentModel.BackgroundWorker choiceHandler;
        private System.Windows.Forms.TabPage InventoryTab;
        private System.Windows.Forms.TabPage SkillTab;
        private System.Windows.Forms.TabPage CharacterTab;
        private System.Windows.Forms.BindingSource inventoryItemBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource skillBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizedNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn increaseDataGridViewTextBoxColumn;
        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn iconDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localizedNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private SharpGL.OpenGLControl openGLControl1;
    }
}

