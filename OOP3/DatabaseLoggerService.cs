using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : IloggerService//dbye loglandı
    {
        public void log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
