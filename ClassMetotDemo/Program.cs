using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Kerim";
            musteri1.Soyadi = "Uğur";
            musteri1.TC = 40450198697;
            musteri1.Bakiye = 1500;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mustafa";
            musteri2.Soyadi = "Eşit";
            musteri2.TC = 98599652385;
            musteri2.Bakiye = 1056500;


            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Aykut";
            musteri3.Soyadi = "Yavuz";
            musteri3.TC = 78965413245;
            musteri3.Bakiye = 999999;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.TC);
                Console.WriteLine(musteri.Bakiye);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("--------Metotlar-----------");

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriEkle(musteri2);
            musterimanager.MusteriEkle(musteri3);
            Console.WriteLine("-------------------------");

            musterimanager.MusteriSil(musteri1);
            musterimanager.MusteriSil(musteri2);
            musterimanager.MusteriSil(musteri3);

            Musteri[] musterilerListe = new Musteri[] {musteri1, musteri2, musteri3 };
            Console.WriteLine("----------Müşteri Listesi..----------");

            foreach (Musteri musteril in musterilerListe)
            {
                Console.WriteLine(musteril.Adi + " " + musteril.Soyadi);
                

            }




            


            



            
        }
    }
}
