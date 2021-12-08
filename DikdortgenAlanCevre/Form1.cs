using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DikdortgenAlanCevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            lblAlan.Text = (Convert.ToInt32(txtKisaKenar.Text) * Convert.ToInt32(txtUzunKenar.Text)).ToString();
            lblCevre.Text = (Convert.ToInt32(txtKisaKenar.Text)*2 + Convert.ToInt32(txtUzunKenar.Text)*2).ToString();
        }
    }
}
