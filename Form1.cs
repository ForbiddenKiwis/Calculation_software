using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
// Jerwinson-Flores Cunanan
// Project 
// 2023-07-10
namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
        private void IPButton_Click(object sender, EventArgs e)
        {
            IPValidator_Jerwinson_Flores_Cunanan newForm = new IPValidator_Jerwinson_Flores_Cunanan();
            newForm.Show();
        }
        private void CalculatorBtn_Click(object sender, EventArgs e)
        {
            Simple_Cal newForm = new Simple_Cal();
            newForm.Show();
        }

        private void MoneyBtn_Click(object sender, EventArgs e)
        {
            MoneyExchange_Jerwinson_Flores_Cunanan newForm = new MoneyExchange_Jerwinson_Flores_Cunanan();
            newForm.Show();
        }

        private void TempBtn_Click(object sender, EventArgs e)
        {
            Temp newForm = new Temp();
            newForm.Show();
        }

        private void SixFourNineBtn_Click(object sender, EventArgs e)
        {
            Lotto649_Jerwinson_Flores_Cunanan newForm = new Lotto649_Jerwinson_Flores_Cunanan();
            newForm.Show();
        }

        private void LottoMaxBtn_Click(object sender, EventArgs e)
        {
            LottoMax newForm = new LottoMax();
            newForm.Show();
        }
    }
}
