using System;

namespace OyunSatisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { ID = 1, Name = "Ozgun", LastName = "Senyurt", City = "İstanbul", YearOfBirth = "1978", Tckn = "1111111111" };
            Customer customer2 = new Customer { ID = 2, Name = "Pınar", LastName = "Senyurt", City = "İstanbul", YearOfBirth = "1979", Tckn = "2222222222" };
            CustomerManager customerManager = new CustomerManager(new UserValidationManager());
            customerManager.Add(customer1);

            Kampanya kampanya1 = new Kampanya { KampanyaId = 1, KampanyaName = "Öğrenci Kampanyası" };
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.Add(kampanya1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sell(customer2, kampanya1);

        }
    }
}
