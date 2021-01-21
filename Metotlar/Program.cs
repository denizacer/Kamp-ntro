using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();//klasdan değişken tanımladık
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Diyarbakır kapuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                //in ürünler demek ürünler dizini gez
                //urun->takma isim, Urun->veri tipi var yazsanda olur
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");

            }

            Console.WriteLine("-----------Metotlar-------------");

            //instance->klas örneği oluşruema
            //encapsulation->kapsülleme aşağıdaki ürünleri düzenli yapmaya deniyor ekle2 gibi
            
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);//sepet managerde fondiyon içinde imza vardı bunun içinide doldurman lazım nesnlerin ile

            sepetManager.Ekle2("Armut","yeşil armut", 12,10);
            sepetManager.Ekle2("elma", "yeşil elma", 12, 9);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 12,8);



        }
    }
}
///metotlar tekrar tekrar kullanmayı sağlyor