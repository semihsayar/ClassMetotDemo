using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
     class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklenmiştir : " + musteri.Id + ": " + musteri.Adi + " " + musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silinmiştir : " + musteri.Id + ": " + musteri.Adi + " " + musteri.Soyadi);
        }

        
        public  void Liste (Musteri musteri)
        {

            Console.WriteLine();
            
                Console.WriteLine("Müsteri ID:" + musteri.Id);
                Console.WriteLine("Müsteri Adi:" + musteri.Adi);
                Console.WriteLine("Müsteri Soyadi:" + musteri.Soyadi);
           }
    }
}
