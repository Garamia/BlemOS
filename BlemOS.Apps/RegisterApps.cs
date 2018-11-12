using BlemOS.Registry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Apps
{
    public static class RegisterApps
    {
        public static void registerapps()
        {
            AppRegistry.registerApp(typeof(SettingsAppMain), "Settings");
            AppRegistry.registerApp(typeof(HybridModeAppMain), "Hybrid Mode");
        }
    }
}
