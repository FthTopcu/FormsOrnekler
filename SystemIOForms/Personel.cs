using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOForms
{
    public class Personel
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }
        public string FirmaAdi { get; set; }
        public string Ulke { get; set; }

        public override string ToString()
        {
            return Isim + " " + Soyisim;
        }
        public string PersonelBilgileriniGetir()
        {
            return string.Format("isim : {0} Soyisim : {1} Email Adres " +
                ": {2} Firma Adı : {3} Ulke : {4} ", Isim, Soyisim, EmailAdres, FirmaAdi, Ulke);
        }
    }
}
