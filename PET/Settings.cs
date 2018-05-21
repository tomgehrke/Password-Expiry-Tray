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
        public enum SettingSource { Local = 0, UserPolicy, ComputerPolicy }
        public enum Setting { All = 0, Action, AlertInterval, AlertThreshold, TimerInterval, WarnInterval, WarnThreshold }

        public int TimerInterval { get; set; }
        public int WarnThreshold { get; set; }
        public int WarnInterval { get; set; }
        public int AlertThreshold { get; set; }
        public int AlertInterval { get; set; }
        public string Action { get; set; }
        public SettingSource Source { get; set; }

        public Settings()
        {
            this.Load();
        }

        public void Load()
        {
            string policySubKey = "Software\\Policies\\PasswordExpiryTray";
            string userSubKey = "Software\\PasswordExpiryTray";

            RegistryKey localMachineRegistryKey = Registry.LocalMachine;
            RegistryKey computerPolicyRegistryKey = localMachineRegistryKey.OpenSubKey(policySubKey, false);
            if (computerPolicyRegistryKey != null) // Take settings from Computer policy
            {
                Source = SettingSource.ComputerPolicy;
                GetRegistrySettings(computerPolicyRegistryKey);
                computerPolicyRegistryKey.Close();
                localMachineRegistryKey.Close();
            }
            else
            {
                RegistryKey currentUserRegistryKey = Registry.CurrentUser;
                RegistryKey userPolicyRegistryKey = currentUserRegistryKey.OpenSubKey(policySubKey, false);
                if (userPolicyRegistryKey != null) // Take settings from User policy
                {
                    Source = SettingSource.UserPolicy;
                    GetRegistrySettings(userPolicyRegistryKey);
                    userPolicyRegistryKey.Close();
                }
                else
                {
                    RegistryKey localUserSettings = currentUserRegistryKey.OpenSubKey(userSubKey, true);
                    if (localUserSettings != null) // Take settings from default app location
                    {
                        Source = SettingSource.Local;
                        GetRegistrySettings(localUserSettings);
                        localUserSettings.Close();
                    }
                    else
                    {
                        LoadDefaults();
                    }
                }
                currentUserRegistryKey.Close();
            }
        }

        private void GetRegistrySettings(RegistryKey registryKey)
        {
            //TODO: read values from registry

            // Check & fix values just in case someone got cute with the registry
            bool fixRequired = false;

            if (TimerInterval < 1) { LoadDefaults(Setting.TimerInterval); fixRequired = true; }
            if (AlertThreshold < 1) { LoadDefaults(Setting.AlertThreshold); fixRequired = true; }
            if (AlertInterval < 1) { LoadDefaults(Setting.AlertInterval); fixRequired = true; }
            if (WarnThreshold < 1) { LoadDefaults(Setting.WarnThreshold); fixRequired = true; }
            if (WarnInterval < 1) { LoadDefaults(Setting.WarnInterval); fixRequired = true; }

            // Update the registry with fixed values
            // Note: Can only fix local settings. Values pushed by policy will need an AD administrator to address.
            if (fixRequired && Source == SettingSource.Local)
            {
                SetRegistrySettings();
            }
        }

        private void SetRegistrySettings()
        {

        }

        private void LoadDefaults(Setting setting = Setting.All)
        {
            if (setting == Setting.All || setting == Setting.TimerInterval) { TimerInterval = 60; }
            if (setting == Setting.All || setting == Setting.WarnInterval) { WarnInterval = 24; }
            if (setting == Setting.All || setting == Setting.WarnThreshold) { WarnThreshold = 21; }
            if (setting == Setting.All || setting == Setting.AlertInterval) { AlertInterval = 4; }
            if (setting == Setting.All || setting == Setting.AlertThreshold) { AlertThreshold = 7; }
            if (setting == Setting.All || setting == Setting.Action) { Action = ""; }
        }
    }
}
