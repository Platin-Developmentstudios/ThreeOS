using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.TSystem.ConsoleTools;
using ThreeOS.TSystem.ThreeScript;
using ThreeOS.TSystem.CMDManager;
using ThreeOS.TSystem.KernelUtils;
using ThreeOS.TSystem.VersionUtils;
using ThreeOS.TSystem.TNetworkManager;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace ThreeOS
{
    public class Kernel: Sys.Kernel
    {

        public static string CurrentDirectory = "0:\\system";
        public static string CurrentUser = "Admin";
        public static string ComputerName = "ThreeOS";
        public static string BuildVer = VersionInfo.BuildVersion;

        protected override void BeforeRun() {

            BootUtils.InitFS();
            
        }
        
        protected override void Run() {

            ConsoleUtils.PrintCmdLine();

            var input = Console.ReadLine();

            /*
                 ——————————No switch case?————————————— 
                ⠀⣞⢽⢪⢣⢣⢣⢫⡺⡵⣝⡮⣗⢷⢽⢽⢽⣮⡷⡽⣜⣜⢮⢺⣜⢷⢽⢝⡽⣝ 
                ⠸⡸⠜⠕⠕⠁⢁⢇⢏⢽⢺⣪⡳⡝⣎⣏⢯⢞⡿⣟⣷⣳⢯⡷⣽⢽⢯⣳⣫⠇ 
                ⠀⠀⢀⢀⢄⢬⢪⡪⡎⣆⡈⠚⠜⠕⠇⠗⠝⢕⢯⢫⣞⣯⣿⣻⡽⣏⢗⣗⠏⠀ 
                ⠀⠪⡪⡪⣪⢪⢺⢸⢢⢓⢆⢤⢀⠀⠀⠀⠀⠈⢊⢞⡾⣿⡯⣏⢮⠷⠁⠀⠀
                ⠀⠀⠀⠈⠊⠆⡃⠕⢕⢇⢇⢇⢇⢇⢏⢎⢎⢆⢄⠀⢑⣽⣿⢝⠲⠉⠀⠀⠀⠀
                ⠀⠀⠀⠀⠀⡿⠂⠠⠀⡇⢇⠕⢈⣀⠀⠁⠡⠣⡣⡫⣂⣿⠯⢪⠰⠂⠀⠀⠀⠀
                ⠀⠀⠀⠀⡦⡙⡂⢀⢤⢣⠣⡈⣾⡃⠠⠄⠀⡄⢱⣌⣶⢏⢊⠂⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⢝⡲⣜⡮⡏⢎⢌⢂⠙⠢⠐⢀⢘⢵⣽⣿⡿⠁⠁⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⠨⣺⡺⡕⡕⡱⡑⡆⡕⡅⡕⡜⡼⢽⡻⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⣼⣳⣫⣾⣵⣗⡵⡱⡡⢣⢑⢕⢜⢕⡝⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⣴⣿⣾⣿⣿⣿⡿⡽⡑⢌⠪⡢⡣⣣⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⡟⡾⣿⢿⢿⢵⣽⣾⣼⣘⢸⢸⣞⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ⠀⠀⠀⠀⠁⠇⠡⠩⡫⢿⣝⡻⡮⣒⢽⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                ———————————————————————————
             */

            if (input.StartsWith("help")) {

                TCmdManager.HelpCMD();
                    
            } else if(input.StartsWith("sysinfo")) {

                TCmdManager.SysinfoCMD();
                 
            } else if(input.StartsWith("clear")) {

                TCmdManager.ClearCMD();
            
            } else if(input.StartsWith("shutdown")) {

                TCmdManager.ShutdownCMD();
                    
            } else if(input.StartsWith("restart")) {

                TCmdManager.RestartCMD();
            
            } else if(input.StartsWith("cd")) {
                
                string dirPath = input.Remove(0, 3);
                TCmdManager.CdCMD(dirPath);
                    
            } else if(input.StartsWith("ls")) {

                TCmdManager.LsCMD();
                
            } else if(input.StartsWith("mkfile")) {
                
                string filename = input.Remove(0, 7);
                TCmdManager.MkfileCMD(filename);
                    
            } else if(input.StartsWith("mkdir")) {

                string dirname = input.Remove(0, 6);
                TCmdManager.MkdirCMD(dirname);
                    
            } else if(input.StartsWith("run")) {
                
                string TScriptPath = input.Remove(0, 4);
                TCmdManager.RunCMD(TScriptPath);
                    
            } else if(input.StartsWith("echo")) {
                
                string echoString = input.Remove(0, 5);
                TCmdManager.EchoCMD(echoString);
                    
            } else if(input.StartsWith("error")) {

                TCmdManager.ErrorCMD();

            } else {
            
                ConsoleInfo.Error("Command not Found");
                
            }
        }
    }
}

