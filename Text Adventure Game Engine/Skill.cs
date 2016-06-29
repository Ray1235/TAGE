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

/* File:        Skill.cs
 * Purpose:     Class which stores info for a skill
 */

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
