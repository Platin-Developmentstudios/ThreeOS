using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
using Cosmos.System.Network;
using Cosmos.System.Network.Config;
using Cosmos.System.Network.IPv4;

/*
 * 
 *   Not in use yet.
 * 
 */

namespace ThreeOS.TSystem.TNetworkManager
{
    internal class TNetworker
    {
        public static void StartNetwork()
        {
            NetworkDevice nic = NetworkDevice.GetDeviceByName("eth0");
            IPConfig.Enable(nic, new Address(192, 168, 1, 69), new Address(255, 255, 255, 0), new Address(192, 168, 1, 254));
        }
    }
}
