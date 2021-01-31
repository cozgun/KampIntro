using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    interface IUserValidationService
    {
        bool Validate(Customer customer);
        
    }
}
