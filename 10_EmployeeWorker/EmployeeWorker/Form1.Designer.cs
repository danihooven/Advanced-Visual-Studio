namespace EmployeeWorker
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
            this.empNameDescriptionLabel = new System.Windows.Forms.Label();
            this.empIdDescriptionLabel = new System.Windows.Forms.Label();
            this.shiftNumDescriptionLabel = new System.Windows.Forms.Label();
            this.hourlyPayDescriptionLabel = new System.Windows.Forms.Label();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.empIdTextBox = new System.Windows.Forms.TextBox();
            this.shiftNumTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // empNameDescriptionLabel
            // 
            this.empNameDescriptionLabel.AutoSize = true;
            this.empNameDescriptionLabel.Location = new System.Drawing.Point(12, 18);
            this.empNameDescriptionLabel.Name = "empNameDescriptionLabel";
            this.empNameDescriptionLabel.Size = new System.Drawing.Size(125, 20);
            this.empNameDescriptionLabel.TabIndex = 0;
            this.empNameDescriptionLabel.Text = "Employee Name";
            // 
            // empIdDescriptionLabel
            // 
            this.empIdDescriptionLabel.AutoSize = true;
            this.empIdDescriptionLabel.Location = new System.Drawing.Point(12, 61);
            this.empIdDescriptionLabel.Name = "empIdDescriptionLabel";
            this.empIdDescriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.empIdDescriptionLabel.TabIndex = 1;
            this.empIdDescriptionLabel.Text = "Employee ID";
            // 
            // shiftNumDescriptionLabel
            // 
            this.shiftNumDescriptionLabel.AutoSize = true;
            this.shiftNumDescriptionLabel.Location = new System.Drawing.Point(12, 103);
            this.shiftNumDescriptionLabel.Name = "shiftNumDescriptionLabel";
            this.shiftNumDescriptionLabel.Size = new System.Drawing.Size(102, 20);
            this.shiftNumDescriptionLabel.TabIndex = 2;
            this.shiftNumDescriptionLabel.Text = "Shift Number";
            // 
            // hourlyPayDescriptionLabel
            // 
            this.hourlyPayDescriptionLabel.AutoSize = true;
            this.hourlyPayDescriptionLabel.Location = new System.Drawing.Point(12, 146);
            this.hourlyPayDescriptionLabel.Name = "hourlyPayDescriptionLabel";
            this.hourlyPayDescriptionLabel.Size = new System.Drawing.Size(84, 20);
            this.hourlyPayDescriptionLabel.TabIndex = 3;
            this.hourlyPayDescriptionLabel.Text = "Hourly Pay";
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.Location = new System.Drawing.Point(157, 15);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.Size = new System.Drawing.Size(208, 26);
            this.empNameTextBox.TabIndex = 4;
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.Location = new System.Drawing.Point(157, 58);
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.Size = new System.Drawing.Size(208, 26);
            this.empIdTextBox.TabIndex = 5;
            // 
            // shiftNumTextBox
            // 
            this.shiftNumTextBox.Location = new System.Drawing.Point(157, 100);
            this.shiftNumTextBox.Name = "shiftNumTextBox";
            this.shiftNumTextBox.Size = new System.Drawing.Size(208, 26);
            this.shiftNumTextBox.TabIndex = 6;
            // 
            // hourlyPayTextBox
            // 
            this.hourlyPayTextBox.Location = new System.Drawing.Point(157, 143);
            this.hourlyPayTextBox.Name = "hourlyPayTextBox";
            this.hourlyPayTextBox.Size = new System.Drawing.Size(208, 26);
            this.hourlyPayTextBox.TabIndex = 7;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(262, 199);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(103, 38);
            this.displayButton.TabIndex = 8;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(16, 266);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(349, 126);
            this.outputTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 411);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.hourlyPayTextBox);
            this.Controls.Add(this.shiftNumTextBox);
            this.Controls.Add(this.empIdTextBox);
            this.Controls.Add(this.empNameTextBox);
            this.Controls.Add(this.hourlyPayDescriptionLabel);
            this.Controls.Add(this.shiftNumDescriptionLabel);
            this.Controls.Add(this.empIdDescriptionLabel);
            this.Controls.Add(this.empNameDescriptionLabel);
            this.Name = "Form1";
            this.Text = "EmployeeWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empNameDescriptionLabel;
        private System.Windows.Forms.Label empIdDescriptionLabel;
        private System.Windows.Forms.Label shiftNumDescriptionLabel;
        private System.Windows.Forms.Label hourlyPayDescriptionLabel;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.TextBox empIdTextBox;
        private System.Windows.Forms.TextBox shiftNumTextBox;
        private System.Windows.Forms.TextBox hourlyPayTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

