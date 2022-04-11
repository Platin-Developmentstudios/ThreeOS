using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeOS;
using ThreeOS.TSystem.ConsoleTools;

namespace ThreeOS.TSystem.KernelUtils
{
    class KernelUtils
    {
        public static string CurrentDirectory = Kernel.CurrentDirectory;
        public static string CurrentUser = Kernel.CurrentUser;
        public static string ComputerName = Kernel.ComputerName;
        public static string BuildVersion = Kernel.BuildVer;
    }
}
