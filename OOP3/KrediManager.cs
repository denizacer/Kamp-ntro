using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager//interface olduğunu anlatmak için I harfi ile başlatırız
    {
        //interfaceleri birbirinin alternatifi oolan kodlar için kull.
        //loglama sms olarak tutabilirsin,db ye atabilirsin, dosyaya yazabilirsin
         void Hesapla();
        //ebeveyn class//base klas//
        void BiseyYap();
        
    }
}
