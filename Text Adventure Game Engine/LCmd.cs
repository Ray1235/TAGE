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

/* File:        LCmd.cs
 * Purpose:     Class used for a hacky workaround for BackgroundWorker's ReportProgress
 */
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
