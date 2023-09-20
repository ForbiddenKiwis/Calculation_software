using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Messaging;

namespace Project
{
    public partial class IPValidator_Jerwinson_Flores_Cunanan : Form
    {
        private bool isValid = false;
        private bool isValid2 = false;
        FileStream fs = null;
        public IPValidator_Jerwinson_Flores_Cunanan()
        {
            InitializeComponent();
        }

        string dir = @".\Files\";
        string pathBin = @".\Files\IPv4IPv6Bin.txt";

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            IPv4_txt.Clear();
            IPv6_txt.Clear();
        }

        private void Validate_btn_Click(object sender, EventArgs e)
        {
            string ipAddress = IPv4_txt.Text;
            string ipAddress2 = IPv6_txt.Text;

            string pattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            string pattern2 = @"^(?:[0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$";
            isValid = Regex.IsMatch(ipAddress, pattern);

            if (isValid)
            {
                MessageBox.Show(ipAddress + "\nThe IP is correct.", "Valid IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    FileStream fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(ipAddress);
                        bw.Write(DateTime.Now.ToString("yyyy/MM/dd H;mm;ss tt"));
                    bw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                }
                finally { if (fs != null) fs.Close(); }

            }
            else
            {
                MessageBox.Show(ipAddress + "\nThe IP must have 4 bytes" + "\ninteger number between 0 to 255" + "\nseperated by a dot (255.255.255.255)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             isValid2 = Regex.IsMatch(ipAddress2, pattern2);

            if (isValid2)
            {
                MessageBox.Show(ipAddress2 + "\nThe IP is correct.", "Valid IP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    FileStream fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(ipAddress2);
                    bw.Write(
                        DateTime.Now.ToString("yyyy/MM/dd  H;mm;ss tt"));
                    bw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Error");
                }
                finally { if (fs != null) fs.Close(); }

            }
            else
            {
                MessageBox.Show(ipAddress2 + "\nThe IP must have 4 bytes" + "\nHexadecimal between 1 to F" + "\nseperated by a colon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IPValidator_Jerwinson_Flores_Cunanan_Load(object sender, EventArgs e)
        {
            date_lbl.Text = DateTime.Now.ToString("MMMM dd yyyy");
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void display_btn_Click(object sender, EventArgs e)
        {
           // if (isValid || isValid2)
            {
                //string filePath = "YourFilePath.txt";

                try
                {
                    using (FileStream fileStream = new FileStream(pathBin, FileMode.Open, FileAccess.Read))
                    {
                        using (BinaryReader bR = new BinaryReader(fileStream))
                        {
                           // string fileContent = bR.ReadString();
                            string textToPrint = "";
                            while (bR.PeekChar() != -1)
                            {
                                string IPContent = bR.ReadString();
                                //string IPDate = bR.ReadString();
                                textToPrint += IPContent + "\n";// IPDate + "\n";
                                
                                //string title = $"Max,{DateTime.Now.ToString("yyyy/MM/dd     H;mm;ss tt")}, {IPv4_txt.Text}, {IPv6_txt.Text} - ";
                                //string message = $"{fileContent}\n\nIpv4: {IPv4_txt.Text}\nIpv6: {IPv6_txt.Text}";
                                //MessageBox.Show(message, title);
                                
                            }
                            MessageBox.Show(textToPrint);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error");
                }
            }
            //else
            //{
            //    MessageBox.Show("Ip addresses are not validateed yet.", "Validation Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
