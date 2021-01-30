using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)   // Parametreyi vermem gerek metota
        {
            Console.WriteLine("Tebrikler...Sepete Eklendi :Urun bilgileri aşagıda listeledi\n"+ "ADI:"+urun.Adi+" AÇIKLAMASI:"+urun.Aciklama+" FİYATI:"+urun.Fiyati+" STOK:"+urun.StokAdedi+"\n");
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokadedi)  // Burda Program patlar Önermiyor
        {
            Console.WriteLine("Tebrikler...Sepete Eklendi : "+urunAdi+aciklama,fiyat,stokadedi);
        }

    }
}
