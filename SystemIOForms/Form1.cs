using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOForms
{
    public partial class Form1 : Form
    {
        DataIslemleri dataIslemleri;
        List<Personel> personelListesi;
        public Form1()
        {
            InitializeComponent();
            dataIslemleri = new DataIslemleri();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
            personelListesi = dataIslemleri.PersonelGetir(150);
            lstPersonel.DataSource = personelListesi;

        }

        private void lstPersonel_DoubleClick(object sender, EventArgs e)
        {
            Personel secilenPersonel = (Personel)lstPersonel.SelectedItem;
            txtIsim.Text = secilenPersonel.Isim;
            txtSoyisim.Text = secilenPersonel.Soyisim;
            txtEmailAdres.Text = secilenPersonel.EmailAdres;
            txtFirma.Text = secilenPersonel.FirmaAdi;
            txtUlke.Text = secilenPersonel.Ulke;
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            dataIslemleri.PersonelKaydet("c:\\NetworkAkademi", personelListesi);
        }
    }
}
