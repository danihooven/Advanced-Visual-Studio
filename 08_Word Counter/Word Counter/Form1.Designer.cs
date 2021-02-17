namespace Word_Counter
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
            this.stringTextBox = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stringTextBox
            // 
            this.stringTextBox.AllowDrop = true;
            this.stringTextBox.Location = new System.Drawing.Point(50, 35);
            this.stringTextBox.Multiline = true;
            this.stringTextBox.Name = "stringTextBox";
            this.stringTextBox.Size = new System.Drawing.Size(334, 127);
            this.stringTextBox.TabIndex = 0;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(90, 198);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(120, 68);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Word Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(232, 198);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 68);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.stringTextBox);
            this.Name = "Form1";
            this.Text = "Word Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringTextBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button exitButton;
    }
}

