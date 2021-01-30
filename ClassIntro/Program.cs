using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs(); // Class ı Burda çagırdım
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 92;
            kurs1.Saat = DateTime.Now;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "PHP";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani =95;
            kurs2.Saat = DateTime.Now;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 85;
            kurs3.Saat = DateTime.Now;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Ali";
            kurs4.IzlenmeOrani = 100;
            kurs4.Saat = DateTime.Now;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 }; // Classtaki verileri diziler aracılığla çagırıp yazdırıabilirim
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kursun Adı : " + kurs.KursAdi);
                Console.WriteLine("Kursun Eğitmeni : " + kurs.Egitmen);
                Console.WriteLine("İzlenme Oranı : " + kurs.IzlenmeOrani);
                Console.WriteLine("İzlenme Zamanı : " + kurs.Saat);
                Console.WriteLine("-----------------");
               
            }


            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+kurs1.IzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi+" "+kurs2.Egitmen+" "+kurs2.IzlenmeOrani);
            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
        public DateTime Saat { get; set; }
    }


}
