using System;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;
            int c = 50;
            int d= 50;
            int sonuc = Topla(a, b);
            int sonuc_ref = ToplaRef(ref a, ref b);
            int sonuc_out = ToplaOut(out c, out d);
            sonuc = Topla(a, b);

            Console.WriteLine("Toplam: " + sonuc );
            Console.WriteLine("Toplam-ref: " + sonuc_ref);
            Console.WriteLine("Toplam-out: " + sonuc_out);
            Console.WriteLine("Fonksiyona girdikten sonra değerler : " + a + " ______ " + b);
            Console.WriteLine("Ref fonksiyondan sonra şimdi tekrar orjinal fonksiyonu tekrar çağırıyorum.");
            Console.WriteLine("Toplam: " + sonuc);
            Console.WriteLine("a ve b nin değerleri artık bunlar oldu.  1 ve 2 uçtu:   " + a + " ______ " + b);
            Console.WriteLine("c ve d nin değerleri:   " + c + " ______ " + d);
        }
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int ToplaRef(ref int sayi1, ref int sayi2)
        {
            //sayi1 = 10;
            //sayi2 = 20;
            return sayi1 + sayi2;
        }
        static int ToplaOut(out int sayi1, out int sayi2)
        {
            sayi1 = 100;
            sayi2 = 200;
            return sayi1 + sayi2;
        }

    }
}
