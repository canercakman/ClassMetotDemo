using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri kaydınız oluşturuldu : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Listele(Musteri musteri)
        {
           
            Console.WriteLine("Müşteri listelendi  :  " + musteri.Ad + " " + musteri.Soyad);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Kaydınız Silindi  :  " + musteri.Ad + "  " + musteri.Soyad);


        }
    }
}

       
    
        
