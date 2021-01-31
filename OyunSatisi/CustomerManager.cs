using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisi
{
    class CustomerManager: IGamerService
    {
        IUserValidationService _userValidationService;
        public CustomerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Customer customer)
        {
            if (_userValidationService.Validate(customer) == true)
            {
                Console.WriteLine("Doğrulama Başarılı");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
