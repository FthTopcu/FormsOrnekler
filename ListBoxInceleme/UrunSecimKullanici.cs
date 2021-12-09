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
    public partial class UrunSecimKullanici : Form
    {
        Urun[] urunListe;
        public UrunSecimKullanici(Urun[] secilenUrunler)
        {
            InitializeComponent();
            urunListe = secilenUrunler;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UrunSecimKullanici_Load(object sender, EventArgs e)
        {
            foreach (var item in urunListe)
            {
                Button btn = new Button();
                btn.Text = item.UrunAdi;
                btn.Name = "btn" + item.Id.ToString();
                btn.Size = new System.Drawing.Size(122, 37);
                btn.Tag = item;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Urun u1 = btn.Tag as Urun;

            Form F1 = Application.OpenForms["Form1"];
            GroupBox F1GBOX =(GroupBox)F1.Controls["groupBox1"] ;
            ((PictureBox)F1GBOX.Controls["pctUrunResim"]).Image = Image.FromFile(u1.UrunResim);
            ((TextBox)F1GBOX.Controls["txtUrunAdi"]).Text = u1.UrunAdi;
            ((TextBox)F1GBOX.Controls["txtUrunKategori"]).Text = u1.UrunKategori;
            ((TextBox)F1GBOX.Controls["txtStokAdet"]).Text = u1.StokAdet.ToString();
            ((TextBox)F1GBOX.Controls["txtYazar"]).Text = u1.Yazar;
            ((TextBox)F1GBOX.Controls["txtAciklama"]).Text = u1.Aciklama;

            this.Close();
        }
    }
}
