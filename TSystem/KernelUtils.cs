using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.TSystem.ConsoleTools;
using ThreeOS.TSystem.ThreeScript;
using ThreeOS.TSystem.CMDManager;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using ThreeOS.TSystem.VersionUtils;

namespace ThreeOS.TSystem.KernelUtils
{
    internal class KernelUtils
    {
        public static string CurrentDirectory = Kernel.CurrentDirectory;
        public static string CurrentUser = Kernel.CurrentUser;
        public static string ComputerName = Kernel.ComputerName;
        public static string BuildVersion = VersionInfo.BuildVersion;
    }

    internal class BootUtils
    {
        public static void Startup()
        {
            ConsoleInfo.Wait("Initialize FileSystem...");
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            ConsoleInfo.OK("FileSystem Initialized");

            ConsoleInfo.Wait("Checking System...");
            if (!Directory.Exists(@"0:\system"))
            {
                ConsoleInfo.Wait("Creating Directorys...");
                try
                {

                    Directory.CreateDirectory(@"0:\system");
                    Directory.CreateDirectory(@"0:\system\dev");
                    Directory.CreateDirectory(@"0:\system\mnt");
                    Directory.CreateDirectory(@"0:\system\cfg");
                    Directory.CreateDirectory(@"0:\system\var");

                }
                catch (Exception e)
                {

                    ConsoleInfo.Error(e.ToString());

                }
                ConsoleInfo.Info("Directorys Created.");
            }
            ConsoleInfo.OK("System Check");
            Console.Clear();
            ConsoleUtils.WriteLogo();
        }
    }
}
