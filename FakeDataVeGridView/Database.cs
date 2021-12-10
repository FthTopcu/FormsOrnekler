using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataVeGridView
{
    public class Database
    {
        public List<Musteri> musteriler = new List<Musteri>();

        public Database()
        {

        }

        public List<Musteri> musteriListele()
        {
            for (int i = 1; i < 1001; i++)
            {
                Musteri musteriTmp = new Musteri();
                musteriTmp.Id = 1000 + i;
                //musteriTmp.Id = Guid.NewGuid();
                musteriTmp.Isim = FakeData.NameData.GetFirstName();
                musteriTmp.Soyisim = FakeData.NameData.GetSurname();
                musteriTmp.TamAdi = $"{musteriTmp.Isim} {musteriTmp.Soyisim}";
                musteriTmp.EmailAdres = FakeData.NetworkData.GetEmail();
                musteriTmp.TelefonNumarasi = FakeData.PhoneNumberData.GetPhoneNumber();
                musteriTmp.Il = FakeData.PlaceData.GetCity();
                musteriTmp.Adres = FakeData.PlaceData.GetAddress();
                musteriTmp.Ilce = FakeData.PlaceData.GetCounty();
                musteriler.Add(musteriTmp);
            }
            return musteriler;
            
        }

    }
}
