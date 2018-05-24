namespace PET
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimerIntervalLabel = new System.Windows.Forms.Label();
            this.TimerIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimerIntervalHoursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimerIntervalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerIntervalLabel
            // 
            this.TimerIntervalLabel.AutoSize = true;
            this.TimerIntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerIntervalLabel.Location = new System.Drawing.Point(12, 29);
            this.TimerIntervalLabel.Name = "TimerIntervalLabel";
            this.TimerIntervalLabel.Size = new System.Drawing.Size(123, 20);
            this.TimerIntervalLabel.TabIndex = 0;
            this.TimerIntervalLabel.Text = "Timer Interval:";
            // 
            // TimerIntervalNumericUpDown
            // 
            this.TimerIntervalNumericUpDown.Location = new System.Drawing.Point(141, 27);
            this.TimerIntervalNumericUpDown.Name = "TimerIntervalNumericUpDown";
            this.TimerIntervalNumericUpDown.Size = new System.Drawing.Size(90, 26);
            this.TimerIntervalNumericUpDown.TabIndex = 1;
            // 
            // TimerIntervalHoursLabel
            // 
            this.TimerIntervalHoursLabel.AutoSize = true;
            this.TimerIntervalHoursLabel.Location = new System.Drawing.Point(232, 29);
            this.TimerIntervalHoursLabel.Name = "TimerIntervalHoursLabel";
            this.TimerIntervalHoursLabel.Size = new System.Drawing.Size(49, 20);
            this.TimerIntervalHoursLabel.TabIndex = 2;
            this.TimerIntervalHoursLabel.Text = "hours";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 324);
            this.Controls.Add(this.TimerIntervalHoursLabel);
            this.Controls.Add(this.TimerIntervalNumericUpDown);
            this.Controls.Add(this.TimerIntervalLabel);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.TimerIntervalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerIntervalLabel;
        private System.Windows.Forms.NumericUpDown TimerIntervalNumericUpDown;
        private System.Windows.Forms.Label TimerIntervalHoursLabel;
    }
}