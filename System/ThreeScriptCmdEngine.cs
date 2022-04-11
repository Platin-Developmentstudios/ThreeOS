using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.TSystem.ConsoleTools;
using ThreeOS.TSystem.ThreeScript;
using Sys = Cosmos.System;

namespace ThreeOS.TSystem.ThreeScript.CMD {
    
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

        public static void MkfileCMD(string filename) {

            string CurrentDirectory = Kernel.CurrentDirectory;

            if (filename == "")
            {
                ConsoleInfo.Error("Please enter a File name");
            }
            else
            {
                try
                {
                    var file_stream = File.Create(CurrentDirectory + filename);
                }
                catch (Exception e)
                {
                    ConsoleInfo.Error(e.ToString());
                }
                ConsoleInfo.OK("File successfully created.");
            }

        }

        public static void ClearCMD() {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

        }

    }

}
