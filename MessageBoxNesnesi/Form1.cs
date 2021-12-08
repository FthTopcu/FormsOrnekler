using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesajGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcıya göstermek istediğimiz bilgi", "Başlık bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnSoruSor_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Yeniden denemek ister misiniz?", "Soru", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

            }
            if (res == DialogResult.No)
            {

            }
            if (res == DialogResult.Cancel)
            {

            }

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int islemSonuc = yeniMusteriEkle(new Musteri()
            {
                Id = Guid.NewGuid(),
                Isim = txtIsim.Text,
                Soyisim = txtSoyisim.Text,
                EmailAdres = txtEmailAdres.Text,
                TelefonNumarasi = txtTelefonNumara.Text
            });

            if (islemSonuc>0)
            {
                DialogResult res = MessageBox.Show("Müşteri ekleme işlemi başarılı yeni müşteri eklemek ister misiniz?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.BalloonTipText = "Toplam müşteri kayıt adedi : " + SanalDatabase.musteriler.Count.ToString();
                    bildirimCubugu.BalloonTipTitle = "Müşteri adet bilgisi ";
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.Icon = SystemIcons.Information;
                    bildirimCubugu.ShowBalloonTip(2000);
                }
                else if (res == DialogResult.No)
                {

                }
                EkranTemizle();
                
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işi yapılamadı!");
            }
            EkranListele();
        }

        private void EkranListele()
        {
            lstMusteriler.DataSource = SanalDatabase.musteriler;
            lstMusteriler.DisplayMember = "Isim+Soyisim+EmailAdres+TelefonNumarasi";
        }

        private void EkranTemizle()
        {
            txtIsim.Text = null;
            txtSoyisim.Text = null;
            txtEmailAdres.Text = null;
            txtTelefonNumara.Text = null;
        }

        private int yeniMusteriEkle(Musteri musteri)
        {
            SanalDatabase.musteriler.Add(musteri);
            return 1;
        }

        
    }
}
