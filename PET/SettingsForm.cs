﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet
{
    public partial class SettingsForm : Form
    {
        private Settings settings = new Settings();

        public SettingsForm()
        {
            InitializeComponent();
            RefreshFormControls();

            if (settings.Source != Settings.SettingSource.Local)
            {
                TimerIntervalNumericUpDown.ReadOnly = true;
                WarnIntervalNumericUpDown.ReadOnly = true;
                WarnThresholdNumericUpDown.ReadOnly = true;
                AlertIntervalNumericUpDown.ReadOnly = true;
                AlertThresholdNumericUpDown.ReadOnly = true;
            }
        }

        private void RefreshFormControls()
        {
            TimerIntervalNumericUpDown.Value = settings.TimerInterval;
            WarnIntervalNumericUpDown.Value = settings.WarnInterval;
            WarnThresholdNumericUpDown.Value = settings.WarnThreshold;
            AlertIntervalNumericUpDown.Value = settings.AlertInterval;
            AlertThresholdNumericUpDown.Value = settings.AlertThreshold;
            ActionTextBox.Text = settings.Action;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            settings.TimerInterval = (int)TimerIntervalNumericUpDown.Value;
            settings.WarnInterval = (int)WarnIntervalNumericUpDown.Value;
            settings.WarnThreshold = (int)WarnThresholdNumericUpDown.Value;
            settings.AlertInterval = (int)AlertIntervalNumericUpDown.Value;
            settings.AlertThreshold = (int)AlertThresholdNumericUpDown.Value;
            settings.Action = ActionTextBox.Text;

            settings.Save();
            if (String.IsNullOrEmpty(settings.ErrorMessage))
            {
                MessageBox.Show("Settings saved!");
            }
            else
            {
                MessageBox.Show(settings.ErrorMessage);
                settings.ClearErrorMessage();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadDefaultsButton_Click(object sender, EventArgs e)
        {
            settings.LoadDefaults();
            RefreshFormControls();
        }
    }
}
