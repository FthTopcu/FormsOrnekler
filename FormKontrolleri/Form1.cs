using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            DialogResult resultEnum = MessageBox.Show("Form içerisinde bulunan değerleri silmek istediğinden emin misiniz?", "Form temizleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultEnum == DialogResult.Yes)
            {
                FormTemizle();
                FormElemanIndexTemizle();
            }      
            else
            {
                //işlem iptal edildi...
            }
        }

       

        private void FormTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }
        private void FormElemanIndexTemizle()
        {
           ((TextBox)this.Controls["txtIsim"]).Text = string.Empty;
           ((TextBox)this.Controls["txtSoyisim"]).Text = string.Empty;
           ((TextBox)this.Controls["txtEmailAdres"]).Text = string.Empty;
           ((TextBox)this.Controls["txtTelefonNumarasi"]).Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            frmOnizleme frmOnizlemeKayit = new frmOnizleme();
            ((TextBox)frmOnizlemeKayit.Controls["txtIsim"]).Text =this.txtIsim.Text;
            ((TextBox)frmOnizlemeKayit.Controls["txtSoyisim"]).Text =this.txtSoyisim.Text;
            ((TextBox)frmOnizlemeKayit.Controls["txtEmailAdres"]).Text = this.txtEmailAdres.Text;
            ((TextBox)frmOnizlemeKayit.Controls["txtTelefonNumarasi"]).Text = this.txtTelefonNumarasi.Text;
            frmOnizlemeKayit.ShowDialog();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //sanal database içerisine kayıt işlemi olacak(ödev)
            if (txtIsim.Text != null && txtSoyisim.Text != null && txtEmailAdres.Text != null && txtTelefonNumarasi.Text != null)
            {
                Kullanici kullanici = new Kullanici()
                {
                    Id = Guid.NewGuid(),
                    Isim = txtIsim.Text,
                    Soyisim = txtSoyisim.Text,
                    EmailAdres = txtEmailAdres.Text,
                    TelefonNumarasi = txtTelefonNumarasi.Text
                };

                SanalDatabase.KullaniciTablo.Add(kullanici);
                FormTemizle();
                MessageBox.Show("Kayit Başarılı.");
            }
           
        }
    }
}
