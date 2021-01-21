using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }//ref alanı forgeinkey//ıdleri  üste yaz kod okunuluğu iyi olur
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }//fiyatı
        public int UnitsInStock { get; set; }

        //CRUD- create,read, update,delete,
    }
    
        
}
