using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.Adi = "Ayakkabi";
            Urun1.Aciklama = "Giyim";
            Urun1.Fiyati = 68;

            Urun Urun2 = new Urun();
            Urun2.Adi = "Terlik";
            Urun2.Aciklama = "Giyim";
            Urun2.Fiyati = 20;

            Urun Urun3 = new Urun();
            Urun3.Adi = "Corap";
            Urun3.Aciklama = "Giyim";
            Urun3.Fiyati = 5;

            Urun[] urunler = new Urun[] { Urun1, Urun2, Urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }



        }
    }
}
