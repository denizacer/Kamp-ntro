using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            Kurs kurs1= new Kurs();//klas değişkeni tanımladık
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();//klas değişkeni tanımladık
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem varış";
            kurs2.İzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();//klas değişkeni tanımladık
            kurs3.KursAdi = "phyton";
            kurs3.Egitmen = "berkay bilgin";
            kurs3.İzlenmeOranı = 80;

            //Console.WriteLine(kurs1.KursAdi +" "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };//class olduğu için string yerine kurs olarak tanımladık

            foreach (Kurs kurs in kurslar)//var kurs in kurslar
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.Egitmen);
                Console.WriteLine(kurs.İzlenmeOranı);

                Console.WriteLine(kurs.KursAdi +" "+kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int İzlenmeOranı { get; set; }
    }
}
