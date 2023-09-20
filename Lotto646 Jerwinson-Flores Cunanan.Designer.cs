namespace Project
{
    partial class Lotto649_Jerwinson_Flores_Cunanan
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
            this.randomNum_txt = new System.Windows.Forms.RichTextBox();
            this.sevenDigit_txt = new System.Windows.Forms.TextBox();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.generator_btn = new System.Windows.Forms.Button();
            this.Display_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // randomNum_txt
            // 
            this.randomNum_txt.Location = new System.Drawing.Point(380, 12);
            this.randomNum_txt.Name = "randomNum_txt";
            this.randomNum_txt.ReadOnly = true;
            this.randomNum_txt.Size = new System.Drawing.Size(37, 192);
            this.randomNum_txt.TabIndex = 1;
            this.randomNum_txt.Text = "";
            // 
            // sevenDigit_txt
            // 
            this.sevenDigit_txt.Location = new System.Drawing.Point(184, 114);
            this.sevenDigit_txt.Name = "sevenDigit_txt";
            this.sevenDigit_txt.ReadOnly = true;
            this.sevenDigit_txt.Size = new System.Drawing.Size(100, 20);
            this.sevenDigit_txt.TabIndex = 2;
            this.sevenDigit_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(342, 273);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "E&xit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // generator_btn
            // 
            this.generator_btn.Location = new System.Drawing.Point(208, 40);
            this.generator_btn.Name = "generator_btn";
            this.generator_btn.Size = new System.Drawing.Size(132, 53);
            this.generator_btn.TabIndex = 4;
            this.generator_btn.Text = "Generate 6 +1 out of 50 unique numbers and 7 digits for extra";
            this.generator_btn.UseVisualStyleBackColor = true;
            this.generator_btn.Click += new System.EventHandler(this.generator_btn_Click);
            // 
            // Display_btn
            // 
            this.Display_btn.Location = new System.Drawing.Point(12, 238);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(101, 58);
            this.Display_btn.TabIndex = 5;
            this.Display_btn.Text = "&Read and \r\nDisplay the \r\nText File";
            this.Display_btn.UseVisualStyleBackColor = true;
            this.Display_btn.Click += new System.EventHandler(this.Display_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "The generated numbers are:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources._649Extra;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lotto649_Jerwinson_Flores_Cunanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Display_btn);
            this.Controls.Add(this.generator_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.sevenDigit_txt);
            this.Controls.Add(this.randomNum_txt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Lotto649_Jerwinson_Flores_Cunanan";
            this.Text = "Lotto649_Jerwinson_Flores_Cunanan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox randomNum_txt;
        private System.Windows.Forms.TextBox sevenDigit_txt;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button generator_btn;
        private System.Windows.Forms.Button Display_btn;
        private System.Windows.Forms.Label label1;
    }
}