namespace Clickable_Images
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
            this.twoPictureBox = new System.Windows.Forms.PictureBox();
            this.onePictureBox = new System.Windows.Forms.PictureBox();
            this.threePictureBox = new System.Windows.Forms.PictureBox();
            this.fourPictureBox = new System.Windows.Forms.PictureBox();
            this.fivePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.twoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // twoPictureBox
            // 
            this.twoPictureBox.Image = global::Clickable_Images.Properties.Resources.Two;
            this.twoPictureBox.Location = new System.Drawing.Point(164, 65);
            this.twoPictureBox.Name = "twoPictureBox";
            this.twoPictureBox.Size = new System.Drawing.Size(80, 144);
            this.twoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twoPictureBox.TabIndex = 1;
            this.twoPictureBox.TabStop = false;
            this.twoPictureBox.Click += new System.EventHandler(this.twoPictureBox_Click);
            // 
            // onePictureBox
            // 
            this.onePictureBox.Image = global::Clickable_Images.Properties.Resources.One;
            this.onePictureBox.Location = new System.Drawing.Point(31, 65);
            this.onePictureBox.Name = "onePictureBox";
            this.onePictureBox.Size = new System.Drawing.Size(80, 144);
            this.onePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.onePictureBox.TabIndex = 0;
            this.onePictureBox.TabStop = false;
            this.onePictureBox.Click += new System.EventHandler(this.onePictureBox_Click);
            // 
            // threePictureBox
            // 
            this.threePictureBox.Image = global::Clickable_Images.Properties.Resources.Three;
            this.threePictureBox.Location = new System.Drawing.Point(290, 65);
            this.threePictureBox.Name = "threePictureBox";
            this.threePictureBox.Size = new System.Drawing.Size(80, 144);
            this.threePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.threePictureBox.TabIndex = 2;
            this.threePictureBox.TabStop = false;
            this.threePictureBox.Click += new System.EventHandler(this.threePictureBox_Click);
            // 
            // fourPictureBox
            // 
            this.fourPictureBox.Image = global::Clickable_Images.Properties.Resources.Four;
            this.fourPictureBox.Location = new System.Drawing.Point(419, 65);
            this.fourPictureBox.Name = "fourPictureBox";
            this.fourPictureBox.Size = new System.Drawing.Size(80, 144);
            this.fourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fourPictureBox.TabIndex = 3;
            this.fourPictureBox.TabStop = false;
            this.fourPictureBox.Click += new System.EventHandler(this.fourPictureBox_Click);
            // 
            // fivePictureBox
            // 
            this.fivePictureBox.Image = global::Clickable_Images.Properties.Resources.Five;
            this.fivePictureBox.Location = new System.Drawing.Point(546, 65);
            this.fivePictureBox.Name = "fivePictureBox";
            this.fivePictureBox.Size = new System.Drawing.Size(80, 144);
            this.fivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fivePictureBox.TabIndex = 4;
            this.fivePictureBox.TabStop = false;
            this.fivePictureBox.Click += new System.EventHandler(this.fivePictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 342);
            this.Controls.Add(this.fivePictureBox);
            this.Controls.Add(this.fourPictureBox);
            this.Controls.Add(this.threePictureBox);
            this.Controls.Add(this.twoPictureBox);
            this.Controls.Add(this.onePictureBox);
            this.Name = "Form1";
            this.Text = "Clickable Images";
            ((System.ComponentModel.ISupportInitialize)(this.twoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fivePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox onePictureBox;
        private System.Windows.Forms.PictureBox twoPictureBox;
        private System.Windows.Forms.PictureBox threePictureBox;
        private System.Windows.Forms.PictureBox fourPictureBox;
        private System.Windows.Forms.PictureBox fivePictureBox;
    }
}

