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

/* File:        Program.cs
 * Purpose:     Main entry point
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoonSharp.Interpreter;

namespace Text_Adventure_Game_Engine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string GameName { get; private set; }
        [STAThread]
        static void Main()
        {
            GameName = "test1";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
