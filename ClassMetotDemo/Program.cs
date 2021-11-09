using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.Ad = "Caner";
            Musteri1.Soyad = "Çakman";
            Musteri1.Id = 35;

            Musteri Musteri2 = new Musteri();
            Musteri2.Ad = "Aytuğ";
            Musteri2.Soyad = "Yeşilyurt";
            Musteri2.Id = 61;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(Musteri1);
            musteriManager.Sil(Musteri1);
            musteriManager.Listele(Musteri1);

          

        }
    }
}
