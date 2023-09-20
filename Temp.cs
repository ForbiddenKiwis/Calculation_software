using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace Project
{
    public partial class Temp : Form
    {
        FileStream fs = null;
        string dir = @".\Files\";
        string pathBin = @".\Files\TempConversion.txt";
        public Temp()
        {
            InitializeComponent();
        }

        private void CtoF_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (CtoF_btn.Checked)
            {
                temp1_lbl.Text = "C";
                temp2_lbl.Text = "F";
            }
            UpdateTextBoxColor();
        }

        private void FtoC_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (FtoC_btn.Checked)
            {
                temp1_lbl.Text = "F";
                temp2_lbl.Text = "C";
            }
            UpdateTextBoxColor();
        }

        private void temp1_txt_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxColor();

            string inputText = temp1_txt.Text;
            string decimalOnly = Regex.Replace(inputText, @"[^0-9.-]", "");

            decimalOnly = RemoveExtraDecimalPoints(decimalOnly);
            decimalOnly = LimitDecimalPlaces(decimalOnly, 2);

            temp1_txt.Text = decimalOnly;
            temp1_txt.SelectionStart = decimalOnly.Length;
        }

        private void UpdateTextBoxColor()
        {
            if (CtoF_btn.Checked)
            {
                //temp1_txt.Clear();
                //temp2_txt.Clear();

                if (double.TryParse(temp1_txt.Text, out double value))
                {
                    if (value >= 100)
                    {
                        temp1_txt.ForeColor = Color.Red;
                    }
                    else if (value <= 0)
                    {
                        temp1_txt.ForeColor = Color.Blue;
                    }
                    else
                    {
                        // Reset to default color if none of the conditions match
                        temp1_txt.ForeColor = SystemColors.ControlText;
                    }
                }
                else
                {
                    temp1_txt.ForeColor = SystemColors.ControlText;
                }
            }

            if (FtoC_btn.Checked)
            {
                if (double.TryParse(temp1_txt.Text, out double value))
                {
                    if (value >= 212)
                    {
                        temp1_txt.ForeColor = Color.Red;
                    }
                    else if (value <= 32)
                    {
                        temp1_txt.ForeColor = Color.Blue;
                    }
                    else
                    {
                        temp1_txt.ForeColor = SystemColors.ControlText;
                    }
                }
                else
                {
                    temp1_txt.ForeColor = SystemColors.ControlText;
                }
            }
        }

        private string RemoveExtraDecimalPoints(string input)
        {
            int decimalPointCount = input.Count(c => c == '.');

            if (decimalPointCount > 1)
            {
                int firstDecimalIndex = input.IndexOf('.');
                input = input.Remove(firstDecimalIndex + 1).Replace(".", "");
            }

            return input;
        }

        private string LimitDecimalPlaces(string input, int decimalPlaces)
        {
            int decimalPointIndex = input.IndexOf('.');
            if (decimalPointIndex != -1 && input.Length - decimalPointIndex - 1 > decimalPlaces)
            {
                input = input.Substring(0, decimalPointIndex + decimalPlaces + 1);
            }

            return input;
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            if (CtoF_btn.Checked)
            {
                if (double.TryParse(temp1_txt.Text, out double celsius))
                {
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    temp2_txt.Text = fahrenheit.ToString("0.##");

                    string tempMsg = GetTemperatureMessage(celsius, fahrenheit);
                    msg_txt.Text = tempMsg;

                    try
                    {
                        FileStream fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(Convert.ToString(temp1_txt.Text) + " C = ");
                        bw.Write(Convert.ToString(temp2_txt.Text) + "F,\t");
                        bw.Write(DateTime.Now.ToString("yyyy/MM/dd H:mm:ss tt"));
                        bw.Write(msg_txt.Text);

                        bw.Close();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Celsius temperature. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (FtoC_btn.Checked)
            {
                if (double.TryParse(temp1_txt.Text, out double fahrenheit))
                {
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    temp2_txt.Text = celsius.ToString("0.##");

                    string tempMsg = GetTemperatureMessage(celsius, fahrenheit);
                    msg_txt.Text = tempMsg;
                    try
                    {
                        FileStream fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(Convert.ToString(fahrenheit) + " F = ");
                        bw.Write(Convert.ToString(celsius) + "C,\t");
                        bw.Write(DateTime.Now.ToString("yyyy/MM/dd H:mm:ss tt"));
                        bw.Write(msg_txt.Text);

                        bw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Fahrenheit temperature. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetTemperatureMessage(double celsius, double fahrenheit)
        {
            if ((celsius <= 100 && celsius >= 41) || (fahrenheit <= 212 && fahrenheit >= 105))
            {
                return "Water Boils";
            }
            else if ((celsius <= 40 && celsius >= 38) || (fahrenheit <= 104 && fahrenheit >= 98.7))
            {
                return "Hot Bath";
            }
            else if ((celsius <= 37 && celsius >= 31) || (fahrenheit <= 98.6 && fahrenheit >= 87))
            {
                return "Body Temperature";
            }
            else if ((celsius <= 30 && celsius >= 22) || (fahrenheit <= 86 && fahrenheit >= 71))
            {
                return "Beach Weather";
            }
            else if ((celsius <= 21 && celsius >= 11) || (fahrenheit <= 70 && fahrenheit >= 49))
            {
                return "Room Temperature";
            }
            else if ((celsius <= 10 && celsius >= 9) || (fahrenheit <= 50 && fahrenheit >= 31))
            {
                return "Cool Day";
            }
            else if ((celsius <= 0 && celsius >= -17) || (fahrenheit <= 32 && fahrenheit >= 1))
            {
                return "Freezing point of Water";
            }
            else if ((celsius <= -18 && celsius >= -39) || (fahrenheit <= 0 && fahrenheit >= -39))
            {
                return "Very Cold Day";
            }
            else if (celsius <= -40 || fahrenheit <= -40)
            {
                return "Extremely Cold Day";
            }

            // If none of the conditions match, return an empty string or an appropriate default message.
            return "";
        }


        private void read_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fileStream = new FileStream(pathBin, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader bR = new BinaryReader(fileStream))
                    {
                        string textToPrint = "";
                        while (bR.PeekChar() != -1)
                        {
                            string tempContent1 = bR.ReadString();
                            string tempContent2 = bR.ReadString();
                            string tempContent3 = bR.ReadString();
                            string tempContent4 = bR.ReadString();
                            textToPrint += tempContent1 + tempContent2 + tempContent4 + "\n";
                        }
                        MessageBox.Show(textToPrint,"Results + Jerwinson-Flores CUNANAN");
                    }
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void Temp_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
