using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler :) Sepete Eklendi :"+ product.Name);
        }

        public void Add2(string productName,string detail,double price,int stokAdedi)
        {
            Console.WriteLine("Tebrikler :) Sepete Eklendi :" + productName);
        }
    }
}
