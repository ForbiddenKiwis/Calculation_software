namespace Project
{
    partial class LottoMax
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
            this.Display_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.generator_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RandomNum_txt = new System.Windows.Forms.RichTextBox();
            this.sevendigit_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Display_btn
            // 
            this.Display_btn.Location = new System.Drawing.Point(12, 220);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(101, 58);
            this.Display_btn.TabIndex = 1;
            this.Display_btn.Text = "&Read and \r\nDisplay the \r\nText File";
            this.Display_btn.UseVisualStyleBackColor = true;
            this.Display_btn.Click += new System.EventHandler(this.Display_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(350, 255);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(75, 23);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "E&xit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // generator_btn
            // 
            this.generator_btn.Location = new System.Drawing.Point(218, 53);
            this.generator_btn.Name = "generator_btn";
            this.generator_btn.Size = new System.Drawing.Size(132, 53);
            this.generator_btn.TabIndex = 3;
            this.generator_btn.Text = "Generate 7 +1 out of 50 unique numbers and 7 digits for extra";
            this.generator_btn.UseVisualStyleBackColor = true;
            this.generator_btn.Click += new System.EventHandler(this.generator_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "The generated numbers are:";
            // 
            // RandomNum_txt
            // 
            this.RandomNum_txt.Location = new System.Drawing.Point(387, 10);
            this.RandomNum_txt.Name = "RandomNum_txt";
            this.RandomNum_txt.ReadOnly = true;
            this.RandomNum_txt.Size = new System.Drawing.Size(38, 192);
            this.RandomNum_txt.TabIndex = 6;
            this.RandomNum_txt.Text = "";
            // 
            // sevendigit_txt
            // 
            this.sevendigit_txt.Location = new System.Drawing.Point(193, 124);
            this.sevendigit_txt.Name = "sevendigit_txt";
            this.sevendigit_txt.ReadOnly = true;
            this.sevendigit_txt.Size = new System.Drawing.Size(100, 20);
            this.sevendigit_txt.TabIndex = 7;
            this.sevendigit_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.MaxExtra;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LottoMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 290);
            this.Controls.Add(this.sevendigit_txt);
            this.Controls.Add(this.RandomNum_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generator_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Display_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LottoMax";
            this.Text = "LottoMax Jerwinson-Flores Cunanan";
            this.Load += new System.EventHandler(this.LottoMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Display_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button generator_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RandomNum_txt;
        private System.Windows.Forms.TextBox sevendigit_txt;
    }
}