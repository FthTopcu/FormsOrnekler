using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedBoxListDoldur();
        }

        private void checkedBoxListDoldur()
        {
            foreach (var item in SanalDatabase.UrunTablo)
            {
                chkListBox.Items.Add(item);
            }
        }

        private void chkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = (CheckedListBox)sender;
            if(e.NewValue == CheckState.Checked)
            {
                Urun secilenUrun = checkedListBox.Items[e.Index] as Urun;
                pctUrunResim.Image = Image.FromFile(secilenUrun.UrunResim);
                txtAciklama.Text = secilenUrun.Aciklama;
                txtStokAdet.Text = secilenUrun.StokAdet.ToString();
                txtUrunKategori.Text = secilenUrun.UrunKategori;
                txtUrunAdi.Text = secilenUrun.UrunAdi;
                txtYazar.Text = secilenUrun.Yazar;
            }
            for (int i = 0; i < chkListBox.Items.Count; i++)
            {
                if (i == e.Index)
                {
                    //üzerinde bulunan kayıt
                }
                else
                {
                    chkListBox.SetItemChecked(i, false);
                }

            }
        }
    }
}
