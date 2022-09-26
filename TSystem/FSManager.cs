using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using ThreeOS.TSystem.ConsoleTools;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using Cosmos.System.Graphics;

namespace ThreeOS.TSystem.FSManager {
  
    internal class TFS {
      
        public static void initTFS() {
            ConsoleInfo.Wait("Initialize ThreeFS...");
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            ConsoleInfo.OK("ThreeFS Initialized");

            ConsoleInfo.Wait("Checking System...");
            if (!Directory.Exists("0:\\system"))
            {
                ConsoleInfo.Wait("Creating Directorys...");
                try
                {
                    Directory.CreateDirectory("0:\\system");
                    Directory.CreateDirectory("0:\\system\\dev");
                    Directory.CreateDirectory("0:\\system\\mnt");
                    Directory.CreateDirectory("0:\\system\\cfg");
                    Directory.CreateDirectory("0:\\system\\var");
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