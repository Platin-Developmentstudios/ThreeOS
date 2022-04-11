using System;
using System.IO;
using System.Text;
using ThreeOS.TSystem.ConsoleTools;
using ThreeOS.TSystem.ThreeScript.CMD;

namespace ThreeOS.TSystem.ThreeScript {
    
    internal class TScriptEngine {
        
        public static void Execute(string filename) {
            
            try {
                
                if((filename.EndsWith(".ths")) || (filename.EndsWith(".threescript"))) {
                    
                    string[] lines = File.ReadAllLines(filename);
                    foreach(string line in lines) {
                        
                        if(!(line.StartsWith("|"))) {
                            
                            if(line.StartsWith("echo")) {
                                
                                string echoContent = line.Remove(0, 5);
                                TScriptCmdManager.EchoCMD(echoContent);
                                
                            } else if(line.StartsWith("run")) {
                                
                                var runFile = line.Remove(0, 4);
                                TScriptCmdManager.RunCMD(runFile);
                                    
                            } if (line.StartsWith("mkfile"))
                            {

                                var mkfilep = line.Remove(0, 7);
                                TScriptCmdManager.MkfileCMD(mkfilep);

                            } if (line.StartsWith("clear")) {

                                TScriptCmdManager.ClearCMD();

                            } else {

                                Console.WriteLine("> INT <");

                            }
                        }
                    }
                } else {
                    
                    ConsoleInfo.Error("This is not a valid ThreeScript!");
                    
                }
            } catch(Exception e) {
                
                ConsoleInfo.Error(e.ToString());
                
            }
        }
    }
}
