using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatriceBaremeHAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Computebutton_Click(object sender, EventArgs e)
        {
            string line;
            double Result = 0, LowestHAD = 20250, Sum = 0, ExtraHAD = 33750;
            double Temp = 0, Low, High, Rate, FixedRate = 0.27, Percent = 100, TwentyFiveM = 25000000;
            int counter = 0;
            try
            {
                string FormattedSum = SumTextBox.Text?.ToString()?.Replace(",", "")?.Replace(" ", "")?.Replace(".", "");
                Sum = Convert.ToDouble(FormattedSum, System.Globalization.CultureInfo.InvariantCulture);
                //StringBuilder SB = new StringBuilder();
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "CalculatriceBaremeHAD.HADFile.txt";
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    using (StreamReader file = new StreamReader(stream))
                    {
                        while (!file.EndOfStream && Sum > 0)
                        {
                            line = file.ReadLine();
                            string[] Arr = line.Split(' ');
                            Low = Convert.ToDouble(Arr[0], System.Globalization.CultureInfo.InvariantCulture);
                            High = Convert.ToDouble(Arr[1], System.Globalization.CultureInfo.InvariantCulture);
                            Rate = Convert.ToDouble(Arr[2], System.Globalization.CultureInfo.InvariantCulture);

                            if (counter == 0)
                            {
                                Temp = High - Low;

                                if (Sum < Temp)
                                {
                                    Result += LowestHAD;
                                    Sum = 0;
                                    //SB.Append(Low).Append("  à  ").Append(High - 1).Append("    :    ").Append(Result).AppendLine();
                                }
                                else if (Sum >= Temp)
                                {
                                    Result += Temp * (Rate / Percent);
                                    Sum = Sum - Temp;
                                    //SB.Append(Low).Append("  à  ").Append(High).Append("    :    ");
                                    //SB.Append(Temp).Append(" x ").Append(Rate).Append(" = ").Append(Result).AppendLine();
                                }

                            }
                            else
                            {
                                Temp = High - (Low - 1);
                                //SB.Append(Low).Append("  à  ").Append(High).Append("    :    ");
                                if (Sum >= Temp)
                                {
                                    Result += Temp * (Rate / Percent);
                                    Sum = Sum - Temp;
                                    //SB.Append(Temp).Append(" x ").Append(Rate).Append(" = ").Append(Result).AppendLine();
                                }
                                else
                                {
                                    Result += Sum * (Rate / Percent);
                                    //SB.Append(Sum).Append(" x ").Append(Rate).Append(" = ").Append(Result).AppendLine();
                                    Sum = 0;
                                }

                            }
                            counter++;
                        }

                        if (Sum > 0)
                        {
                            //SB.Append("Valeur au dessus de 25.000.000:").Append(Sum).AppendLine();
                            Result += Sum * (FixedRate / Percent);
                            if(Sum >= TwentyFiveM)
                                Result += (Sum / TwentyFiveM) * ExtraHAD;
                            //SB.Append(Sum).Append(" x ").Append(FixedRate).Append(" = ").Append(Result).AppendLine();
                        }
                       // SummaryTextBox.Text = SB.ToString();
                        ResultTextBox.Text = Math.Round(Result).ToString() + " FCFA";
                    }
                }
                
            }
            catch (Exception ex)
            {
                if (ex.Message == "Input string was not in a correct format.")
                    MessageBox.Show("Erreur, valeur incorrecte " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Erreur, " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            SumTextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
            //SummaryTextBox.Text = string.Empty;
        }

        private void SumTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SumTextBox.Text == "")
                Computebutton.Enabled = false;
            else
                Computebutton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Computebutton.Enabled = false;
            ResultTextBox.ReadOnly = true;
        }
    }
}
