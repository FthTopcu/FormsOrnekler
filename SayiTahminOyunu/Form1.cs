using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi;
        int skor;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            skor = 100;
            lblSkor.Text = "SKOR : " + skor.ToString();
            btnTahmin.Enabled = true;
            RandomSayiUret();
            MessageBox.Show("Aklımdan 0-100 arasında Bir Sayı Tuttum.");
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(txtTahmin.Text);
            if (tahmin < sayi)
            {
                MessageBox.Show("Yukarı");
                skor = skor - 10;
            }
            else if (tahmin > sayi)
            {
                MessageBox.Show("Aşağı");
                skor = skor - 10;
            }
            else
            {
                MessageBox.Show("Tebrikler..:))");
                skor += 50;
                RandomSayiUret();
                MessageBox.Show("Yeni Sayı Tuttum.");
            }
            if (skor == 0)
            {
                MessageBox.Show("GAME OVER!!!!!");
                btnTahmin.Enabled = false;
            }
            lblSkor.Text = "Skor : " + skor.ToString();
            txtTahmin.Clear();
        }
        void RandomSayiUret()
        {
            Random rastgele = new Random();
            sayi = rastgele.Next(101);
        }
    }
}
