using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım geliştirici kampı", "programlamaya başlangıç eğitimi", "Diğer kurslar", "Yazılım geliştirici kampı", "programlamaya başlangıç eğitimi", "Diğer kurslar" };
            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
        }
    }
}
