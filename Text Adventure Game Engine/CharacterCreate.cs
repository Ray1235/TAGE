using System;
using System.Windows.Forms;

namespace Text_Adventure_Game_Engine
{
    public partial class CharacterCreate : Form
    {
        public CharacterData Plr;
        public CharacterCreate(string name, bool isMale)
        {
            InitializeComponent();
            this.textBox1.Text = name;
            if (isMale) this.comboBox1.SelectedIndex = 0;
            else this.comboBox1.SelectedIndex = 1;
        }

        private void wizardPageContainer1_Finished(object sender, EventArgs e)
        {
            CharacterData cd = new CharacterData();
            if (this.comboBox1.SelectedIndex == 0) cd.isMale = true;
            else cd.isMale = false;
            cd.Name = this.textBox1.Text;
            Plr = cd;
            Close();
        }

        private void wizardPageContainer1_SelectedPageChanged(object sender, EventArgs e)
        {
            string[] headers = new string[] { "" };
            if (wizardPageContainer1.SelectedPage.Text != null)
                headers = wizardPageContainer1.SelectedPage.Text.Split('|');
            headerLabel.Text = headers[0];
            if (headers.Length == 2)
                subHeaderLabel.Text = headers[1];
        }

        private void wizardPage1_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            headerPanel.Visible = topDivider.Visible = false;
            startEndPicture.Visible = true;
        }

        private void wizardPage2_Initialize(object sender, AeroWizard.WizardPageInitEventArgs e)
        {
            headerPanel.Visible = topDivider.Visible = true;
            startEndPicture.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") this.nextButton.Enabled = false;
            else this.nextButton.Enabled = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
