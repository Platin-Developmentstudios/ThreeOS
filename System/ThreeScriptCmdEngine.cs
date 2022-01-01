using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.System.ConsoleTools;
using ThreeOS.System.ThreeScript;
using Sys = Cosmos.System;

namespace ThreeOS.System.ThreeScript.CMD {
    internal class TScriptCmdManager {
        
        public static void EchoCMD(var echoString) {
            Console.WriteLine(echoString);
        }
        
        public static void RunCMD(var runPath) {
            if(runPath == "") {
                ConsoleInfo.Error("Not a valid ThreeScript File!");
            } else {
                TScriptEngine.Execute(TScriptPath);
            }
        }
        
    }
}
