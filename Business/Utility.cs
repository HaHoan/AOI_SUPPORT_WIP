using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using SPC_SUPPORT_WIP.Entities;

namespace SPC_SUPPORT_WIP.Business
{
    public class Utility
    {
        public static string GetRunningVersion()
        {

            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }

        }

        public static void ActiveProcess(string title)
        {
            Process[] processes = Process.GetProcesses();
            int windowHandle = 0;
            foreach (Process p in processes)
            {
                if (p.MainWindowTitle.Contains(title))
                {
                    windowHandle = (int)p.MainWindowHandle;
                    break;
                }

            }
            NativeWin32.SetForegroundWindow(windowHandle);
        }

        public static string GetValueRegistryKey(string keyName)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(KeyName.PATH_CONFIG);
            string value = null;
            if (key != null)
            {
                if (key.GetValue(keyName) != null)
                {
                    value = key.GetValue(keyName).ToString();
                    key.Close();
                    return value;
                }
            }

            return null;
        }

        public static void WriteRegistry(string stringValue, string content)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(KeyName.PATH_CONFIG);
            if (!string.IsNullOrEmpty(stringValue) && !string.IsNullOrEmpty(content))
            {
                key.SetValue(stringValue, content);
                key.Close();
            }
        }
      
    }

    public class KeyName
    {
       
        public const string PATH_CONFIG = @"SOFTWARE\AOI_SUPPORT_WIP\Configs";
        public const string CURRENT_MODEL = "CURRENT_MODEL";
        public const string PC_NAME = "PC_NAME";
        public const string MACHINE_NAME = "MACHINE_NAME";
        public const string SLEEP_TIME = "SLEEP_TIME";
        public const string STATION = "STATION";
        public const string STATION_INDEX = "STATION_INDEX";
        public const string STATION_TO = "STATION_TO";
    }
}
