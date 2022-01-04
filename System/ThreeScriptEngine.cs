using System;
using System.IO;
using System.Text;
using ThreeOS.System.ConsoleTools;
using ThreeOS.System.ThreeScript.CMD;

namespace ThreeOS.System.ThreeScript {
    
    internal class TScriptEngine {
        
        public static void Execute(string filename) {
            
            try {
                
                if((filename.EndsWith(".ths")) || (filename.EndsWith(".threescript"))) {
                    
                    string[] lines = file.ReadAllLines(filename);
                    foreach(string line in lines) {
                        
                        if(!(line.StartsWith("|"))) {
                            
                            if(line.StartsWith("echo")) {
                                
                                string echoContent = line.Remove(0, 5);
                                TScriptCmdManager.EchoCMD(echoContent);
                                
                            } else if(line.StartsWith("run")) {
                                
                                var runFile = line.Remove(0, 4);
                                TScriptCmdManager.RunCMD(runFile);
                                    
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
