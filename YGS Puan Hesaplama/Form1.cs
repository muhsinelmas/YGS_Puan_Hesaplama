using System;
using System.Drawing;
using System.Windows.Forms;

namespace YGS_Puan_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double _net1, _net2, _net3, _net4;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            lblYgs6Puan.Text = "0";
            lblYgs5Puan.Text = "0";
            lblYgs4Puan.Text = "0";
            lblYgs3Puan.Text = "0";
            lblYgs2Puan.Text = "0";
            lblYgs1Puan.Text = "0";

            lblTrNet.Text = "0";
            lblSosNet.Text = "0";
            lblMatNet.Text = "0";
            lblFenNet.Text = "0";
            LblToplam.Text = "0";

            label12.Text = "LYS'ye Girme Durumu";
            label12.ForeColor = Color.Black;
            textBox1.Focus();

            pictureBox1.ImageLocation = @"";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                textBox1.Text = "0";
            }
            if (textBox2.Text.Trim() == "")
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text.Trim() == "")
            {
                textBox3.Text = "0";
            }
            if (textBox4.Text.Trim() == "")
            {
                textBox4.Text = "0";
            }
            if (textBox5.Text.Trim() == "")
            {
                textBox5.Text = "0";
            }
            if (textBox6.Text.Trim() == "")
            {
                textBox6.Text = "0";
            }
            if (textBox7.Text.Trim() == "")
            {
                textBox7.Text = "0";
            }
            if (textBox8.Text.Trim() == "")
            {
                textBox8.Text = "0";
            }
            try
            {
                //Net Hesabı
                _net1 = double.Parse(textBox1.Text) - (double.Parse(textBox5.Text) / 4);
                lblTrNet.Text = _net1.ToString() + " Net";
                _net2 = double.Parse(textBox2.Text) - (double.Parse(textBox6.Text) / 4);
                lblSosNet.Text = _net2.ToString() + " Net";
                _net3 = double.Parse(textBox3.Text) - (double.Parse(textBox7.Text) / 4);
                lblMatNet.Text = _net3.ToString() + " Net";
                _net4 = double.Parse(textBox4.Text) - (double.Parse(textBox8.Text) / 4);
                lblFenNet.Text = _net4.ToString() + " Net";
                //Net Toplam
                LblToplam.Text = (_net1 + _net2 + _net3 + _net4).ToString() + " Net";
                //Puan Hesabı
                double ygs1 = (_net1 * 1.995) + (_net2 * 1.173) + (_net3 * 3.773) + (_net4 * 3.099) + 98.416;
                lblYgs1Puan.Text = ygs1.ToString();
                double ygs2 = (_net1 * 1.977) + (_net2 * 1.162) + (_net3 * 2.804) + (_net4 * 4.095) + 98.430;
                lblYgs2Puan.Text = ygs2.ToString();
                double ygs3 = (_net1 * 3.861) + (_net2 * 3.404) + (_net3 * 1.826) + (_net4 * 1.000) + 96.367;
                lblYgs3Puan.Text = ygs3.ToString();
                double ygs4 = (_net1 * 2.848) + (_net2 * 4.465) + (_net3 * 1.796) + (_net4 * 0.983) + 96.344;
                lblYgs4Puan.Text = ygs4.ToString();
                double ygs5 = (_net1 * 3.660) + (_net2 * 2.321) + (_net3 * 3.072) + (_net4 * 1.022) + 97.010;
                lblYgs5Puan.Text = ygs5.ToString();
                double ygs6 = (_net1 * 3.295) + (_net2 * 1.177) + (_net3 * 3.510) + (_net4 * 2.074) + 97.764;
                lblYgs6Puan.Text = ygs6.ToString();
                //LYSye Girme Durumu
                if (double.Parse(lblYgs1Puan.Text) >= 180 || double.Parse(lblYgs2Puan.Text) >= 180 || double.Parse(lblYgs3Puan.Text) >= 180 || double.Parse(lblYgs4Puan.Text) >= 180 || double.Parse(lblYgs5Puan.Text) >= 180 || double.Parse(lblYgs6Puan.Text) >= 180)
                {
                    label12.Text = "LYS'ye Girebilirsiniz.";
                    pictureBox1.ImageLocation = @"Pngler\Gülme.png";
                    label12.ForeColor = Color.Green;
                }
                else
                {
                    label12.Text = "LYS'ye Giremezsiniz.";
                    pictureBox1.ImageLocation = @"Pngler\Üzgün.png";
                    label12.ForeColor = Color.Red;
                }
            }
            catch (Exception)
            {
                if(MessageBox.Show("Lütfen Sadece Rakam Kullanın...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox8.Clear();

                    textBox1.Focus();
                }
            }
        }
    }
}
