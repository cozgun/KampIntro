using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Özgün";
            musteri1.Soyadi = "Şenyuva";
            musteri1.TcNo = "11111111111";
            musteri1.ID = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Pamukkale LTD";
            musteri2.VergiNo = "2222222222";
            musteri2.ID = 2;

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();

        }
    }
}
