﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageBoxNesnesi
{
    public class SanalDatabase
    {
        public static List<Musteri> musteriler { get; set; }

        static SanalDatabase()
        {
            musteriler = new List<Musteri>();
        }
    }
}
