using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Id + " ID numaralı müşteri eklendi.");
            Console.WriteLine(" ");
        }

        public void MusteriListeleme(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Müşteri ID : " + musteri.Id);
                Console.WriteLine("Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
                Console.WriteLine("******************");
                Console.WriteLine(" ");
            }
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Id + " ID numaralı müşteri silindi!");
            Console.WriteLine(" ");
        }
    }

}
