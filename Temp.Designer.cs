namespace Project
{
    partial class Temp
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
            this.CtoF_btn = new System.Windows.Forms.RadioButton();
            this.FtoC_btn = new System.Windows.Forms.RadioButton();
            this.temp1_txt = new System.Windows.Forms.TextBox();
            this.temp2_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.temp1_lbl = new System.Windows.Forms.Label();
            this.temp2_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msg_txt = new System.Windows.Forms.RichTextBox();
            this.convert_btn = new System.Windows.Forms.Button();
            this.read_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CtoF_btn
            // 
            this.CtoF_btn.AutoSize = true;
            this.CtoF_btn.Location = new System.Drawing.Point(170, 64);
            this.CtoF_btn.Name = "CtoF_btn";
            this.CtoF_btn.Size = new System.Drawing.Size(76, 17);
            this.CtoF_btn.TabIndex = 0;
            this.CtoF_btn.TabStop = true;
            this.CtoF_btn.Text = "from C to F";
            this.CtoF_btn.UseVisualStyleBackColor = true;
            this.CtoF_btn.CheckedChanged += new System.EventHandler(this.CtoF_btn_CheckedChanged);
            // 
            // FtoC_btn
            // 
            this.FtoC_btn.AutoSize = true;
            this.FtoC_btn.Location = new System.Drawing.Point(170, 87);
            this.FtoC_btn.Name = "FtoC_btn";
            this.FtoC_btn.Size = new System.Drawing.Size(76, 17);
            this.FtoC_btn.TabIndex = 1;
            this.FtoC_btn.TabStop = true;
            this.FtoC_btn.Text = "from F to C";
            this.FtoC_btn.UseVisualStyleBackColor = true;
            this.FtoC_btn.CheckedChanged += new System.EventHandler(this.FtoC_btn_CheckedChanged);
            // 
            // temp1_txt
            // 
            this.temp1_txt.Location = new System.Drawing.Point(12, 196);
            this.temp1_txt.Name = "temp1_txt";
            this.temp1_txt.Size = new System.Drawing.Size(162, 20);
            this.temp1_txt.TabIndex = 2;
            this.temp1_txt.TextChanged += new System.EventHandler(this.temp1_txt_TextChanged);
            // 
            // temp2_txt
            // 
            this.temp2_txt.Location = new System.Drawing.Point(256, 196);
            this.temp2_txt.Name = "temp2_txt";
            this.temp2_txt.ReadOnly = true;
            this.temp2_txt.Size = new System.Drawing.Size(162, 20);
            this.temp2_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "to";
            // 
            // temp1_lbl
            // 
            this.temp1_lbl.AutoSize = true;
            this.temp1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp1_lbl.Location = new System.Drawing.Point(81, 219);
            this.temp1_lbl.Name = "temp1_lbl";
            this.temp1_lbl.Size = new System.Drawing.Size(28, 25);
            this.temp1_lbl.TabIndex = 5;
            this.temp1_lbl.Text = "C\r\n";
            // 
            // temp2_lbl
            // 
            this.temp2_lbl.AutoSize = true;
            this.temp2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp2_lbl.Location = new System.Drawing.Point(330, 219);
            this.temp2_lbl.Name = "temp2_lbl";
            this.temp2_lbl.Size = new System.Drawing.Size(25, 25);
            this.temp2_lbl.TabIndex = 6;
            this.temp2_lbl.Text = "F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Message :";
            // 
            // msg_txt
            // 
            this.msg_txt.BackColor = System.Drawing.SystemColors.Control;
            this.msg_txt.Location = new System.Drawing.Point(12, 286);
            this.msg_txt.Name = "msg_txt";
            this.msg_txt.ReadOnly = true;
            this.msg_txt.Size = new System.Drawing.Size(406, 96);
            this.msg_txt.TabIndex = 8;
            this.msg_txt.Text = "";
            // 
            // convert_btn
            // 
            this.convert_btn.Location = new System.Drawing.Point(12, 415);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(133, 23);
            this.convert_btn.TabIndex = 9;
            this.convert_btn.Text = "&Convert";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // read_btn
            // 
            this.read_btn.Location = new System.Drawing.Point(151, 415);
            this.read_btn.Name = "read_btn";
            this.read_btn.Size = new System.Drawing.Size(128, 23);
            this.read_btn.TabIndex = 10;
            this.read_btn.Text = "&Read File";
            this.read_btn.UseVisualStyleBackColor = true;
            this.read_btn.Click += new System.EventHandler(this.read_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(285, 415);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(133, 23);
            this.exit_btn.TabIndex = 11;
            this.exit_btn.Text = "E&xit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.read_btn);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.msg_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.temp2_lbl);
            this.Controls.Add(this.temp1_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temp2_txt);
            this.Controls.Add(this.temp1_txt);
            this.Controls.Add(this.FtoC_btn);
            this.Controls.Add(this.CtoF_btn);
            this.Name = "Temp";
            this.Text = "Temperature + Jerwinson-Flores Cunanan";
            this.Load += new System.EventHandler(this.Temp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CtoF_btn;
        private System.Windows.Forms.RadioButton FtoC_btn;
        private System.Windows.Forms.TextBox temp1_txt;
        private System.Windows.Forms.TextBox temp2_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temp1_lbl;
        private System.Windows.Forms.Label temp2_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox msg_txt;
        private System.Windows.Forms.Button convert_btn;
        private System.Windows.Forms.Button read_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}