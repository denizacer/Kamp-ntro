using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yeyiştirme Kampı";
            string kurs2 = "Programalaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Phyton";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //array-dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yeyiştirme Kampı", "Programalaya başlangıç için temel kurs", "Java", "Phyton","C#" };

           

            for (int i = 0; i < kurslar.Length; i++)//kurslar.Length ile dinamik oldu
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)//dizi temelliyspıları tek tek dönmeye yarıyor
            {
                //kurslar ı dolaş demek //kurs yazan yere istedğini yaz
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu= footer");

        }
    }
}
