using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkiTarihArasiniBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugunTarihi = DateTime.Now;
            DateTime sinavTarihi = dateTimePicker1.Value;

            TimeSpan ts = sinavTarihi - bugunTarihi;
            //yazilimkodlama.com
            label1.Text = "Sınav Tarihi : " + sinavTarihi.ToShortDateString();
            if (ts.Days > 0)
                lblKalanGun.Text = "Kalan Gün : " + ts.Days.ToString();
            else
                lblKalanGun.Text = "Geçmiş Bir Tarih Girdiniz.";
        }
    }
}
