using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Urun> urunlerim = new List<Urun>();
            urunlerim.Add(new Urun()
            {
                Id = 1,
                UrunTanim = "Kitap 1",
                UrunResimYol = @"C:\Users\103AKSAM_FATİH\Desktop\kitapresim\1.jpg"
            });
            urunlerim.Add(new Urun()
            {
                Id = 2,
                UrunTanim = "Kitap 2",
                UrunResimYol = @"C:\Users\103AKSAM_FATİH\Desktop\kitapresim\2.jpg"
            });
            urunlerim.Add(new Urun()
            {
                Id = 3,
                UrunTanim = "Kitap 3",
                UrunResimYol = @"C:\Users\103AKSAM_FATİH\Desktop\kitapresim\3.jpg"
            });
            dataGridView1.DataSource = urunlerim;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
