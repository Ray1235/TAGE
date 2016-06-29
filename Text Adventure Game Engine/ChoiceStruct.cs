using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game_Engine
{
    class ChoiceStruct
    {
        public float timer { get; set; }
        public string c1 { get; set; }
        public string c2 { get; set; }
        public string c3 { get; set; }
        public string c4 { get; set; }
        public int Count { get; set; }
        public ChoiceStruct()
        {
            this.timer = 0;
            this.c1 = "";
            this.c2 = "";
            this.c3 = "";
            this.c4 = "";
            this.Count = 0;
        }
    }
}
