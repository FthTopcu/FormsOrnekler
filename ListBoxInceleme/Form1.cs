using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ListBoxDoldurV1();
            ListBoxDoldurV2();
        }

        private void ListBoxDoldurV2()
        {
            lstUrunler.DisplayMember = "UrunAdi";
            lstUrunler.DataSource = SanalDatabase.UrunTablo;
        }

        private void ListBoxDoldurV1()
        {
            foreach (var item in SanalDatabase.UrunTablo)
            {
                lstUrunler.Items.Add(item);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunSecimAdet = lstUrunler.SelectedItems.Count;
            if(urunSecimAdet == 1)
            {
                ListBox lbox = (ListBox)sender;
                Urun u1 = (Urun)lbox.SelectedItem;

                pctUrunResim.Image = Image.FromFile(u1.UrunResim);
                pctUrunResim.SizeMode = PictureBoxSizeMode.AutoSize;
                txtUrunAdi.Text = u1.UrunAdi;
                txtStokAdet.Text = u1.StokAdet.ToString();
                txtUrunKategori.Text = u1.UrunKategori;
                txtYazar.Text = u1.Yazar;
                txtAciklama.Text = u1.Aciklama;
            }
            else if (urunSecimAdet > 1)
            {
                List<Urun> secilenUrunListe = new List<Urun>();
                foreach (var item in lstUrunler.SelectedItems)
                {
                    secilenUrunListe.Add(item as Urun);
                }
                UrunSecimKullanici secimKullanici = new UrunSecimKullanici(secilenUrunListe.ToArray());
                secimKullanici.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen detayını görmek istediğiniz ürünü seçiniz..",
                    "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

    }
}
