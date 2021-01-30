using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            // array - dizilerde tutarız

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlama başlangıç için temel kurs",
                "Java Geliştirici Yetiştirme Kampı",
                "C#","Python","C++","Php"};



            Console.WriteLine("For Döngüsü Başladı\n");
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\nFor Döngüsü Bitti");


            Console.WriteLine("---------------\n");
            Console.WriteLine("Foreach Döngüsü Başladı\n");
            foreach (string kurs in kurslar)  // Dizi Temelli yapıları Kurslar içerisindeki yapıları tek tek dolaşır..
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\nForeach Döngüsü Bitti..");
            Console.WriteLine("\nSayfa Sonu - footer");


            Console.ReadLine();
        }
    }
}
