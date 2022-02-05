using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Price_Prediction
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        private void Input_Load(object sender, EventArgs e)
        {

        }

        private void tbPP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(tbPP.Text);
            int y = Int32.Parse(tbYear.Text);
            string c = tbCN.Text;
            string s = tbST.Text;
            string f = tbFT.Text;

            if (((s == "Dealer") || (s == "Individual")) && ((f == "Diesel") || (f == "Petrol")))
            {

                if (x <= 44850)
                {
                    if (y <= 2011)
                    {
                        ave_txt.Text = "12,814.29 PHP";
                        effect_txt.Text = "-9,242.71 PHP";
                    }
                    else if ((y > 2011) && (y <= 2013))
                    {
                        ave_txt.Text = "17,447.14 PHP";
                        effect_txt.Text = "-9,242.71 PHP";
                    }
                    else if ((y > 2013) && (y <= 2015))
                    {
                        ave_txt.Text = "23,874.00 PHP";
                        effect_txt.Text = "1,817.00 PHP";
                    }
                    else
                    {
                        ave_txt.Text = "30,046.36 PHP";
                        effect_txt.Text = "7,989.36 PHP";
                    }
                }
                else if ((x > 44850) && (x <= 60720))
                {
                    if (y <= 2009)
                    {
                        ave_txt.Text = "13,110.00 PHP";
                        effect_txt.Text = "-22,008.62 PHP";
                    }
                    else if ((y > 2009) && (y <= 2014))
                    {
                        ave_txt.Text = "33,603.00 PHP";
                        effect_txt.Text = "-1,515.62 PHP";
                    }
                    else if ((y > 2014) && (y <= 2016))
                    {
                        ave_txt.Text = "41,124.00 PHP";
                        effect_txt.Text = "6,005.379 PHP";
                    }
                    else
                    {
                        ave_txt.Text = "51,405.00 PHP";
                        effect_txt.Text = "16,286.38 PHP";
                    }
                }
                else if ((x > 60720) && (x <= 110400))
                {
                    if (y <= 2012)
                    {
                        ave_txt.Text = "35,190.00 PHP";
                        effect_txt.Text = "-23,170.65 PHP";
                    }
                    else
                    {
                        if ((c == "Bajaj Avenger 220") && (c == "Bajaj Avenger 220 dtsi"))
                        {

                        }
                    }
                }
                else if ((x > 110400) && (x <= 305670))
                {
                    if (s == "Dealer")
                    {
                        if (y <= 2015)
                        {
                            ave_txt.Text = "154,215.00 PHP";
                            effect_txt.Text = "-23,155.59 PHP";
                        }
                        else
                        {
                            ave_txt.Text = "210,450.00 PHP";
                            effect_txt.Text = "33,79.41 PHP";
                        }
                    }
                    else if (s == "Individual")
                    {
                        if (y <= 2013)
                        {
                            ave_txt.Text = "56,062.50 PHP";
                            effect_txt.Text = "-27,312.50 PHP";
                        }
                        else
                        {
                            ave_txt.Text = "97,031.25 PHP";
                            effect_txt.Text = "13,656.25 PHP";
                        }
                    }
                    else
                    {
                        DialogResult SellerError;
                        SellerError = MessageBox.Show("Wrong Seller Type.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (SellerError == DialogResult.Yes)
                        {
                            this.Close();
                        }
                        else
                        {

                        }
                    }
                }
                else if ((x > 305670) && (x <= 517500))
                {
                    if (y <= 2011)
                    {
                        ave_txt.Text = "181,125.00 PHP";
                        effect_txt.Text = "-103,155.00 PHP";
                    }
                    else if ((y > 2011) && (y <= 2013))
                    {
                        ave_txt.Text = "252,650.00 PHP";
                        effect_txt.Text = "-41,630.00 PHP";
                    }
                    else if ((y > 2013) && (y <= 2015))
                    {
                        ave_txt.Text = "312,800.00 PHP";
                        effect_txt.Text = "28,520.00 PHP";
                    }
                    else
                    {
                        ave_txt.Text = "368,718.75 PHP";
                        effect_txt.Text = "84,438,75 PHP";
                    }
                }
                else if ((x < 517500) && (x <= 744510))
                {
                    if (y <= 2011)
                    {
                        ave_txt.Text = "210,450.00 PHP";
                        effect_txt.Text = "-199,999.84 PHP";
                    }
                    else if ((y > 2011) && (y <= 2013))
                    {
                        ave_txt.Text = "353,682.50 PHP";
                        effect_txt.Text = "-56,767.34 PHP";
                    }
                    else if ((y > 2013) && (y <= 2016))
                    {
                        if (x <= 641010)
                        {
                            ave_txt.Text = "420,555.000 PHP";
                            effect_txt.Text = "-31,699.41 PHP";
                        }
                        else
                        {
                            ave_txt.Text = "497,539.29 PHP";
                            effect_txt.Text = "45,284.87 PHP";
                        }
                    }
                    else
                    {
                        ave_txt.Text = "561,857.14 PHP";
                        effect_txt.Text = "151,407.30 PHP";
                    }
                }
                else if ((x > 744510) && (x <= 1020510))
                {
                    if (y <= 2011)
                    {
                        ave_txt.Text = "238,050.00 PHP";
                        effect_txt.Text = "-331,890.00 PHP";
                    }
                    else if ((x > 2011) && (x <= 2014))
                    {
                        ave_txt.Text = "460,920.00 PHP";
                        effect_txt.Text = "-109,020.00 PHP";
                    }
                    else
                    {
                        if (c == "city")
                        {
                            if (y <= 2015)
                            {
                                ave_txt.Text = "600,300.00 PHP";
                                effect_txt.Text = "8-50,423.08 PHP";
                            }
                            else
                            {
                                ave_txt.Text = "693,942.86 PHP";
                                effect_txt.Text = "43,219.78 PHP";
                            }
                        }
                        else if ((c == "creta") && (c == "elantra") && (c == "innova"))
                        {
                            ave_txt.Text = "817,650.00 PHP";
                            effect_txt.Text = "114,213.16 PHP";
                        }
                        else
                        {
                            ave_txt.Text = "703,436.84 PHP";
                            effect_txt.Text = "133,496.84 PHP";
                        }
                    }
                }
                else
                {
                    if (f == "Diesel")
                    {
                        ave_txt.Text = "1,332,390.00 PHP";
                        effect_txt.Text = "342,309.00 PHP";
                    }
                    else if (f == "Petrol")
                    {
                        ave_txt.Text = "542,446.15 PHP";
                        effect_txt.Text = "-447,634.85 PHP";
                    }
                    else
                    {
                        DialogResult FuelError;
                        FuelError = MessageBox.Show("Wrong Fuel Type.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (FuelError == DialogResult.Yes)
                        {
                            this.Close();
                        }
                        else
                        {

                        }
                    }
                }
            }
            else
            {
                DialogResult InputError;
                InputError = MessageBox.Show("Wrong Input Type.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (InputError == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
