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
    public partial class Form1 : Form
    {
        Database db = new Database();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Musteri> musterisListe = db.musteriListele();


            ////1. data bize lazım ama ekran üzerinde göstermek istemyirouz bu gibi durumlarda columns koleksiyonu içinde
            ////ilgili kolonun id değeri veya tip prop adı verilerek visible prop false edilmesi yeterlidir.

            //dgwMusteriListe.DataSource = musterisListe;
            //dgwMusteriListe.Columns[0].Visible = false;
            //dgwMusteriListe.Columns["Id"].Visible = true;

            ////data grid view içersinde bulunan isimleri değiştirmek ..
            //dgwMusteriListe.Columns[0].HeaderText = "Müşteri ID";
            //dgwMusteriListe.Columns[1].HeaderText = "Müşteri İsim";
            //dgwMusteriListe.Columns[2].HeaderText = "Müşteri Soyisim";
            //dgwMusteriListe.Columns[3].HeaderText = "Müşteri Tam Adı";


            //2. data bize lazım değil hiçbir şekilde ekranda görünmesini veya kullanmak istemiyoruz.

            var dgwListe = from I in musterisListe
                           select new
                           {
                               Id = I.Id,
                               Isim = I.Isim,
                               Soyisim = I.Soyisim,
                               TamAdi = I.TamAdi
                           };
            dgwMusteriListe.DataSource = dgwListe.ToList();

            
        }

        private void dgwMusteriListe_DoubleClick(object sender, EventArgs e)
        {
            int musteriID = (int)dgwMusteriListe[0, dgwMusteriListe.CurrentCell.RowIndex].Value;
            Musteri bulunanMusteri = db.musteriListele().FindAll(i => i.Id == musteriID).FirstOrDefault();

            KisiselBilgiler kisiselBilgiler = new KisiselBilgiler(bulunanMusteri);

            kisiselBilgiler.ShowDialog();
        }
    }
}
