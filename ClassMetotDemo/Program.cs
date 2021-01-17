using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Enes";
            musteri1.Soyad = "GEDİK";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Muhammet Raşit";
            musteri2.Soyad = "ALIMCI";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ahmet";
            musteri3.Soyad = "ALIMCI";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);

            musteriManager.MusteriListeleme(musteriler);

            musteriManager.MusteriSilme(musteri3);
           
        }
    }
}
