using System;

namespace DegerveReferansTipler //Sektörde kıymetli değerli bir bilgi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10; // int deger tip "stack" te gerçekleşir
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
             
            int[] sayilar1 = new int[] { 10, 20, 30 }; // array referans tip heap de gerçekleşir. adresi atıyorsun aslında 
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0]=999;
            Console.WriteLine(sayilar1);

            Console.ReadLine();

        }
    }
}
