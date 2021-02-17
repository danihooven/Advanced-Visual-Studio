namespace FinalProject
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
            this.createObjectsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createObjectsButton
            // 
            this.createObjectsButton.Location = new System.Drawing.Point(28, 25);
            this.createObjectsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createObjectsButton.Name = "createObjectsButton";
            this.createObjectsButton.Size = new System.Drawing.Size(119, 62);
            this.createObjectsButton.TabIndex = 14;
            this.createObjectsButton.Text = "Create Objects";
            this.createObjectsButton.UseVisualStyleBackColor = true;
            this.createObjectsButton.Click += new System.EventHandler(this.createObjectsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(164, 25);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 62);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 111);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectsButton);
            this.Name = "Form1";
            this.Text = "Final Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createObjectsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

