namespace Retail_Price_Calculator
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
            this.wholesaleCostPromptLabel = new System.Windows.Forms.Label();
            this.markupPercentagePromptLabel = new System.Windows.Forms.Label();
            this.retailPricePromptLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.wholesaleCostTextbox = new System.Windows.Forms.TextBox();
            this.markupPercentageTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wholesaleCostPromptLabel
            // 
            this.wholesaleCostPromptLabel.AutoSize = true;
            this.wholesaleCostPromptLabel.Location = new System.Drawing.Point(51, 25);
            this.wholesaleCostPromptLabel.Name = "wholesaleCostPromptLabel";
            this.wholesaleCostPromptLabel.Size = new System.Drawing.Size(124, 20);
            this.wholesaleCostPromptLabel.TabIndex = 0;
            this.wholesaleCostPromptLabel.Text = "Wholesale Cost:";
            // 
            // markupPercentagePromptLabel
            // 
            this.markupPercentagePromptLabel.AutoSize = true;
            this.markupPercentagePromptLabel.Location = new System.Drawing.Point(23, 80);
            this.markupPercentagePromptLabel.Name = "markupPercentagePromptLabel";
            this.markupPercentagePromptLabel.Size = new System.Drawing.Size(152, 20);
            this.markupPercentagePromptLabel.TabIndex = 1;
            this.markupPercentagePromptLabel.Text = "Markup Percentage:";
            // 
            // retailPricePromptLabel
            // 
            this.retailPricePromptLabel.AutoSize = true;
            this.retailPricePromptLabel.Location = new System.Drawing.Point(82, 155);
            this.retailPricePromptLabel.Name = "retailPricePromptLabel";
            this.retailPricePromptLabel.Size = new System.Drawing.Size(93, 20);
            this.retailPricePromptLabel.TabIndex = 2;
            this.retailPricePromptLabel.Text = "Retail Price:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(57, 232);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 58);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(206, 232);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 58);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // wholesaleCostTextbox
            // 
            this.wholesaleCostTextbox.Location = new System.Drawing.Point(181, 22);
            this.wholesaleCostTextbox.Name = "wholesaleCostTextbox";
            this.wholesaleCostTextbox.Size = new System.Drawing.Size(144, 26);
            this.wholesaleCostTextbox.TabIndex = 5;
            // 
            // markupPercentageTextBox
            // 
            this.markupPercentageTextBox.Location = new System.Drawing.Point(181, 77);
            this.markupPercentageTextBox.Name = "markupPercentageTextBox";
            this.markupPercentageTextBox.Size = new System.Drawing.Size(144, 26);
            this.markupPercentageTextBox.TabIndex = 6;
            // 
            // priceLabel
            // 
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Location = new System.Drawing.Point(181, 150);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(144, 30);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 319);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.markupPercentageTextBox);
            this.Controls.Add(this.wholesaleCostTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.retailPricePromptLabel);
            this.Controls.Add(this.markupPercentagePromptLabel);
            this.Controls.Add(this.wholesaleCostPromptLabel);
            this.Name = "Form1";
            this.Text = "Retail Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wholesaleCostPromptLabel;
        private System.Windows.Forms.Label markupPercentagePromptLabel;
        private System.Windows.Forms.Label retailPricePromptLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox wholesaleCostTextbox;
        private System.Windows.Forms.TextBox markupPercentageTextBox;
        private System.Windows.Forms.Label priceLabel;
    }
}

