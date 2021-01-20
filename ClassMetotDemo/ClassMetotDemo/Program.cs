using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ahmet Hakan ";
            customer1.LastName = "Yıldırım";
            customer1.Address = "Elazığ";
            customer1.Balance = 1350;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Talha  ";
            customer2.LastName = "Yıldırım";
            customer2.Address = "Elazığ";
            customer2.Balance = 16000;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Berkay  ";
            customer3.LastName = "Çavuşoğlu";
            customer3.Address = "Elazığ";
            customer3.Balance = 500;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Şükrü  ";
            customer4.LastName = "Özkoca";
            customer4.Address = "Çorum";
            customer4.Balance = 100000;

            Customer customer5 = new Customer();
            customer5.Id = 4;
            customer5.FirstName = "Mehmet ";
            customer5.LastName = "Uysal";
            customer5.Address = "Konya";
            customer5.Balance = 100000;

            Customer customer6 = new Customer();
            customer6.Id = 4;
            customer6.FirstName = "Can  ";
            customer6.LastName = "Gümüş";
            customer6.Address = "Hatay";
            customer6.Balance = 100000;


            Customer[] customers = { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            Console.WriteLine("**************");
            customerManager.DeleteCustomer(customer4);
            Console.WriteLine("----------------------------");
            customerManager.ListCustomers(customers);

            Console.ReadKey();
        }
    }
}
