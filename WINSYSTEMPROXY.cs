using Microsoft.Win32;
using System;
using System.Runtime.InteropServices;


namespace SYSTEMPROXYBUDDY
{
    public static class WINSYSTEMPROXY
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        private const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        private const int INTERNET_OPTION_REFRESH = 37;
        private static bool settingsReturn, refreshReturn;
        public static bool proxyEnabled;
        public static string currentProxyServerHost;
        public static string currentProxyServerPort;

        public static bool EnableProxy(string proxyHost, string proxyPort, int type = 0)
        {
            string PROXY = proxyHost.Trim() + ":" + proxyPort.Trim();

            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

            registry.SetValue("ProxyServer", PROXY);
            registry.SetValue("ProxyEnable", 1);

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            proxyEnabled = true;

            return true;
        }

        public static bool DisableProxy()
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

            registry.SetValue("ProxyEnable", 0);

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            proxyEnabled = false;

            return true;
        }



        public static bool GetProxyStatus()
        {
            RegistryKey registry;
            registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            int currentProxyEnabledReg = int.Parse(registry.GetValue("ProxyEnable").ToString());
            if (currentProxyEnabledReg == 1)
            {
                proxyEnabled = true;
            }
            else
            {
                proxyEnabled = false;
            }
            string currentProxyServerReg;
            if (registry.GetValue("ProxyServer") == null)
            {
                currentProxyServerReg = "";
                currentProxyServerHost = "";
                currentProxyServerPort = "";
            }
            else
            {
                currentProxyServerReg = registry.GetValue("ProxyServer").ToString();
                currentProxyServerHost = currentProxyServerReg.Split(':')[0];
                currentProxyServerPort = currentProxyServerReg.Split(':')[1];
            }

            Console.WriteLine(currentProxyEnabledReg);
            Console.WriteLine(currentProxyServerReg);
            return true;
        }
    }
}
