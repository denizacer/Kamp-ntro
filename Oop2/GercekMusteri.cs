using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{//indivual
    class GercekMusteri:Musteri
    {
        //gerçek müş. bir müşteridir
        //inheritance,0müşteriden miras aldı
        
        public string TcNo { get; set; }//bir veri üstünde matematiksel işlem yoksa string yapabilirsin
        public string Adi { get; set; }
        public string Soyadi { get; set; }
       
    }
}
