namespace Food_Facts
{
    partial class NutritionForm
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
            this.foodDescription = new System.Windows.Forms.Label();
            this.caloriesDescription = new System.Windows.Forms.Label();
            this.fatDescription = new System.Windows.Forms.Label();
            this.carbDescription = new System.Windows.Forms.Label();
            this.carbLabel = new System.Windows.Forms.Label();
            this.fatLabel = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodDescription
            // 
            this.foodDescription.AutoSize = true;
            this.foodDescription.Location = new System.Drawing.Point(82, 23);
            this.foodDescription.Name = "foodDescription";
            this.foodDescription.Size = new System.Drawing.Size(46, 20);
            this.foodDescription.TabIndex = 0;
            this.foodDescription.Text = "Food";
            // 
            // caloriesDescription
            // 
            this.caloriesDescription.AutoSize = true;
            this.caloriesDescription.Location = new System.Drawing.Point(62, 56);
            this.caloriesDescription.Name = "caloriesDescription";
            this.caloriesDescription.Size = new System.Drawing.Size(66, 20);
            this.caloriesDescription.TabIndex = 1;
            this.caloriesDescription.Text = "Calories";
            // 
            // fatDescription
            // 
            this.fatDescription.AutoSize = true;
            this.fatDescription.Location = new System.Drawing.Point(43, 92);
            this.fatDescription.Name = "fatDescription";
            this.fatDescription.Size = new System.Drawing.Size(85, 20);
            this.fatDescription.TabIndex = 2;
            this.fatDescription.Text = "Fat Grams";
            // 
            // carbDescription
            // 
            this.carbDescription.AutoSize = true;
            this.carbDescription.Location = new System.Drawing.Point(33, 128);
            this.carbDescription.Name = "carbDescription";
            this.carbDescription.Size = new System.Drawing.Size(95, 20);
            this.carbDescription.TabIndex = 3;
            this.carbDescription.Text = "Carb Grams";
            // 
            // carbLabel
            // 
            this.carbLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carbLabel.Location = new System.Drawing.Point(134, 127);
            this.carbLabel.Name = "carbLabel";
            this.carbLabel.Size = new System.Drawing.Size(100, 23);
            this.carbLabel.TabIndex = 4;
            // 
            // fatLabel
            // 
            this.fatLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fatLabel.Location = new System.Drawing.Point(134, 91);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(100, 23);
            this.fatLabel.TabIndex = 5;
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caloriesLabel.Location = new System.Drawing.Point(134, 55);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(100, 23);
            this.caloriesLabel.TabIndex = 6;
            // 
            // foodLabel
            // 
            this.foodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foodLabel.Location = new System.Drawing.Point(134, 22);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(100, 23);
            this.foodLabel.TabIndex = 7;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(86, 179);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 43);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NutritionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbLabel);
            this.Controls.Add(this.carbDescription);
            this.Controls.Add(this.fatDescription);
            this.Controls.Add(this.caloriesDescription);
            this.Controls.Add(this.foodDescription);
            this.Name = "NutritionForm";
            this.Text = "NutritionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodDescription;
        private System.Windows.Forms.Label caloriesDescription;
        private System.Windows.Forms.Label fatDescription;
        private System.Windows.Forms.Label carbDescription;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label carbLabel;
        public System.Windows.Forms.Label fatLabel;
        public System.Windows.Forms.Label caloriesLabel;
        public System.Windows.Forms.Label foodLabel;
    }
}