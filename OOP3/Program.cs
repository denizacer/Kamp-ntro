using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();

            List<IloggerService> loggers = new List<IloggerService> { new SmsLoggerService(), new FileLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);
            //yukarıdaki gibi newleyi buraya nesneyi yazabilirsin// plymorfism
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            // listeden istediğini çoklu olarak hesaplatabilirsin tek tek değilde
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
