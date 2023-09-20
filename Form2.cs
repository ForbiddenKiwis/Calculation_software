using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Simple_Cal : Form
    {
        private double previousResult = 0;
        public Simple_Cal()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Clear();
            res_txt.Clear();
            input = "";
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "1";
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "2";
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "3";
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "4";
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "5";
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "6";
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "7";
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "8";
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "9";
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "0";
        }

        private void decimal_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += ".";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "+";
        }

        private void sus_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "-";
        }

        private void mul_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "*";
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            arithmatic_txt.Text += "/";
        }
        string input = "";
        private void equals_btn_Click(object sender, EventArgs e)
        {
            input = arithmatic_txt.Text;

            if (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/") || input.Contains(input))
            {
                try
                {
                    DataTable dataTable = new DataTable();
                    object result = dataTable.Compute(input, "");

                    if (input != "")
                    {
                        res_txt.Text = result.ToString();
                        arithmatic_txt.Text = input + " = " + result.ToString();

                        //string message = $"Previous Result: {res_txt.Text}\nNew Result: {result}\n\nDo you want to perform a new operation with the currunt result or compare it with another operation?";
                        //string title = "Confirm Action";
                        //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        //DialogResult dialogResult = MessageBox.Show(message, title, buttons);

                        //if (dialogResult == DialogResult.Yes)
                        //{
                        //    previousResult = Convert.ToDouble(result);
                        //    res_txt.Text = String.Empty;
                        //    arithmatic_txt.Text = result.ToString();
                        //}
                        //else
                        //{
                        //    res_txt.Text= result.ToString();
                        //    arithmatic_txt.Text = input + " = " + result.ToString();
                        //}

                        
                    }
                    else
                    {
                        MessageBox.Show("No aritmetic operation found in the input.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured during evaluation: " + ex.Message);
                }     
            }
            else
            {
                MessageBox.Show("No aritmetic operation found in the input.");
            }
        }
    }
}
