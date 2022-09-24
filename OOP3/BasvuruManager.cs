using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager ,List <ILoggerService> loggerServices)
        {
            // başvuru bilgileri değerlendirme
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }                             // burda müşteri hangi krediyi seçerse o kredi çalışır.

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
