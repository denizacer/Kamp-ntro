using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //operasyon tutuyor managerler
        public void Ekle(Urun urun)//parametre aldu urun öylesine ad
        {
            Console.WriteLine("Tebrikler.Sepeten eklendi: " +  urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler.Sepeten eklendi: " + urunAdi);
        }
    }
}
