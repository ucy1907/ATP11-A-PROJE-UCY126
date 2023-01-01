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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATP11A_UCY126_AS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();

        string buluncakKelime = "";

        int resimSayisi = 0;

        string appPath = Path.GetDirectoryName(Application.ExecutablePath);

        #region Kelimeler

        public string[] kelimeler = new string[10];

        public void kelimeleriAta()
        {
            kelimeler[0] = "KUMANDA";

            kelimeler[1] = "TELEVİZYON";

            kelimeler[2] = "BİLGİSAYAR";

            kelimeler[3] = "ARABA";

            kelimeler[4] = "CİNSİYET";

            kelimeler[5] = "PROGRAMLAMA";

            kelimeler[6] = "KOLTUK";

            kelimeler[7] = "BİSİKLET";

            kelimeler[8] = "KAVGA";

            kelimeler[9] = "ARKADAŞLIK";

        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            kelimeleriAta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";

            buluncakKelime = kelimeler[r.Next(0,kelimeler.Length)];

            listBox2.Items.Add(buluncakKelime);

            for (int i = 0; i < buluncakKelime.Length; i++)
            {

                label3.Text += "_";

            }

            resimSayisi = 0;

            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char aranacakChar = char.Parse(textBox1.Text);

            char[] karakterler = buluncakKelime.ToCharArray();

            bool varmi = false;

            for (int i = 0; i <= listBox1.Items.Count - 1; i++)
            {

                if (listBox1.Items[i].ToString() == aranacakChar.ToString())
                {

                    MessageBox.Show("Bu harf daha önce girilmiştir. Başka Harf deneyin.");

                    return;

                }

            }

            listBox1.Items.Add(aranacakChar.ToString());

            for (int i = 0; i < karakterler.Length; i++)
            {

                if (karakterler[i] == aranacakChar)
                {

                    label3.Text = label3.Text.Remove(i, 1);

                    label3.Text = label3.Text.Insert(i, aranacakChar.ToString());

                    varmi = true;

                }

            }

            if (label3.Text == buluncakKelime)

            {

                MessageBox.Show("Kelime'yi bildiniz. TEBRİKLER.");

                label3.Text = buluncakKelime;

                return;

            }

            textBox1.Text = "";

            if (varmi == false)
            {

                resimSayisi++;

                if (resimSayisi == 1)
                {
                    pictureBox2.Visible = false;
                }
                else if (resimSayisi == 2)
                {
                    pictureBox3.Visible = false;
                }

                else if (resimSayisi == 3)
                {
                    pictureBox4.Visible = false;
                }
                else if (resimSayisi == 4)
                {
                    pictureBox5.Visible = false;
                }
                else if (resimSayisi == 5)
                {
                    pictureBox6.Visible = false;
                }
                else if (resimSayisi == 6)
                {
                    pictureBox7.Visible = false;
                }
                else if (resimSayisi == 6)

                    if (resimSayisi == 6)
                    {

                        MessageBox.Show("Bütün Haklarınız doldu oyunu kaybettiniz.");

                        label3.Text = buluncakKelime;

                        return;

                    }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tahmin = textBox2.Text;

            if (tahmin == buluncakKelime)
            {

                MessageBox.Show("Kelime'yi bildiniz. TEBRİKLER.");

                label3.Text = buluncakKelime;

            }

            else
            {

                MessageBox.Show("YANLIŞ TAHMİN");

            }
        }
    }
}
