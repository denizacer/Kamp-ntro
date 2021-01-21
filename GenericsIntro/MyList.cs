using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//my listimde T ile çalışcam// arka plansda t string
    {
        T[] items;// klasın bütün operasyonları buna ulaşabilir
        //construcor
        public MyList()//otomatik çalışır
        {
            items = new T[0];
        }
        public void Add(T item) //T türünde bi item
        {
            T[] tempArray = items; //geçici array
            items = new T[items.Length+1];//dizimin eleman sayısını newleyerek bir attı
            //dinamik eleman arttı.
            for (int i = 0; i < tempArray.Length ; i++)
            {
                //temparrayi t ye atıcak
                items[i] = tempArray[i];
            }

            items[items.Length - 1]=item;
        }
    }
}
