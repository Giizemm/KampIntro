using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] {"yazılım Geliştirici Kampı", "Programlamaya başlangıç için temel kurs","Java","Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
