using System;

namespace OOP3
{
    class FileLoggerService : IloggerService//dosyaya loglandı
    {
        //FileLoggerService bunda çıkan ampule bastım ilk çıkana tıklayınca class oluştu şablon oluştu

        public void log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
