using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game_Engine
{
    public class CharacterData
    {
        public string Name { get; set; }
        public bool isMale { get; set; }
        public CharacterData()
        {
            this.Name = "";
            this.isMale = true;
        }
    }
}
