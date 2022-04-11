using System;
using System.IO;
using System.Text;
using ThreeOS.TSystem.ConsoleTools;
using ThreeOS.TSystem.CMDManager;

namespace ThreeOS.TSystem.ThreeScript {
    
    internal class TScriptEngine {
        
        public static void Execute(string filename) {
            
            try {
                
                if((filename.EndsWith(".ths")) || (filename.EndsWith(".threescript"))) {
                    
                    string[] lines = File.ReadAllLines(filename);
                    foreach(string line in lines) {
                        
                        if(!(line.StartsWith("|"))) {
                            
                            if(line.StartsWith("help")) {

                                TCmdManager.HelpCMD();
                                
                            } else if(line.StartsWith("sysinfo")) {

                                TCmdManager.SysinfoCMD();
                                    
                            } else if (line.StartsWith("clear"))
                            {

                                TCmdManager.ClearCMD();

                            } else if (line.StartsWith("shutdown"))
                            {

                                TCmdManager.ShutdownCMD();

                            } else if (line.StartsWith("restart"))
                            {

                                TCmdManager.RestartCMD();

                            } else if (line.StartsWith("cd"))
                            {

                                string dirPath = line.Remove(0, 3);
                                TCmdManager.CdCMD(dirPath);

                            } else if (line.StartsWith("ls"))
                            {

                                TCmdManager.LsCMD();

                            } else if (line.StartsWith("mkfile"))
                            {

                                string thefilename = line.Remove(0, 7);
                                TCmdManager.MkfileCMD(thefilename);

                            } else if (line.StartsWith("mkdir"))
                            {

                                string dirname = line.Remove(0, 6);
                                TCmdManager.MkdirCMD(dirname);

                            } else if (line.StartsWith("run"))
                            {

                                string TScriptPath = line.Remove(0, 4);
                                TCmdManager.RunCMD(TScriptPath);

                            } else if (line.StartsWith("echo"))
                            {

                                string echoString = line.Remove(0, 5);
                                TCmdManager.EchoCMD(echoString);

                            } else {

                                Console.WriteLine("> Unknown Command or EOF <");

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
