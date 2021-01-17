using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla eklendi.. : " + musteri.Adi, musteri.Soyadi);
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi.. : " + musteri.Adi, musteri.Soyadi);
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteriler Listelendi.. : " + musteri.Adi, musteri.Soyadi);
        }
    }
}
