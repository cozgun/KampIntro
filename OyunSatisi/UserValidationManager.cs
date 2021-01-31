using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Customer customer)
        {
            if (customer.YearOfBirth == "1978")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
