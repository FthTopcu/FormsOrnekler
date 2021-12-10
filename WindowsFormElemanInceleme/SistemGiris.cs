using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormElemanInceleme
{
    public partial class SistemGiris : Form
    {
        public SistemGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                if (txtKullaniciAdi.Text == "admin" && txtPass.Text == "1")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Giriş Bilgileriniz Hatalı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information );
             
                }
            }
            else
            {
                MessageBox.Show("Lütfen Form Alanlarını Eksiksiz Doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
