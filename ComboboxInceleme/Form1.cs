using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Items.Add metodu kullanılarak değerler comboboxa eklenir
            //ComboboxDoldurV1();
            ComboboxDoldurV2();
        }

        private void ComboboxDoldurV2()
        {
           
            cmbListe.DataSource = SanalDatabase.UrunTablo;
            cmbListe.SelectedIndex = -1;
        }

        private void ComboboxDoldurV1()
        {
            foreach (Urun item in SanalDatabase.UrunTablo)
            {
                cmbListe.Items.Add(item);
            }
        }

        private void cmbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Yöntem 

            object o1 = cmbListe.SelectedItem;
            Urun u1 = (Urun)o1;
            //u1 = cmbListe.SelectedItem == null ? null : cmbListe.SelectedItem as Urun;<--1. yöntem
            //2.Yöntem
            ComboBox secilenCombobox = sender as ComboBox;//<-- 2. yöntem
            //1. yöntem eğer form içersinde bulunan form elemanına özel bir metot yazıldı ise o zaman ilgili form elemanını direkt olarak
            //çağırmak daha mantıklıdır.
            //2. yöntem çalışma zamanında oluşturmuş olduğumuz form elemanlarından hangisine tıklanıldığını veya işlem yapıldığını bilmediğimiz
            //için ve metotumuz birden fazla form elemanında olay metodu olarak tanımlandığı için biz sender üzerinden gelen nesneyi kullanır
            //kullanıcının hangi windows form elemanında işlem yapmış olduğunu anlarız.
            if (u1 != null)
            {
                pctUrunResim.Image = Image.FromFile(u1.UrunResim);

                txtUrunAdi.Text = u1.UrunAdi;
                txtStokAdet.Text = u1.StokAdet.ToString();
                txtUrunKategori.Text = u1.UrunKategori;
                txtYazar.Text = u1.Yazar;
                txtAciklama.Text = u1.Aciklama;
            }

        }
    }
}
