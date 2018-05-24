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
        public string ErrorMessage { get; private set; } = "";

        private const string PolicySettingsSubKey = "Software\\Policies\\PasswordExpiryTray";
        private const string LocalSettingsSubKey = "Software\\PasswordExpiryTray";

        public Settings()
        {
            ErrorMessage = Load();
        }

        public string Load()
        {
            string errorMessage = "";

            RegistryKey localMachineRegistryKey = Registry.LocalMachine;
            RegistryKey computerPolicyRegistryKey = localMachineRegistryKey.OpenSubKey(PolicySettingsSubKey, false);
            if (computerPolicyRegistryKey != null) // Take settings from Computer policy
            {
                Source = SettingSource.ComputerPolicy;
                errorMessage = GetRegistrySettings(computerPolicyRegistryKey);
                computerPolicyRegistryKey.Close();
                localMachineRegistryKey.Close();
            }
            else
            {
                RegistryKey currentUserRegistryKey = Registry.CurrentUser;
                RegistryKey userPolicyRegistryKey = currentUserRegistryKey.OpenSubKey(PolicySettingsSubKey, false);
                if (userPolicyRegistryKey != null) // Take settings from User policy
                {
                    Source = SettingSource.UserPolicy;
                    errorMessage = GetRegistrySettings(userPolicyRegistryKey);
                    userPolicyRegistryKey.Close();
                }
                else
                {
                    RegistryKey localUserSettings = currentUserRegistryKey.OpenSubKey(LocalSettingsSubKey, true);
                    if (localUserSettings != null) // Take settings from default app location
                    {
                        Source = SettingSource.Local;
                        errorMessage = GetRegistrySettings(localUserSettings);
                        localUserSettings.Close();
                    }
                    else
                    {
                        LoadDefaults();
                        errorMessage = SetRegistrySettings();
                    }
                 }
                currentUserRegistryKey.Close();
            }

            return errorMessage;
        }

        private string GetRegistrySettings(RegistryKey registryKey)
        {
            string errorMessage = "";

            //Read values from registry
            TimerInterval = Convert.ToInt16(registryKey.GetValue("TimerInterval"));
            WarnInterval = Convert.ToInt16(registryKey.GetValue("WarnInterval"));
            WarnThreshold = Convert.ToInt16(registryKey.GetValue("WarnThreshold"));
            AlertInterval = Convert.ToInt16(registryKey.GetValue("AlertInterval"));
            AlertThreshold = Convert.ToInt16(registryKey.GetValue("AlertThreshold"));
            Action = Convert.ToString(registryKey.GetValue("Action"));

            // Check & fix values just in case someone got cute with the registry
            bool fixRequired = false;

            try
            {
                if (TimerInterval < 1) { LoadDefaults(Setting.TimerInterval); fixRequired = true; }
                if (AlertThreshold < 1) { LoadDefaults(Setting.AlertThreshold); fixRequired = true; }
                if (AlertInterval < 1) { LoadDefaults(Setting.AlertInterval); fixRequired = true; }
                if (WarnThreshold < 1) { LoadDefaults(Setting.WarnThreshold); fixRequired = true; }
                if (WarnInterval < 1) { LoadDefaults(Setting.WarnInterval); fixRequired = true; }
            }
            catch (Exception exception)
            {
                errorMessage = exception.Message;
            }

            // Update the registry with fixed values
            // Note: Can only fix local settings. Values pushed by policy will need an AD administrator to address.
            if (errorMessage == "" && fixRequired && Source == SettingSource.Local)
            {
                errorMessage = SetRegistrySettings();
            }

            return errorMessage;
        }

        private string SetRegistrySettings()
        {
            string errorMessage = "";

            try
            {
                RegistryKey currentUserSoftwareKey = Registry.CurrentUser.OpenSubKey("Software", true);
                RegistryKey petKey = currentUserSoftwareKey.OpenSubKey(LocalSettingsSubKey.Substring(9), true);

                if (petKey == null) // Local settings do not exist so create the key
                {
                    petKey = currentUserSoftwareKey.CreateSubKey(LocalSettingsSubKey.Substring(9));
                }

                petKey.SetValue("TimerInterval", TimerInterval.ToString());
                petKey.SetValue("WarnInterval", WarnInterval.ToString());
                petKey.SetValue("WarnThreshold", WarnThreshold.ToString());
                petKey.SetValue("AlertInterval", AlertInterval.ToString());
                petKey.SetValue("AlertThreshold", AlertThreshold.ToString());
                petKey.SetValue("Action", Action);

                petKey.Close();
                currentUserSoftwareKey.Close();
            }
            catch (Exception exception)
            {
                errorMessage = exception.Message;
            }

            return errorMessage;
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
