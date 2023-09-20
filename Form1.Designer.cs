namespace Project
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.IPButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculatorBtn = new System.Windows.Forms.Button();
            this.MoneyBtn = new System.Windows.Forms.Button();
            this.TempBtn = new System.Windows.Forms.Button();
            this.SixFourNineBtn = new System.Windows.Forms.Button();
            this.LottoMaxBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 245);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.IPButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(390, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IP v4 & v6 validator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP validator";
            // 
            // IPButton
            // 
            this.IPButton.Image = global::Project.Properties.Resources.ip4;
            this.IPButton.Location = new System.Drawing.Point(115, 6);
            this.IPButton.Name = "IPButton";
            this.IPButton.Size = new System.Drawing.Size(150, 164);
            this.IPButton.TabIndex = 2;
            this.IPButton.UseVisualStyleBackColor = true;
            this.IPButton.Click += new System.EventHandler(this.IPButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.CalculatorBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(390, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simple Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simple Calculator";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(390, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conventions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MoneyBtn);
            this.groupBox1.Controls.Add(this.TempBtn);
            this.groupBox1.Location = new System.Drawing.Point(27, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conventions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperature Convert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Money Exchange";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(390, 219);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Generated Numbers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SixFourNineBtn);
            this.groupBox2.Controls.Add(this.LottoMaxBtn);
            this.groupBox2.Location = new System.Drawing.Point(24, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 179);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lotto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lotto 649";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lotto Max";
            // 
            // CalculatorBtn
            // 
            this.CalculatorBtn.Image = global::Project.Properties.Resources.Calculator;
            this.CalculatorBtn.Location = new System.Drawing.Point(137, 25);
            this.CalculatorBtn.Name = "CalculatorBtn";
            this.CalculatorBtn.Size = new System.Drawing.Size(119, 142);
            this.CalculatorBtn.TabIndex = 2;
            this.CalculatorBtn.UseVisualStyleBackColor = true;
            this.CalculatorBtn.Click += new System.EventHandler(this.CalculatorBtn_Click);
            // 
            // MoneyBtn
            // 
            this.MoneyBtn.Image = global::Project.Properties.Resources.moneyConvert;
            this.MoneyBtn.Location = new System.Drawing.Point(6, 19);
            this.MoneyBtn.Name = "MoneyBtn";
            this.MoneyBtn.Size = new System.Drawing.Size(118, 125);
            this.MoneyBtn.TabIndex = 4;
            this.MoneyBtn.UseVisualStyleBackColor = true;
            this.MoneyBtn.Click += new System.EventHandler(this.MoneyBtn_Click);
            // 
            // TempBtn
            // 
            this.TempBtn.Image = global::Project.Properties.Resources.tempConvert;
            this.TempBtn.Location = new System.Drawing.Point(218, 19);
            this.TempBtn.Name = "TempBtn";
            this.TempBtn.Size = new System.Drawing.Size(118, 125);
            this.TempBtn.TabIndex = 5;
            this.TempBtn.UseVisualStyleBackColor = true;
            this.TempBtn.Click += new System.EventHandler(this.TempBtn_Click);
            // 
            // SixFourNineBtn
            // 
            this.SixFourNineBtn.Image = global::Project.Properties.Resources.Lotto649;
            this.SixFourNineBtn.Location = new System.Drawing.Point(205, 19);
            this.SixFourNineBtn.Name = "SixFourNineBtn";
            this.SixFourNineBtn.Size = new System.Drawing.Size(124, 135);
            this.SixFourNineBtn.TabIndex = 4;
            this.SixFourNineBtn.UseVisualStyleBackColor = true;
            this.SixFourNineBtn.Click += new System.EventHandler(this.SixFourNineBtn_Click);
            // 
            // LottoMaxBtn
            // 
            this.LottoMaxBtn.Image = global::Project.Properties.Resources.LottoMax;
            this.LottoMaxBtn.Location = new System.Drawing.Point(20, 19);
            this.LottoMaxBtn.Name = "LottoMaxBtn";
            this.LottoMaxBtn.Size = new System.Drawing.Size(124, 135);
            this.LottoMaxBtn.TabIndex = 5;
            this.LottoMaxBtn.UseVisualStyleBackColor = true;
            this.LottoMaxBtn.Click += new System.EventHandler(this.LottoMaxBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 292);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Dashboard + Jerwinson-Flores Cunanan";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button IPButton;
        private System.Windows.Forms.Button CalculatorBtn;
        private System.Windows.Forms.Button TempBtn;
        private System.Windows.Forms.Button MoneyBtn;
        private System.Windows.Forms.Button LottoMaxBtn;
        private System.Windows.Forms.Button SixFourNineBtn;
    }
}

