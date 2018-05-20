using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PET
{
    class Settings
    {
        public enum SettingSources { Local, ComputerPolicy, UserPolicy }

        public int TimerInterval { get; set; } = 60;
        public int WarnThreshold { get; set; } = 14;
        public int WarnInterval { get; set; } = 24;
        public int AlertThreshold { get; set; } = 7;
        public int AlertInterval { get; set; } = 4;
        public string Action { get; set; } = "";
        public SettingSources Source { get; set; } = SettingSources.Local;

        public Settings()
        {
            this.Load();
        }

        public bool Load()
        {
            bool result = false;
            string policySubKey = "Software\\Policies\\PasswordExpiryTray";
            string userSubKey = "Software\\PasswordExpiryTray";

            RegistryKey localMachineRegistryKey = Registry.LocalMachine;
            RegistryKey currentUserRegistryKey = Registry.CurrentUser;

            RegistryKey computerPolicyRegistryKey = localMachineRegistryKey.OpenSubKey(policySubKey, false);
            RegistryKey userPolicyRegistryKey = currentUserRegistryKey.OpenSubKey(policySubKey, false);
            RegistryKey localUserSettings = currentUserRegistryKey.OpenSubKey(userSubKey, true);

            return result;
        }
    }
}
