using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        ///Müşteri Listeleme

        public void MusteriListele(params Musteri[] musteriler)
        {
            Console.WriteLine("Sisteme kayıtlı kişilerin listesi şu şekildedir : \n");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.Adi + " - " + musteri.Soyadi + " - " + musteri.Telefon);
            }
            Console.WriteLine("\n------------------\n");

        }

        ///Müşteri Ekle
        
        public void MusteriEkle(params Musteri[] musteriler) 
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Yeni kişi ' " + musteri.Adi+" "+musteri.Soyadi+" ' başarıyla eklenmiştir.");
            }
            Console.WriteLine("\n------------------\n");
        }

        ///Müşteri Silme
        
        public void MusteriSil(params Musteri[] musteriler)
        {
            foreach (var silinecekMusteri in musteriler)
            {
                Console.WriteLine(silinecekMusteri.Id+" ID nolu müşteri başarıyla silinmiştir.");
            }
        }
    }
}
