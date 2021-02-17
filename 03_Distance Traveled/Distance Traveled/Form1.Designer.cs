namespace Distance_Traveled
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
            this.speedPromptLabel = new System.Windows.Forms.Label();
            this.outputDistance5Label = new System.Windows.Forms.Label();
            this.speedTextBox = new System.Windows.Forms.TextBox();
            this.outputDistance8Label = new System.Windows.Forms.Label();
            this.outputDistance12Label = new System.Windows.Forms.Label();
            this.distance5Label = new System.Windows.Forms.Label();
            this.distance8Label = new System.Windows.Forms.Label();
            this.distance12Label = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speedPromptLabel
            // 
            this.speedPromptLabel.AutoSize = true;
            this.speedPromptLabel.Location = new System.Drawing.Point(29, 24);
            this.speedPromptLabel.Name = "speedPromptLabel";
            this.speedPromptLabel.Size = new System.Drawing.Size(283, 20);
            this.speedPromptLabel.TabIndex = 0;
            this.speedPromptLabel.Text = "Enter the car\'s speed in miles per hour.";
            // 
            // outputDistance5Label
            // 
            this.outputDistance5Label.AutoSize = true;
            this.outputDistance5Label.Location = new System.Drawing.Point(29, 87);
            this.outputDistance5Label.Name = "outputDistance5Label";
            this.outputDistance5Label.Size = new System.Drawing.Size(292, 20);
            this.outputDistance5Label.TabIndex = 1;
            this.outputDistance5Label.Text = "The distance the car will travel in 5 hours";
            // 
            // speedTextBox
            // 
            this.speedTextBox.Location = new System.Drawing.Point(318, 21);
            this.speedTextBox.Name = "speedTextBox";
            this.speedTextBox.Size = new System.Drawing.Size(124, 26);
            this.speedTextBox.TabIndex = 2;
            // 
            // outputDistance8Label
            // 
            this.outputDistance8Label.AutoSize = true;
            this.outputDistance8Label.Location = new System.Drawing.Point(29, 134);
            this.outputDistance8Label.Name = "outputDistance8Label";
            this.outputDistance8Label.Size = new System.Drawing.Size(292, 20);
            this.outputDistance8Label.TabIndex = 3;
            this.outputDistance8Label.Text = "The distance the car will travel in 8 hours";
            // 
            // outputDistance12Label
            // 
            this.outputDistance12Label.AutoSize = true;
            this.outputDistance12Label.Location = new System.Drawing.Point(20, 178);
            this.outputDistance12Label.Name = "outputDistance12Label";
            this.outputDistance12Label.Size = new System.Drawing.Size(301, 20);
            this.outputDistance12Label.TabIndex = 4;
            this.outputDistance12Label.Text = "The distance the car will travel in 12 hours";
            // 
            // distance5Label
            // 
            this.distance5Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distance5Label.Location = new System.Drawing.Point(327, 82);
            this.distance5Label.Name = "distance5Label";
            this.distance5Label.Size = new System.Drawing.Size(115, 31);
            this.distance5Label.TabIndex = 5;
            this.distance5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distance8Label
            // 
            this.distance8Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distance8Label.Location = new System.Drawing.Point(327, 129);
            this.distance8Label.Name = "distance8Label";
            this.distance8Label.Size = new System.Drawing.Size(115, 31);
            this.distance8Label.TabIndex = 6;
            this.distance8Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // distance12Label
            // 
            this.distance12Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distance12Label.Location = new System.Drawing.Point(327, 173);
            this.distance12Label.Name = "distance12Label";
            this.distance12Label.Size = new System.Drawing.Size(115, 31);
            this.distance12Label.TabIndex = 7;
            this.distance12Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(61, 248);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 71);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Distance";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(199, 248);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 71);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(338, 248);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(104, 71);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 382);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.distance12Label);
            this.Controls.Add(this.distance8Label);
            this.Controls.Add(this.distance5Label);
            this.Controls.Add(this.outputDistance12Label);
            this.Controls.Add(this.outputDistance8Label);
            this.Controls.Add(this.speedTextBox);
            this.Controls.Add(this.outputDistance5Label);
            this.Controls.Add(this.speedPromptLabel);
            this.Name = "Form1";
            this.Text = "Distance Traveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedPromptLabel;
        private System.Windows.Forms.Label outputDistance5Label;
        private System.Windows.Forms.TextBox speedTextBox;
        private System.Windows.Forms.Label outputDistance8Label;
        private System.Windows.Forms.Label outputDistance12Label;
        private System.Windows.Forms.Label distance5Label;
        private System.Windows.Forms.Label distance8Label;
        private System.Windows.Forms.Label distance12Label;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

