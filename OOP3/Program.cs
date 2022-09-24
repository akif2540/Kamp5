using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TaşıtKrediManager();     // burada clasların başına IKrediManger da yazabiliriz. demekki interfaclerde referans numarasını tutabilir

            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerServices = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, smsLoggerServices };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,new List<ILoggerService> { databaseLoggerService}); // burda esnaf kredisinden sonraki,den sonra sadece loggers yazabilirdik
            Console.WriteLine("-----------------------");

            List<IKrediManager> kredilerr = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager,konutKrediManager};

           basvuruManager.KrediOnBilgilendirmesiYap(kredilerr);
            Console.WriteLine("ıpatallll etttik üsteki satırı");

        }
    }
}
