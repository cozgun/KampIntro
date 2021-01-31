using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    interface IGamerService
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
