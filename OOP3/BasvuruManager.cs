using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Method Injection
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendir.
            
            krediManager.Hesapla();
            //loggerService.Log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
                
        }

        public void KrediOnBilgilendirmesiYap(IList<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
