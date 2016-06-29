using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Adventure_Game_Engine
{
    class Skill
    {
        public string Name { get; set; }
        public string LocalizedName { get; set; }
        public int Points { get; set; }
        public DataGridViewButtonColumn Increase { get; set; }
        public Skill()
        {
            this.Name = "null";
            this.LocalizedName = "GEN_NULL";
            this.Points = 0;
            this.Increase = new DataGridViewButtonColumn();
            //this.Increase.Click += Increase_Click;
            //this.Increase.Text = this.LocalizedName;
            //this.Increase.Text = "+1";
        }
        public Skill(string name, string localizedName)
        {
            this.Name = name;
            this.LocalizedName = localizedName;
            this.Points = 0;
            this.Increase = new DataGridViewButtonColumn();
            //this.Increase.Text = "+1";
            //this.Increase.Click += Increase_Click;
            //this.Increase.Text = this.LocalizedName;
        }

        void Increase_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Button input = sender as System.Windows.Forms.Button;
            this.Points++;
        }
    }
}
