using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxInceleme
{
    public class SanalDatabase
    {
        public static List<Urun> UrunTablo = new List<Urun>()
        {
            new Urun()
            {
                Id=1,
                UrunAdi="Kayıp Tanrılar Ülkesi",
                StokAdet=10,
                UrunKategori="Roman",
                Aciklama="Ahmet Ümit’ten polisiyeyi arkeoloji ve mitolojiyle harmanlayan usta " +
                "işi bir roman.Berlin Emniyet Müdürlüğü’nün cevval başkomiseri Yıldız Karasu ve" +
                " yardımcısı Tobias Becker, göçmenlerin, işgal evlerinin ve sokak sanatçılarının" +
                " renklendirdiği Berlin sokaklarından Bergama’ya uzanan bir macerada, hayatı ve insanları" +
                " yok etmeye muktedir sırların peşinde bir seri cinayetler dizisini çözmeye çalışıyor." +
                " Soruşturmanın Türkiye ayağında sürpriz bir ismin olaya dahil olmasıyla heyecanın dozu gitgide artıyor.",
                Yazar="Ahmet Ümit",
                UrunResim=@"C:\Users\103AKSAM_FATİH\Desktop\kitapresim\1.JPG",
            },
            new Urun()
            {
                Id=2,
                UrunAdi="Ben Kirke",
                StokAdet=10,
                UrunKategori="Roman",
                Aciklama="PR, Washington Post, Buzzfeed, People, Time, Amazon, Entertainment Weekly," +
                " Bustle ve Newsweek’e göre Yılın En İyi KitabıGoodreads okurlarına göre 2018’in En İyi Fantastik Kitabı" +
                "“Bu dikkat çekici hikâye sizi, Kirke’nin yaptığı bir büyü gibi etkisi altına alacak.”",
                Yazar="Madeline Miller",
                UrunResim=@"C:\Users\103AKSAM_FATİH\Desktop\kitapresim\2.JPG",
            },
            new Urun()
            {
                Id=3,
                UrunAdi="Şeker Portakalı",
                StokAdet=10,
                UrunKategori="Roman",
                Aciklama="Acı dolu bir hayat sürdürmek ve bunu yaşamın olağan seyri gibi kabul etmek," +
                " ta ki hayattaki en gerçek ve karşı konulamaz acının ne olduğunu öğrenene kadar…" +
                " Şeker Portakalı; yoksulluk ve sevgisizlik içinde yaşayan küçük Zeze’nin dünyasını, " +
                "okuyucusuna yalnızca minik bir çocuğun gözünden değil, evrensel bir hakikat penceresinden sunuyor. ",
                Yazar="Jose Mauro De Vasconcelos",
                UrunResim=@"C:\Users\103AKSAM_FATİH\Desktop\kitapresim\3.JPG",
            }
        };
    }
}
