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
    public partial class AnaForm : Form
    {
        public AnaForm(Kullanici bulunanKullanici)
        {
            InitializeComponent();
            txtIsim.Text = bulunanKullanici.Isim;
            txtSoyisim.Text = bulunanKullanici.Soyisim;
            txtKullaniciAdi.Text = bulunanKullanici.KullaniciAdi;
            txtSifre.Text = bulunanKullanici.Sifre;
            txtAciklama.Text = bulunanKullanici.Aciklama;
            btnGuncelle.Tag = bulunanKullanici.Id;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = (int)btnGuncelle.Tag;
            int index = SanalDatabase.KullaniciTablo.FindIndex(i => i.Id == id);
            SanalDatabase.KullaniciTablo[index].Isim = txtIsim.Text;
            SanalDatabase.KullaniciTablo[index].Soyisim = txtSoyisim.Text;
            SanalDatabase.KullaniciTablo[index].KullaniciAdi = txtKullaniciAdi.Text;
            SanalDatabase.KullaniciTablo[index].Sifre = txtSifre.Text;
            SanalDatabase.KullaniciTablo[index].Aciklama = txtAciklama.Text;

        }
    }
}
