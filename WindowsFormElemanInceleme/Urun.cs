using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormElemanInceleme
{
    public class Urun
    {
        public Guid Id { get; set; }
        public string UrunResimYol { get; set; }
        public string UrunKod { get; set; }
        public string UrunRenk { get; set; }
        public string UrunTanim { get; set; }
        public string UrunAciklama { get; set; }
        public string UrunKategori { get; set; }
        public List<UrunOzellikTanim> UrunOzellikListe { get; set; }
        public bool EkGaranti { get; set; }

    }
    public class UrunOzellikTanim
    {
        public Guid Id { get; set; }
        public string Tanim { get; set; }
        public override string ToString()
        {
            return Tanim;
        }
    }
}
