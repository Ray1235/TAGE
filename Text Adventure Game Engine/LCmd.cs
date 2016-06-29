using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Game_Engine
{
    class LCmd
    {
        public string Cmd { get; set; }
        public object Arg { get; set; }
        public LCmd()
        {
            this.Cmd = "null";
            this.Arg = "" as string;
        }
        public LCmd(string cmd, object arg)
        {
            this.Cmd = cmd;
            this.Arg = arg;
        }
    }
}
