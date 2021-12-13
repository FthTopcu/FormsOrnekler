using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIOForms
{
    public class DataIslemleri
    {
        public DataIslemleri()
        {

        }
        public List<Personel> PersonelGetir(int adet)
        {
            List<Personel> personelListe = new List<Personel>();

            int id = 0;
            for (int i = 0; i <= adet; i++)
            {
                Personel personel = new Personel();
                personel.Id = id++;
                personel.Isim = FakeData.NameData.GetFirstName();
                personel.Soyisim = FakeData.NameData.GetSurname();
                personel.FirmaAdi = FakeData.NetworkData.GetDomain();
                personel.EmailAdres = personel.Isim + "." + personel.Soyisim + "@" + personel.FirmaAdi;
                personel.Ulke = FakeData.PlaceData.GetCountry();
                personelListe.Add(personel);
            }
            return personelListe;
        }
        public void PersonelKaydet(string path,List<Personel> personelsListesi)
        {
            DirectoryInfo ulkeBilgisi = null;
            for (int i = 0; i <personelsListesi.Count ; i++)
            {
                if (Directory.Exists(path + "\\" + personelsListesi[i].Ulke))
                {
                    ulkeBilgisi = new DirectoryInfo(path + "\\" + personelsListesi[i].Ulke);
                }
                else
                {
                    ulkeBilgisi = Directory.CreateDirectory(path + "\\" + personelsListesi[i].Ulke);
                }
                FileStream fs = File.Create(ulkeBilgisi.FullName + "\\" + personelsListesi[i].Isim + "." + personelsListesi[i].Soyisim + ".txt");
                byte[] personelBilgi = new UTF8Encoding(true).GetBytes(personelsListesi[i].PersonelBilgileriniGetir());
                fs.Write(personelBilgi, 0, personelBilgi.Length);
                fs.Close();
            }
        }
    }
}
