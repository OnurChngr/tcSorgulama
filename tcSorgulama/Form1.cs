using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int[] tc = new int[11];


        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string tckimlikno = txtTc.Text;

            if (txtTc.Text != " ")
            {
                if (tckimlikno.Length == 11)
                {
                    if (long.TryParse(tckimlikno, out long result))
                    {
                        for (int i = 0; i < tc.Length; i++)
                        {

                            tc[i] = int.Parse(tckimlikno.Substring(i, 1));
                        }

                        if (tc[0] != 0)
                        {

                            int a = ((tc[0] + tc[2] + tc[4] + tc[6] + tc[8]) * 7) + ((tc[1] + tc[3] + tc[5] + tc[7]) * 9);

                            if (a % 10 == tc[9])
                            {
                                int toplam = tc[0] + tc[2] + tc[4] + tc[6] + tc[8] + tc[1] + tc[3] + tc[5] + tc[7] + tc[9];

                                if (toplam % 10 == tc[10])
                                {
                                    int toplam2 = tc[0] + tc[2] + tc[4] + tc[6] + tc[8];

                                    if ((toplam2 * 8) % 10 == tc[10])
                                    {
                                        MessageBox.Show("Geçerli Tc");
                                    }
                                    else
                                    {
                                        MessageBox.Show("6.maddeye uymuyor!");
                                    }
                                }
                                else
                                {

                                    MessageBox.Show("5.maddeye uymuyor!");
                                }

                            }
                            else
                            {
                                MessageBox.Show("4.maddeye uymuyor!");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Tc no sıfırla başlayamaz!");

                        }


                    }
                    else
                    {
                        MessageBox.Show("Girilen değer doğru formatta değil!");
                    }

                }
                else
                {
                    MessageBox.Show("Girilen değer 11 karakter olmalıdır!");
                }
            }


        }
    }
}
