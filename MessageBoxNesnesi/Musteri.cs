using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxNesnesi
{
    public class Musteri
    {
        public Guid Id{ get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string EmailAdres { get; set; }
        public string TelefonNumarasi { get; set; }

        public override string ToString()
        {
            return Isim + " " + Soyisim;
        }
    }
}
