using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrolleri
{
    public class SanalDatabase
    {
        public static List<Kullanici> KullaniciTablo = new List<Kullanici>();

        static SanalDatabase()
        {
            KullaniciTablo.Add(new Kullanici()
            {
                Id = Guid.NewGuid(),
                Isim = "Fatih",
                Soyisim="Topcu",
                TelefonNumarasi = "fthtopcu",
                EmailAdres = "fthtopcu@gmail.com",
               
            });
            KullaniciTablo.Add(new Kullanici()
            {
                Id = Guid.NewGuid(),
                Isim = "Arif",
                Soyisim = "Aslan",
                TelefonNumarasi = "arfasln",
                EmailAdres= "arfasln@hotmail.com",
               
            });
        }
    }
}
