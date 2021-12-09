using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormElemanInceleme
{
    public static class Helper
    {
        public static List<UrunOzellikTanim> urunOzellikTanims = new List<UrunOzellikTanim>
        {
            new UrunOzellikTanim(){Id=Guid.NewGuid(),Tanim="Pamuk"},
            new UrunOzellikTanim(){Id=Guid.NewGuid(),Tanim="Yıpranmaz"},
            new UrunOzellikTanim(){Id=Guid.NewGuid(),Tanim="%100 yerli"},
            new UrunOzellikTanim(){Id=Guid.NewGuid(),Tanim="Unisex"},
        };
        public static List<string> urunRenk = new List<string>
        {
            "Mavi","Siyah","Kırmıaız","Beyaz","Pembe"
        };
        public static List<string> ketegoriListe = new List<string>
        {
            "A Kategori","B Kategori","C Kategori"
        };
        public static List<Urun> urunListeDb;
        static Helper()
        {
            urunListeDb = new List<Urun>(); 
        }
    }
}
