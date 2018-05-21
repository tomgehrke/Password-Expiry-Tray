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

        public int TimerInterval { get; set; }
        public int WarnThreshold { get; set; }
        public int WarnInterval { get; set; }
        public int AlertThreshold { get; set; }
        public int AlertInterval { get; set; }
        public string Action { get; set; }
        public SettingSources Source { get; set; }

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
            RegistryKey computerPolicyRegistryKey = localMachineRegistryKey.OpenSubKey(policySubKey, false);
            if (computerPolicyRegistryKey != null) // Take settings from Computer policy
            {
                Source = SettingSources.ComputerPolicy;
                LoadFromRegistry(computerPolicyRegistryKey);
                computerPolicyRegistryKey.Close();
                localMachineRegistryKey.Close();
            }
            else
            {
                RegistryKey currentUserRegistryKey = Registry.CurrentUser;
                RegistryKey userPolicyRegistryKey = currentUserRegistryKey.OpenSubKey(policySubKey, false);
                if (userPolicyRegistryKey != null) // Take settings from User policy
                {
                    Source = SettingSources.UserPolicy;
                    LoadFromRegistry(userPolicyRegistryKey);
                    userPolicyRegistryKey.Close();
                }
                else
                {
                    RegistryKey localUserSettings = currentUserRegistryKey.OpenSubKey(userSubKey, true);
                    if (localUserSettings != null) // Take settings from default app location
                    {
                        Source = SettingSources.Local;
                        LoadFromRegistry(localUserSettings);
                        localUserSettings.Close();
                    } else
                    {
                        LoadDefaults();
                    }
                }
                currentUserRegistryKey.Close();
            }

            return result;
        }

        private bool LoadFromRegistry(RegistryKey registryKey)
        {
            bool result = false;


            return result;
        }

        private void LoadDefaults()
        {
            TimerInterval = 60;
            WarnThreshold = 21;
            WarnInterval = 24;
            AlertThreshold = 7;
            AlertInterval = 4;
            Action = "";
        }
    }
}
