using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirisUygulamasi
{
    public class SanalDatabase
    {
        public static List<Kullanici> KullaniciTablo = new List<Kullanici>();

        static SanalDatabase()
        {
            KullaniciTablo.Add(new Kullanici()
            {
                Id = 1,
                Isim = "Fatih",
                Soyisim="Topcu",
                KullaniciAdi="fthtopcu",
                Sifre="1",
                Aciklama="Fatih Topcu kullanıcı profil bilgisi"
            });
            KullaniciTablo.Add(new Kullanici()
            {
                Id = 2,
                Isim = "Arif",
                Soyisim = "Aslan",
                KullaniciAdi = "arfasln",
                Sifre = "2",
                Aciklama = "Arif Aslan kullanıcı profil bilgisi"
            });
        }
    }
}
