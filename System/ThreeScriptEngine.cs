using System;
using System.IO;
using System.Text;
using ThreeOS.System.ConsoleTools;

namespace ThreeOS.System.ThreeScript {
    internal class TScriptEngine {
        public static void Execute(string filename) {
            try {
                if((filename.EndsWith(".ths")) || (filename.EndsWith(".threescript"))) {
                    string[] lines = file.ReadAllLines(filename);
                    foreach(string line in lines) {
                        if(!(line.StartsWith("|"))) {
                            switch(line.StartsWith()) {
                                case "echo":
                                    var echoContent = line.Remove(0, 5);
                                    Console.WriteLine(echoContent);
                                    break;
                                    
                                default:
                                    break;
                            }
                        }
                    }
                } else 
                {
                    ConsoleInfo.Error("This is not a valid ThreeScript!");
                }
            } catch(Exception e)
            {
                ConsoleInfo.Error(e.ToString());
            }
        }
    }
}