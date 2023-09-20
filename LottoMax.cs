using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;

namespace Project
{
    public partial class LottoMax : Form
    {
        FileStream fs = null;
        string dir = @".\Files\";
        string pathBin = @".\Files\LottoNbrs.txt";
        public LottoMax()
        {
            InitializeComponent();
        }

        private void LottoMax_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private void generator_btn_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int randomNumber = random.Next(1, 49);
            //int randomDigit = random.Next(10);
            //sevendigit_txt.AppendText(randomDigit.ToString());
            //RandomNum_txt.AppendText(randomNumber.ToString() + Environment.NewLine);

            Random random = new Random();
            int maxRandomNumberCount = 8;
            int maxRandomDigitCount = 7;
            List<int> randomNumbers = new List<int>();

            RandomNum_txt.Clear();
            sevendigit_txt.Clear();

            while (randomNumbers.Count < maxRandomNumberCount)
            {
                int randomNumber = random.Next(1, 50);

                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                    RandomNum_txt.AppendText(randomNumber.ToString() + Environment.NewLine);
                }
            }

            for (int i = 0; i < maxRandomDigitCount; i++)
            {
                int randomDigit = random.Next(10);
                sevendigit_txt.AppendText(randomDigit.ToString());
            }

            try
            {
                FileStream fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("Max, ");
                bw.Write(DateTime.Now.ToString("yyyy/MM/dd H:mm:ss tt"));
                bw.Write(string.Join(",", randomNumbers));
                bw.Write(" Extra: ");
                bw.Write(Convert.ToString(random.Next(0, 50)));
                bw.Close();
            } catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error");
            }
                
                     
            //bw.WriteLine("LottoMax Random Numbers: ");
            //foreach (int number in randomNumbers)
            //{
            //    bw.Write(number);
            //}

            //bw.WriteLine("LottoMax Random");
        }

        private void Display_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the file content
                using (FileStream fileStream = new FileStream(pathBin, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader bR = new BinaryReader(fileStream))
                    {
                        string textToPrint = "";
                        while (bR.PeekChar() != -1)
                        {
                            string LottoMaxContent = bR.ReadString();
                            textToPrint += LottoMaxContent + "\n\n";
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

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
