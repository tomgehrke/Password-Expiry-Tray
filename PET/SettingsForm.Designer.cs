namespace Pet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.TimerIntervalLabel = new System.Windows.Forms.Label();
            this.TimerIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimerIntervalHoursLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WarnIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WarnThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AlertThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AlertIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ActionTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LoadDefaultsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimerIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarnIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarnThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertIntervalNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerIntervalLabel
            // 
            this.TimerIntervalLabel.AutoSize = true;
            this.TimerIntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerIntervalLabel.Location = new System.Drawing.Point(12, 29);
            this.TimerIntervalLabel.Name = "TimerIntervalLabel";
            this.TimerIntervalLabel.Size = new System.Drawing.Size(116, 20);
            this.TimerIntervalLabel.TabIndex = 0;
            this.TimerIntervalLabel.Text = "Timer interval";
            // 
            // TimerIntervalNumericUpDown
            // 
            this.TimerIntervalNumericUpDown.Location = new System.Drawing.Point(15, 52);
            this.TimerIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimerIntervalNumericUpDown.Name = "TimerIntervalNumericUpDown";
            this.TimerIntervalNumericUpDown.Size = new System.Drawing.Size(90, 26);
            this.TimerIntervalNumericUpDown.TabIndex = 1;
            this.TimerIntervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TimerIntervalHoursLabel
            // 
            this.TimerIntervalHoursLabel.AutoSize = true;
            this.TimerIntervalHoursLabel.Location = new System.Drawing.Point(111, 54);
            this.TimerIntervalHoursLabel.Name = "TimerIntervalHoursLabel";
            this.TimerIntervalHoursLabel.Size = new System.Drawing.Size(49, 20);
            this.TimerIntervalHoursLabel.TabIndex = 2;
            this.TimerIntervalHoursLabel.Text = "hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "hours";
            // 
            // WarnIntervalNumericUpDown
            // 
            this.WarnIntervalNumericUpDown.Location = new System.Drawing.Point(15, 141);
            this.WarnIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WarnIntervalNumericUpDown.Name = "WarnIntervalNumericUpDown";
            this.WarnIntervalNumericUpDown.Size = new System.Drawing.Size(90, 26);
            this.WarnIntervalNumericUpDown.TabIndex = 4;
            this.WarnIntervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Warning interval";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "days";
            // 
            // WarnThresholdNumericUpDown
            // 
            this.WarnThresholdNumericUpDown.Location = new System.Drawing.Point(204, 141);
            this.WarnThresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WarnThresholdNumericUpDown.Name = "WarnThresholdNumericUpDown";
            this.WarnThresholdNumericUpDown.Size = new System.Drawing.Size(90, 26);
            this.WarnThresholdNumericUpDown.TabIndex = 7;
            this.WarnThresholdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Warning threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "days";
            // 
            // AlertThresholdNumericUpDown
            // 
            this.AlertThresholdNumericUpDown.Location = new System.Drawing.Point(204, 224);
            this.AlertThresholdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AlertThresholdNumericUpDown.Name = "AlertThresholdNumericUpDown";
            this.AlertThresholdNumericUpDown.Size = new System.Drawing.Size(90, 26);
            this.AlertThresholdNumericUpDown.TabIndex = 13;
            this.AlertThresholdNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alert threshold";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "hours";
            // 
            // AlertIntervalNumericUpDown
            // 
            this.AlertIntervalNumericUpDown.Location = new System.Drawing.Point(15, 222);
            this.AlertIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AlertIntervalNumericUpDown.Name = "AlertIntervalNumericUpDown";
            this.AlertIntervalNumericUpDown.Size = new System.Drawing.Size(90, 26);
            this.AlertIntervalNumericUpDown.TabIndex = 10;
            this.AlertIntervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Alert interval";
            // 
            // ActionTextBox
            // 
            this.ActionTextBox.Location = new System.Drawing.Point(15, 292);
            this.ActionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActionTextBox.Name = "ActionTextBox";
            this.ActionTextBox.Size = new System.Drawing.Size(328, 26);
            this.ActionTextBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Change password action";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(235, 361);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 32);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(114, 361);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 32);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoadDefaultsButton
            // 
            this.LoadDefaultsButton.Location = new System.Drawing.Point(204, 42);
            this.LoadDefaultsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadDefaultsButton.Name = "LoadDefaultsButton";
            this.LoadDefaultsButton.Size = new System.Drawing.Size(133, 32);
            this.LoadDefaultsButton.TabIndex = 20;
            this.LoadDefaultsButton.Text = "Load Defaults";
            this.LoadDefaultsButton.UseVisualStyleBackColor = true;
            this.LoadDefaultsButton.Click += new System.EventHandler(this.LoadDefaultsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 429);
            this.Controls.Add(this.LoadDefaultsButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ActionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AlertThresholdNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AlertIntervalNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WarnThresholdNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WarnIntervalNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimerIntervalHoursLabel);
            this.Controls.Add(this.TimerIntervalNumericUpDown);
            this.Controls.Add(this.TimerIntervalLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PET Settings";
            ((System.ComponentModel.ISupportInitialize)(this.TimerIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarnIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarnThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlertIntervalNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerIntervalLabel;
        private System.Windows.Forms.NumericUpDown TimerIntervalNumericUpDown;
        private System.Windows.Forms.Label TimerIntervalHoursLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown WarnIntervalNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WarnThresholdNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AlertThresholdNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown AlertIntervalNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ActionTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button LoadDefaultsButton;
    }
}