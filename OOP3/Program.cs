using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnasKrediManager = new EsnafKredi();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();

            // basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());  //18.satırla aynı görevi yapar.

            basvuruManager.BasvuruYap(esnasKrediManager, loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
