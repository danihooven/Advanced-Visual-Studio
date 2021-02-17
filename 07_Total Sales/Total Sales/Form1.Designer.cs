namespace Total_Sales
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.getSalesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.totalSalesDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 20;
            this.outputListBox.Location = new System.Drawing.Point(41, 29);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(369, 184);
            this.outputListBox.TabIndex = 0;
            // 
            // getSalesButton
            // 
            this.getSalesButton.Location = new System.Drawing.Point(108, 284);
            this.getSalesButton.Name = "getSalesButton";
            this.getSalesButton.Size = new System.Drawing.Size(113, 51);
            this.getSalesButton.TabIndex = 1;
            this.getSalesButton.Text = "Get Sales";
            this.getSalesButton.UseVisualStyleBackColor = true;
            this.getSalesButton.Click += new System.EventHandler(this.getSalesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(240, 284);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 51);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSalesLabel.Location = new System.Drawing.Point(271, 222);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(139, 39);
            this.totalSalesLabel.TabIndex = 3;
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // totalSalesDescription
            // 
            this.totalSalesDescription.AutoSize = true;
            this.totalSalesDescription.Location = new System.Drawing.Point(173, 232);
            this.totalSalesDescription.Name = "totalSalesDescription";
            this.totalSalesDescription.Size = new System.Drawing.Size(92, 20);
            this.totalSalesDescription.TabIndex = 4;
            this.totalSalesDescription.Text = "Total Sales:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 362);
            this.Controls.Add(this.totalSalesDescription);
            this.Controls.Add(this.totalSalesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getSalesButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "Total Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button getSalesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label totalSalesDescription;
    }
}

