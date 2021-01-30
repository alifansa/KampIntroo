using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 12;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 18;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Urunun Adı : "+urun.Adi);
                Console.WriteLine("Urunun Fiyatı : "+urun.Fiyati);
                Console.WriteLine("Urunun Açıklaması : "+urun.Aciklama);
                Console.WriteLine("Urun Stok Adedi : "+urun.StokAdedi);

                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------------Metotlar----------------"); // Buna iyi bak kafam zorlandı

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);            
            sepetManager.Ekle(urun2);

            Console.WriteLine("-----------Metotlar Ekle2 kısmı------------");

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 22,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 45,14);




            Console.ReadLine();
        }
    }
}


//Dont repeat yourself - DRY  - Clean Code - Besr Practice
