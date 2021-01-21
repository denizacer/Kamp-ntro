using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin","Murat","Kerem","Halil"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];//0 1 2 3 4 boş
            //isimler[4] = "İlker";//new dediğinde yeni array boşluk oluştu
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);//ctrl+k ++ ctrl+ccommoent
            //uncoment ctrl+k ++ ctrl+u geri alma

            List<string> isimler2 = new List<string> {"Engin", "Murat", "Kerem", "Halil" };
            //listi ampule tıkladım aktif ettiim 
            //isimler2.Add(""); //liste eleman eklemek için

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            

        }
    }
}
