﻿namespace Cell_Phone_Inventory
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
            this.enterDataGroupBox = new System.Windows.Forms.GroupBox();
            this.addPhoneButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.promptPriceLabel = new System.Windows.Forms.Label();
            this.promptModelLabel = new System.Windows.Forms.Label();
            this.promptBrandLabel = new System.Windows.Forms.Label();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.enterDataGroupBox.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterDataGroupBox
            // 
            this.enterDataGroupBox.Controls.Add(this.addPhoneButton);
            this.enterDataGroupBox.Controls.Add(this.priceTextBox);
            this.enterDataGroupBox.Controls.Add(this.modelTextBox);
            this.enterDataGroupBox.Controls.Add(this.brandTextBox);
            this.enterDataGroupBox.Controls.Add(this.promptPriceLabel);
            this.enterDataGroupBox.Controls.Add(this.promptModelLabel);
            this.enterDataGroupBox.Controls.Add(this.promptBrandLabel);
            this.enterDataGroupBox.Location = new System.Drawing.Point(18, 17);
            this.enterDataGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterDataGroupBox.Name = "enterDataGroupBox";
            this.enterDataGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterDataGroupBox.Size = new System.Drawing.Size(279, 218);
            this.enterDataGroupBox.TabIndex = 5;
            this.enterDataGroupBox.TabStop = false;
            this.enterDataGroupBox.Text = "Enter Cell Phone Data";
            // 
            // addPhoneButton
            // 
            this.addPhoneButton.Location = new System.Drawing.Point(84, 163);
            this.addPhoneButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(112, 35);
            this.addPhoneButton.TabIndex = 7;
            this.addPhoneButton.Text = "Add Phone";
            this.addPhoneButton.UseVisualStyleBackColor = true;
            this.addPhoneButton.Click += new System.EventHandler(this.addPhoneButton_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(93, 114);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(148, 26);
            this.priceTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(93, 74);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(148, 26);
            this.modelTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(93, 34);
            this.brandTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(148, 26);
            this.brandTextBox.TabIndex = 3;
            // 
            // promptPriceLabel
            // 
            this.promptPriceLabel.AutoSize = true;
            this.promptPriceLabel.Location = new System.Drawing.Point(33, 118);
            this.promptPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptPriceLabel.Name = "promptPriceLabel";
            this.promptPriceLabel.Size = new System.Drawing.Size(48, 20);
            this.promptPriceLabel.TabIndex = 2;
            this.promptPriceLabel.Text = "Price:";
            // 
            // promptModelLabel
            // 
            this.promptModelLabel.AutoSize = true;
            this.promptModelLabel.Location = new System.Drawing.Point(26, 80);
            this.promptModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptModelLabel.Name = "promptModelLabel";
            this.promptModelLabel.Size = new System.Drawing.Size(56, 20);
            this.promptModelLabel.TabIndex = 1;
            this.promptModelLabel.Text = "Model:";
            // 
            // promptBrandLabel
            // 
            this.promptBrandLabel.AutoSize = true;
            this.promptBrandLabel.Location = new System.Drawing.Point(27, 38);
            this.promptBrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promptBrandLabel.Name = "promptBrandLabel";
            this.promptBrandLabel.Size = new System.Drawing.Size(56, 20);
            this.promptBrandLabel.TabIndex = 0;
            this.promptBrandLabel.Text = "Brand:";
            // 
            // listGroupBox
            // 
            this.listGroupBox.Controls.Add(this.phoneListBox);
            this.listGroupBox.Location = new System.Drawing.Point(326, 17);
            this.listGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listGroupBox.Size = new System.Drawing.Size(300, 218);
            this.listGroupBox.TabIndex = 8;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "Select a Phone";
            // 
            // phoneListBox
            // 
            this.phoneListBox.FormattingEnabled = true;
            this.phoneListBox.ItemHeight = 20;
            this.phoneListBox.Location = new System.Drawing.Point(32, 31);
            this.phoneListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneListBox.Name = "phoneListBox";
            this.phoneListBox.Size = new System.Drawing.Size(235, 164);
            this.phoneListBox.TabIndex = 8;
            this.phoneListBox.SelectedIndexChanged += new System.EventHandler(this.phoneListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(266, 254);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 35);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 305);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.listGroupBox);
            this.Controls.Add(this.enterDataGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cell Phone Inventory";
            this.enterDataGroupBox.ResumeLayout(false);
            this.enterDataGroupBox.PerformLayout();
            this.listGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enterDataGroupBox;
        private System.Windows.Forms.Button addPhoneButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label promptPriceLabel;
        private System.Windows.Forms.Label promptModelLabel;
        private System.Windows.Forms.Label promptBrandLabel;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.ListBox phoneListBox;
        private System.Windows.Forms.Button exitButton;
    }
}

