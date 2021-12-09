using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtPass.Text;

            Kullanici bulunanKullanici = SanalDatabase.KullaniciTablo.Find(i => i.KullaniciAdi == kullaniciAdi && i.Sifre == sifre);

            //KullaniciAdi = "admin && sifre = "123"
            if (bulunanKullanici != null)
            {
                AnaForm _anaForm = new AnaForm(bulunanKullanici);
                _anaForm.Show();

            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı bilgileri","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
