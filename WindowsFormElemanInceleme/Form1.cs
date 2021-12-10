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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SistemGirisForm()
        {
            SistemGiris sistemGirisForm = new SistemGiris();
            sistemGirisForm.ShowDialog();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            SistemGirisForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormElemanlariDoldur();
        }

        private void FormElemanlariDoldur()
        {
            cltUrunOzellikleri.Items.AddRange(Helper.urunOzellikTanims.ToArray());

            cmbUrunKategori.Items.AddRange(Helper.ketegoriListe.ToArray());

            cmbUrunRenk.Items.AddRange(Helper.urunRenk.ToArray());
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            DialogResult result = OFD.ShowDialog();
            if (result==DialogResult.OK)
            {
                pcbResimSecim.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun kayitUrun = new Urun();
            kayitUrun.Id = Guid.NewGuid();

            //Open File Dialog data alma işlemi
            if (!string.IsNullOrEmpty(OFD.FileName))
                kayitUrun.UrunResimYol = OFD.FileName;

            //textboxdan değer alma işlemi...
            if (!string.IsNullOrEmpty(txtUrunTanim.Text))
                kayitUrun.UrunTanim = txtUrunTanim.Text;

            if (!string.IsNullOrEmpty(txtUrunKod.Text))
                kayitUrun.UrunKod = txtUrunKod.Text;

            //comboboxdan seçilen datayı almak
            kayitUrun.UrunRenk = cmbUrunKategori.SelectedItem.ToString();

            kayitUrun.UrunKategori = cmbUrunKategori.SelectedItem.ToString();

            //RichText
            kayitUrun.UrunAciklama = rchAciklama.Text;

            //checkbox listelem
            //selectedItem : 1 ürün bilgisi getirir özel tiplerde kullanılır
            //selectedText : özel bir tip kullanıyorsanız bir ürün seçimi dahi olsa selected text kısmında ayarlamış
            //olduğumuz değeri yakalarız.
            //SelectedValue : kısmında ise text kısmında olduğu gibi value kısmında görmek istediğimiz değeri yakalarız

            foreach (object item in cltUrunOzellikleri.CheckedItems)
            {
                ////kısa kod yazımı 
                //kayitUrun.UrunOzellikListe.Add((UrunOzellikTanim)item);
                ////uzun kod yazım
                UrunOzellikTanim temp = (UrunOzellikTanim)item;
                kayitUrun.UrunOzellikListe.Add(temp);
                //bu kısımda inner type olarak kullandığımız list generic eğer yapıcı metot ile örneklenmedi ise null ref hatası alırız
                //bunu çözmek için ctor(urun) metot içinde list<T> koleksiyonu örneklememiz gereklidir...
            }
        }
    }
}