namespace Project
{
    partial class IPValidator_Jerwinson_Flores_Cunanan
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
            this.exit_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.Validate_btn = new System.Windows.Forms.Button();
            this.display_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPv4_txt = new System.Windows.Forms.TextBox();
            this.IPv6_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(245, 187);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 0;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(144, 180);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 1;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // Validate_btn
            // 
            this.Validate_btn.Location = new System.Drawing.Point(47, 187);
            this.Validate_btn.Name = "Validate_btn";
            this.Validate_btn.Size = new System.Drawing.Size(75, 23);
            this.Validate_btn.TabIndex = 2;
            this.Validate_btn.Text = "Validate IP";
            this.Validate_btn.UseVisualStyleBackColor = true;
            this.Validate_btn.Click += new System.EventHandler(this.Validate_btn_Click);
            // 
            // display_btn
            // 
            this.display_btn.Location = new System.Drawing.Point(125, 209);
            this.display_btn.Name = "display_btn";
            this.display_btn.Size = new System.Drawing.Size(114, 23);
            this.display_btn.TabIndex = 3;
            this.display_btn.Text = "Read and display";
            this.display_btn.UseVisualStyleBackColor = true;
            this.display_btn.Click += new System.EventHandler(this.display_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter IP v4 Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter IP v6 Address:";
            // 
            // IPv4_txt
            // 
            this.IPv4_txt.Location = new System.Drawing.Point(154, 44);
            this.IPv4_txt.Name = "IPv4_txt";
            this.IPv4_txt.Size = new System.Drawing.Size(166, 20);
            this.IPv4_txt.TabIndex = 6;
            // 
            // IPv6_txt
            // 
            this.IPv6_txt.Location = new System.Drawing.Point(154, 70);
            this.IPv6_txt.Name = "IPv6_txt";
            this.IPv6_txt.Size = new System.Drawing.Size(166, 20);
            this.IPv6_txt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Today:";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(168, 9);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(28, 13);
            this.date_lbl.TabIndex = 9;
            this.date_lbl.Text = "date";
            // 
            // IPValidator_Jerwinson_Flores_Cunanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 241);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IPv6_txt);
            this.Controls.Add(this.IPv4_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display_btn);
            this.Controls.Add(this.Validate_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.exit_btn);
            this.Name = "IPValidator_Jerwinson_Flores_Cunanan";
            this.Text = "IPValidator_Jerwinson_Flores_Cunanan";
            this.Load += new System.EventHandler(this.IPValidator_Jerwinson_Flores_Cunanan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button Validate_btn;
        private System.Windows.Forms.Button display_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IPv4_txt;
        private System.Windows.Forms.TextBox IPv6_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date_lbl;
    }
}