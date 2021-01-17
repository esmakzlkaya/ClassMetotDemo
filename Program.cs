using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Esma";
            musteri1.Soyadi = "Kızılkaya";
            musteri1.Telefon = "11111111111";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ali";
            musteri2.Soyadi = "Veli";
            musteri2.Telefon = "22222222222";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Zeynep";
            musteri3.Soyadi = "Demir";
            musteri3.Telefon = "33333333333";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListele(musteri1, musteri2,musteri3);

            musteriManager.MusteriEkle(musteri3,musteri1,musteri2);

            musteriManager.MusteriSil(musteri2,musteri1,musteri3);
        }
    }
}
