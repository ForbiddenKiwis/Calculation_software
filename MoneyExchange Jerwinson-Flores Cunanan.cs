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


namespace Project
{
    public partial class MoneyExchange_Jerwinson_Flores_Cunanan : Form
    {
        private Timer timerInactivity;

        FileStream fs = null;
        string dir = @".\Files\";
        string pathBin = @".\Files\MoneyConversion.txt";

        public MoneyExchange_Jerwinson_Flores_Cunanan()
        {
            InitializeComponent();

            timerInactivity = new Timer();
            timerInactivity.Interval = 150000;
            timerInactivity.Tick += TimerInactivity_Tick;

            this.MouseMove += ResetInactivityTimer;
            this.KeyDown += ResetInactivityTimer;
            this.FormClosed += MoneyExchange_Jerwinson_Flores_Cunanan_FormClosed;
        }

        private void TimerInactivity_Tick(object sender, EventArgs e)
        {
            timerInactivity.Stop();

            DialogResult result = MessageBox.Show("Do you want to quit this app? you have been here 2 minutes and 30 sec", "Inactivity Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                timerInactivity.Start();
            }
        }

        private void ResetInactivityTimer(object sender, EventArgs e)
        {
            timerInactivity.Stop();
            timerInactivity.Start();
        }
        private void MoneyExchange_Jerwinson_Flores_Cunanan_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerInactivity.Stop();
        }
        private void CADCurruncy_btn_CheckedChanged(object sender, EventArgs e)
        {
            ResetAllInput(this);
        }
        private void USDCurruncy_btn_CheckedChanged(object sender, EventArgs e)
        {
            ResetAllInput(this);
        }

        private void EURCurruncy_btn_CheckedChanged(object sender, EventArgs e)
        {
            ResetAllInput(this);
        }

        private void GBPCurruncy_btn_CheckedChanged(object sender, EventArgs e)
        {
            ResetAllInput(this);
        }

        private void PhilippinePesos_btn_CheckedChanged(object sender, EventArgs e)
        {
            ResetAllInput(this);
        }
        private void ResetAllInput(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextBox textbox)
                {
                    textbox.Text = string.Empty;
                }
                else if (childControl.HasChildren)
                {
                    ResetAllInput(childControl);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void Convert_btn_Click(object sender, EventArgs e)
        {
            double amount;

            if (double.TryParse(Curruncy1_txt.Text, out amount))
            {
                double cadAmount = 0;
                double usdAmount = 0;
                double eurAmount = 0;
                double gbpAmount = 0;
                double phpAmount = 0;
                double yenAmount = 0;

                if (USDCurruncy_btn.Checked)
                {
                    cadAmount = amount * 1.33;
                    usdAmount = amount;
                    eurAmount = amount * 0.91;
                    gbpAmount = amount * 0.78;
                    phpAmount = amount * 55.38;
                    yenAmount = amount * 140.74;

                    CAD_txt.Clear();
                    USD_txt.Clear();
                    EUR_txt.Clear();
                    GBP_txt.Clear();
                    PHP_txt.Clear();
                    YEN_txt.Clear();
                }
                else if (CADCurruncy_btn.Checked)
                {
                    cadAmount = amount;
                    usdAmount = amount * .75;
                    eurAmount = amount * 0.68;
                    gbpAmount = amount * 0.59;
                    phpAmount = amount * 41.78;
                    yenAmount = amount * 106.15;

                    CAD_txt.Clear();
                    USD_txt.Clear();
                    EUR_txt.Clear();
                    GBP_txt.Clear();
                    PHP_txt.Clear();
                    YEN_txt.Clear();
                }
                else if (EURCurruncy_btn.Checked)
                {
                    cadAmount = amount * 1.46;
                    usdAmount = amount * 1.1;
                    eurAmount = amount;
                    gbpAmount = amount * 0.86;
                    phpAmount = amount * 61.02;
                    yenAmount = amount * 155.01;

                    CAD_txt.Clear();
                    USD_txt.Clear();
                    EUR_txt.Clear();
                    GBP_txt.Clear();
                    PHP_txt.Clear();
                    YEN_txt.Clear();
                }
                else if (GBPCurruncy_btn.Checked)
                {
                    cadAmount = amount * 1.71;
                    usdAmount = amount * 1.29;
                    eurAmount = amount * 1.17;
                    gbpAmount = amount;
                    phpAmount = amount * 71.32;
                    yenAmount = amount * 181.21;

                    CAD_txt.Clear();
                    USD_txt.Clear();
                    EUR_txt.Clear();
                    GBP_txt.Clear();
                    PHP_txt.Clear();
                    YEN_txt.Clear();
                }
                else if (PhilippinePesos_btn.Checked)
                {
                    cadAmount = amount * .024;
                    usdAmount = amount * 0.018;
                    eurAmount = amount * 0.016;
                    gbpAmount = amount * 0.014;
                    phpAmount = amount;
                    yenAmount = amount * 2.54;

                    CAD_txt.Clear();
                    USD_txt.Clear();
                    EUR_txt.Clear();
                    GBP_txt.Clear();
                    PHP_txt.Clear();
                    YEN_txt.Clear();
                }

                CAD_txt.Text = cadAmount.ToString();
                USD_txt.Text = usdAmount.ToString();
                EUR_txt.Text = eurAmount.ToString();
                GBP_txt.Text = gbpAmount.ToString();
                PHP_txt.Text = phpAmount.ToString();
                YEN_txt.Text = yenAmount.ToString();

                try
                {
                    FileStream fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write("CAD : " + Convert.ToString(cadAmount));
                    bw.Write("USD : " + Convert.ToString(usdAmount));
                    bw.Write("EUR : " + Convert.ToString(eurAmount));
                    bw.Write("GBP : " + Convert.ToString(gbpAmount));
                    bw.Write("PHP : " + Convert.ToString(phpAmount));
                    bw.Write("YEN : " + Convert.ToString(yenAmount));
                    bw.Write(DateTime.Now.ToString("yyyy/MM/dd H:mm:ss tt"));

                    bw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid amount input.");
            }
        }

        private void Display_btn_Click(object sender, EventArgs e)
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
                            string MoneyContent1 = bR.ReadString();
                            string MoneyContent2 = bR.ReadString();
                            string MoneyContent3 = bR.ReadString();
                            string MoneyContent4 = bR.ReadString();
                            string MoneyContent5 = bR.ReadString();
                            string MoneyContent6 = bR.ReadString();
                            string MoneyContent7 = bR.ReadString();
                            textToPrint += MoneyContent1 +"\n" + MoneyContent2 + "\n" + MoneyContent3 + "\n" + MoneyContent4 + "\n" + MoneyContent5 + "\n" + MoneyContent6 + "\n\n";
                        }
                        MessageBox.Show(textToPrint, "Result + Jerwinson-Flores CUNANAN");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error");
            }

        }
    }
}
