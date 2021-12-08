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
        }

        private void FormElemanIndexTemizle()
        {
            throw new NotImplementedException();
        }

        private void FormTemizle()
        {
            throw new NotImplementedException();
        }
    }
}
