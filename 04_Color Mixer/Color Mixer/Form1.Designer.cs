namespace Color_Mixer
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
            this.colorGroupBox1 = new System.Windows.Forms.GroupBox();
            this.yellowRadioButton1 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton1 = new System.Windows.Forms.RadioButton();
            this.redRadioButton1 = new System.Windows.Forms.RadioButton();
            this.colorGroupBox2 = new System.Windows.Forms.GroupBox();
            this.yellowRadioButton2 = new System.Windows.Forms.RadioButton();
            this.blueRadioButton2 = new System.Windows.Forms.RadioButton();
            this.redRadioButton2 = new System.Windows.Forms.RadioButton();
            this.mixButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorGroupBox1.SuspendLayout();
            this.colorGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox1
            // 
            this.colorGroupBox1.Controls.Add(this.yellowRadioButton1);
            this.colorGroupBox1.Controls.Add(this.blueRadioButton1);
            this.colorGroupBox1.Controls.Add(this.redRadioButton1);
            this.colorGroupBox1.Location = new System.Drawing.Point(23, 12);
            this.colorGroupBox1.Name = "colorGroupBox1";
            this.colorGroupBox1.Size = new System.Drawing.Size(199, 175);
            this.colorGroupBox1.TabIndex = 0;
            this.colorGroupBox1.TabStop = false;
            this.colorGroupBox1.Text = "Select the First Color";
            // 
            // yellowRadioButton1
            // 
            this.yellowRadioButton1.AutoSize = true;
            this.yellowRadioButton1.Location = new System.Drawing.Point(28, 99);
            this.yellowRadioButton1.Name = "yellowRadioButton1";
            this.yellowRadioButton1.Size = new System.Drawing.Size(80, 24);
            this.yellowRadioButton1.TabIndex = 2;
            this.yellowRadioButton1.TabStop = true;
            this.yellowRadioButton1.Text = "Yellow";
            this.yellowRadioButton1.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton1
            // 
            this.blueRadioButton1.AutoSize = true;
            this.blueRadioButton1.Location = new System.Drawing.Point(28, 69);
            this.blueRadioButton1.Name = "blueRadioButton1";
            this.blueRadioButton1.Size = new System.Drawing.Size(66, 24);
            this.blueRadioButton1.TabIndex = 2;
            this.blueRadioButton1.TabStop = true;
            this.blueRadioButton1.Text = "Blue";
            this.blueRadioButton1.UseVisualStyleBackColor = true;
            // 
            // redRadioButton1
            // 
            this.redRadioButton1.AutoSize = true;
            this.redRadioButton1.Location = new System.Drawing.Point(28, 39);
            this.redRadioButton1.Name = "redRadioButton1";
            this.redRadioButton1.Size = new System.Drawing.Size(64, 24);
            this.redRadioButton1.TabIndex = 1;
            this.redRadioButton1.TabStop = true;
            this.redRadioButton1.Text = "Red";
            this.redRadioButton1.UseVisualStyleBackColor = true;
            // 
            // colorGroupBox2
            // 
            this.colorGroupBox2.Controls.Add(this.yellowRadioButton2);
            this.colorGroupBox2.Controls.Add(this.blueRadioButton2);
            this.colorGroupBox2.Controls.Add(this.redRadioButton2);
            this.colorGroupBox2.Location = new System.Drawing.Point(241, 12);
            this.colorGroupBox2.Name = "colorGroupBox2";
            this.colorGroupBox2.Size = new System.Drawing.Size(199, 175);
            this.colorGroupBox2.TabIndex = 3;
            this.colorGroupBox2.TabStop = false;
            this.colorGroupBox2.Text = "Select the Second Color";
            // 
            // yellowRadioButton2
            // 
            this.yellowRadioButton2.AutoSize = true;
            this.yellowRadioButton2.Location = new System.Drawing.Point(28, 99);
            this.yellowRadioButton2.Name = "yellowRadioButton2";
            this.yellowRadioButton2.Size = new System.Drawing.Size(80, 24);
            this.yellowRadioButton2.TabIndex = 2;
            this.yellowRadioButton2.TabStop = true;
            this.yellowRadioButton2.Text = "Yellow";
            this.yellowRadioButton2.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton2
            // 
            this.blueRadioButton2.AutoSize = true;
            this.blueRadioButton2.Location = new System.Drawing.Point(28, 69);
            this.blueRadioButton2.Name = "blueRadioButton2";
            this.blueRadioButton2.Size = new System.Drawing.Size(66, 24);
            this.blueRadioButton2.TabIndex = 2;
            this.blueRadioButton2.TabStop = true;
            this.blueRadioButton2.Text = "Blue";
            this.blueRadioButton2.UseVisualStyleBackColor = true;
            // 
            // redRadioButton2
            // 
            this.redRadioButton2.AutoSize = true;
            this.redRadioButton2.Location = new System.Drawing.Point(28, 39);
            this.redRadioButton2.Name = "redRadioButton2";
            this.redRadioButton2.Size = new System.Drawing.Size(64, 24);
            this.redRadioButton2.TabIndex = 1;
            this.redRadioButton2.TabStop = true;
            this.redRadioButton2.Text = "Red";
            this.redRadioButton2.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(127, 207);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(95, 44);
            this.mixButton.TabIndex = 4;
            this.mixButton.Text = "Mix";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(241, 207);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 44);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 294);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.colorGroupBox2);
            this.Controls.Add(this.colorGroupBox1);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.colorGroupBox1.ResumeLayout(false);
            this.colorGroupBox1.PerformLayout();
            this.colorGroupBox2.ResumeLayout(false);
            this.colorGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox1;
        private System.Windows.Forms.RadioButton yellowRadioButton1;
        private System.Windows.Forms.RadioButton blueRadioButton1;
        private System.Windows.Forms.RadioButton redRadioButton1;
        private System.Windows.Forms.GroupBox colorGroupBox2;
        private System.Windows.Forms.RadioButton yellowRadioButton2;
        private System.Windows.Forms.RadioButton blueRadioButton2;
        private System.Windows.Forms.RadioButton redRadioButton2;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Button exitButton;
    }
}

