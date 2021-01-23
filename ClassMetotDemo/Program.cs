using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri Must1 = new Musteri();
            Must1.Name = "Osman";
            Must1.Surname = "Bey";
            Must1.Segment = "Kalantor";

            Musteri Must2 = new Musteri();
            Must2.Name = "Nermin";
            Must2.Surname = "Hanim";
            Must2.Segment = "Kalantor";

            Musteri Must3 = new Musteri();
            Must3.Name = "Mert";
            Must3.Surname = "Çocuk";
            Must3.Segment = "Apaci";

            Musteri[] Musteriler = new Musteri[] { Must1, Must2, Must3 };

            foreach (var Must in Musteriler)
            {
                Console.WriteLine(Must.Name);
                Console.WriteLine(Must.Surname);
                Console.WriteLine(Must.Segment);
                Console.WriteLine("------------");

            }

            Console.WriteLine("------Metodlar------");
            //aşağıda instance oluşturuyoruz
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Musteri_ekle(Must1);
            musteriManager.Musteri_ekle(Must2);
            musteriManager.Musteri_ekle(Must3);



            //Console.WriteLine("Hello World!");
        }
    }
}
