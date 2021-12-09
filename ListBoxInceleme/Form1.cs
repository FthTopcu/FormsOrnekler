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

        }

    }
}
