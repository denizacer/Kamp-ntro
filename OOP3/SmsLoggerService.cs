using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerService : IloggerService
    {
        public void log()
        {
            Console.WriteLine("Sms yollandı");
        }
    }
}
