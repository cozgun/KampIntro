using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    class SalesManager
    {
        public void Sell(Customer customer, Kampanya kampanya)
        {
            Console.WriteLine("Kolofduyti oyunu " + customer.Name + " isimli müşteriye " + kampanya.KampanyaName + " kapsamında satılmıştır.");
        }
    }
}
