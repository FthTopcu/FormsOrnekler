using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DataGridViewImage
{
    public class Urun
    {
       
        public int Id { get; set; }
        public string UrunTanim { get; set; }
        public string UrunResimYol { get; set; }
        public Image UrunResim
        {
            get
            {
                if (!string.IsNullOrEmpty(UrunResimYol))
                {
                    return Image.FromFile(UrunResimYol);
                }
                else
                {
                    return Image.FromFile(@"C:\Users\103AKSAM_FATİH\Desktop\kitapresim\NoImage.jpg");
                }
            }
        }
    }
}
