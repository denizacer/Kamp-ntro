using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, List <IloggerService> loggerServices) 
        {
            //basvuran bilgilerini değerlendirme
            
            krediManager.Hesapla();// burda sadece bi tanesini hesaplıyot
            //loggerService.log();
            foreach (var loggerService in loggerServices)
            {
                loggerService.log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)//bana liste ver listenin türü ıkredi manager olsun
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();//listedeki her bir kredinin hesabını yap
            }
        }
    }
}
