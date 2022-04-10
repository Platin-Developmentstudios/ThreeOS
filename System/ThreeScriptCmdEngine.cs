using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.System64.ConsoleTools;
using ThreeOS.System64.ThreeScript;
using Sys = Cosmos.System;

namespace ThreeOS.System64.ThreeScript.CMD {
    
    internal class TScriptCmdManager {
        
        public static void EchoCMD(string echoString) {
            
            Console.WriteLine(echoString);
            
        }
        
        public static void RunCMD(string runPath) {
            
            if(runPath == "") {
                
                ConsoleInfo.Error("Not a valid ThreeScript File!");
                
            } else {
                
                TScriptEngine.Execute(runPath);
                
            }
        }
        
    }
}
