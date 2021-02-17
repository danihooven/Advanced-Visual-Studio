namespace Cars
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
            this.carDataGroupBox = new System.Windows.Forms.GroupBox();
            this.createCarButton = new System.Windows.Forms.Button();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.makeDescription = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearDescription = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.driveCarGroupBox = new System.Windows.Forms.GroupBox();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.speedDescription = new System.Windows.Forms.Label();
            this.brakeButton = new System.Windows.Forms.Button();
            this.speedLabel = new System.Windows.Forms.Label();
            this.carDataGroupBox.SuspendLayout();
            this.carPropertiesGroupBox.SuspendLayout();
            this.driveCarGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // carDataGroupBox
            // 
            this.carDataGroupBox.Controls.Add(this.createCarButton);
            this.carDataGroupBox.Controls.Add(this.makeTextBox);
            this.carDataGroupBox.Controls.Add(this.yearTextBox);
            this.carDataGroupBox.Controls.Add(this.label2);
            this.carDataGroupBox.Controls.Add(this.label5);
            this.carDataGroupBox.Location = new System.Drawing.Point(12, 18);
            this.carDataGroupBox.Name = "carDataGroupBox";
            this.carDataGroupBox.Size = new System.Drawing.Size(257, 180);
            this.carDataGroupBox.TabIndex = 0;
            this.carDataGroupBox.TabStop = false;
            this.carDataGroupBox.Text = "Enter Car Data";
            // 
            // createCarButton
            // 
            this.createCarButton.Location = new System.Drawing.Point(72, 118);
            this.createCarButton.Name = "createCarButton";
            this.createCarButton.Size = new System.Drawing.Size(117, 39);
            this.createCarButton.TabIndex = 1;
            this.createCarButton.Text = "Create Car";
            this.createCarButton.UseVisualStyleBackColor = true;
            this.createCarButton.Click += new System.EventHandler(this.createCarButton_Click);
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(102, 70);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(100, 26);
            this.makeTextBox.TabIndex = 19;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(102, 38);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 26);
            this.yearTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Make";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Year";
            // 
            // carPropertiesGroupBox
            // 
            this.carPropertiesGroupBox.Controls.Add(this.makeDescription);
            this.carPropertiesGroupBox.Controls.Add(this.yearLabel);
            this.carPropertiesGroupBox.Controls.Add(this.makeLabel);
            this.carPropertiesGroupBox.Controls.Add(this.yearDescription);
            this.carPropertiesGroupBox.Location = new System.Drawing.Point(12, 216);
            this.carPropertiesGroupBox.Name = "carPropertiesGroupBox";
            this.carPropertiesGroupBox.Size = new System.Drawing.Size(257, 125);
            this.carPropertiesGroupBox.TabIndex = 5;
            this.carPropertiesGroupBox.TabStop = false;
            this.carPropertiesGroupBox.Text = "Car Properties";
            // 
            // makeDescription
            // 
            this.makeDescription.AutoSize = true;
            this.makeDescription.Location = new System.Drawing.Point(48, 73);
            this.makeDescription.Name = "makeDescription";
            this.makeDescription.Size = new System.Drawing.Size(48, 20);
            this.makeDescription.TabIndex = 11;
            this.makeDescription.Text = "Make";
            // 
            // yearLabel
            // 
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yearLabel.Location = new System.Drawing.Point(102, 40);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(100, 23);
            this.yearLabel.TabIndex = 7;
            // 
            // makeLabel
            // 
            this.makeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.makeLabel.Location = new System.Drawing.Point(102, 72);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(100, 23);
            this.makeLabel.TabIndex = 6;
            // 
            // yearDescription
            // 
            this.yearDescription.AutoSize = true;
            this.yearDescription.Location = new System.Drawing.Point(53, 41);
            this.yearDescription.Name = "yearDescription";
            this.yearDescription.Size = new System.Drawing.Size(43, 20);
            this.yearDescription.TabIndex = 9;
            this.yearDescription.Text = "Year";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(84, 545);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 39);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // driveCarGroupBox
            // 
            this.driveCarGroupBox.Controls.Add(this.accelerateButton);
            this.driveCarGroupBox.Controls.Add(this.speedDescription);
            this.driveCarGroupBox.Controls.Add(this.brakeButton);
            this.driveCarGroupBox.Controls.Add(this.speedLabel);
            this.driveCarGroupBox.Location = new System.Drawing.Point(12, 357);
            this.driveCarGroupBox.Name = "driveCarGroupBox";
            this.driveCarGroupBox.Size = new System.Drawing.Size(257, 168);
            this.driveCarGroupBox.TabIndex = 21;
            this.driveCarGroupBox.TabStop = false;
            this.driveCarGroupBox.Text = "Drive Car";
            // 
            // accelerateButton
            // 
            this.accelerateButton.Location = new System.Drawing.Point(134, 102);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(104, 37);
            this.accelerateButton.TabIndex = 9;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // speedDescription
            // 
            this.speedDescription.AutoSize = true;
            this.speedDescription.Location = new System.Drawing.Point(40, 42);
            this.speedDescription.Name = "speedDescription";
            this.speedDescription.Size = new System.Drawing.Size(56, 20);
            this.speedDescription.TabIndex = 10;
            this.speedDescription.Text = "Speed";
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(20, 102);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(104, 37);
            this.brakeButton.TabIndex = 8;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // speedLabel
            // 
            this.speedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speedLabel.Location = new System.Drawing.Point(98, 41);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(100, 23);
            this.speedLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 598);
            this.Controls.Add(this.driveCarGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.carPropertiesGroupBox);
            this.Controls.Add(this.carDataGroupBox);
            this.Name = "Form1";
            this.Text = "Car Test";
            this.carDataGroupBox.ResumeLayout(false);
            this.carDataGroupBox.PerformLayout();
            this.carPropertiesGroupBox.ResumeLayout(false);
            this.carPropertiesGroupBox.PerformLayout();
            this.driveCarGroupBox.ResumeLayout(false);
            this.driveCarGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox carDataGroupBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox carPropertiesGroupBox;
        private System.Windows.Forms.Label makeDescription;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label yearDescription;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createCarButton;
        private System.Windows.Forms.GroupBox driveCarGroupBox;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Label speedDescription;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Label speedLabel;
    }
}

