using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeDataVeGridView
{
    public partial class KisiselBilgiler : Form
    {
        Musteri musteriData;
        public KisiselBilgiler(Musteri data)
        {
            InitializeComponent();
            musteriData = data;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KisiselBilgiler_Load(object sender, EventArgs e)
        {
            txtIsim.Text = musteriData.Isim;
            txtSoyisim.Text = musteriData.Soyisim;
            txtTamAdi.Text = musteriData.TamAdi;
            txtIl.Text = $"{musteriData.Il} / {musteriData.Ilce}";
            txtTelefonNumarasi.Text = musteriData.TelefonNumarasi;
            txtEmailAdres.Text = musteriData.EmailAdres;
            txtAdres.Text = musteriData.Adres;
        }
    }
}
