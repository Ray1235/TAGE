using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Adventure_Game_Engine
{
    class InventoryItem
    {
        public string Name { get; set; }
        public string LocalizedName { get; set; }
        public System.Drawing.Image Icon { get; set; }
        public InventoryItem()
        {
            this.Name = "";
            this.LocalizedName = "";
            this.Icon = System.Drawing.Image.FromFile(Application.StartupPath+"/img/replace_me.png");
        }
    }
}
