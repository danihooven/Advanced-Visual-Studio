namespace Distance_Calculator
{
    partial class Form1
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
            this.vehicleSpeedPromptLabel = new System.Windows.Forms.Label();
            this.hoursTraveledPromptLabel = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicleSpeedPromptLabel
            // 
            this.vehicleSpeedPromptLabel.AutoSize = true;
            this.vehicleSpeedPromptLabel.Location = new System.Drawing.Point(50, 22);
            this.vehicleSpeedPromptLabel.Name = "vehicleSpeedPromptLabel";
            this.vehicleSpeedPromptLabel.Size = new System.Drawing.Size(171, 20);
            this.vehicleSpeedPromptLabel.TabIndex = 0;
            this.vehicleSpeedPromptLabel.Text = "Vehicle Speed in MPH:";
            // 
            // hoursTraveledPromptLabel
            // 
            this.hoursTraveledPromptLabel.AutoSize = true;
            this.hoursTraveledPromptLabel.Location = new System.Drawing.Point(101, 64);
            this.hoursTraveledPromptLabel.Name = "hoursTraveledPromptLabel";
            this.hoursTraveledPromptLabel.Size = new System.Drawing.Size(120, 20);
            this.hoursTraveledPromptLabel.TabIndex = 1;
            this.hoursTraveledPromptLabel.Text = "Hours Traveled:";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(227, 19);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(141, 26);
            this.speedTextBox.TabIndex = 2;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(227, 61);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(141, 26);
            this.hoursTextBox.TabIndex = 3;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 20;
            this.outputListBox.Location = new System.Drawing.Point(54, 109);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(314, 164);
            this.outputListBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(105, 293);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(94, 38);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(227, 293);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 355);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.hoursTraveledPromptLabel);
            this.Controls.Add(this.vehicleSpeedPromptLabel);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vehicleSpeedPromptLabel;
        private System.Windows.Forms.Label hoursTraveledPromptLabel;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

