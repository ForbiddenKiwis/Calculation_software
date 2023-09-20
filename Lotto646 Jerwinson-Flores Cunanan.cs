using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Lotto649_Jerwinson_Flores_Cunanan : Form
    {
        FileStream fs = null;
        string dir = @".\Files\";
        string pathBin = @".\Files\LottoNbrs.txt";
        public Lotto649_Jerwinson_Flores_Cunanan()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close theApp.? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void generator_btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int maxRandomNumberCount = 7;
            int maxRandomDigitCount = 7;
            List<int> randomNumbers = new List<int>();

            randomNum_txt.Clear();
            sevenDigit_txt.Clear();

            while (randomNumbers.Count < maxRandomNumberCount)
            {
                int randomNumber = random.Next(1, 50);

                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                    randomNum_txt.AppendText(randomNumber.ToString() + Environment.NewLine);
                }
            }

            for (int i = 0; i < maxRandomDigitCount; i++)
            {
                int randomDigit = random.Next(10);
                sevenDigit_txt.AppendText(randomDigit.ToString());
            }

            try
            {
                FileStream fs = new FileStream(pathBin, FileMode.Append, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("649, ");
                bw.Write(DateTime.Now.ToString("yyyy/MM/dd H:mm:ss tt"));
                bw.Write(string.Join(",", randomNumbers));
                bw.Write(" Extra: ");
                bw.Write(Convert.ToString(random.Next(0, 50)));
                bw.Close();
            } catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}" ,"Error");
            }
        }

        private void Display_btn_Click(object sender, EventArgs e)
        {
            string filePath = "YourFilePath.txt"; // Replace with the actual file path

            try
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
                                string LottoContent = bR.ReadString();
                                textToPrint += LottoContent + "\n\n";
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error");
            }
        }
    }
}
