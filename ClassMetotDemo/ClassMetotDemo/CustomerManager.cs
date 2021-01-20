using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {

            Console.WriteLine(customer.FirstName + " " +customer.LastName +" kişisi Eklendi" );
           
        }

        public void DeleteCustomer(Customer customer)
        {

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " kişisi Silindi");

        }

        public void ListCustomers(Customer [] customers)
        {
            foreach (var customer in customers)
            {

                Console.WriteLine("Müşteri Id  : " +customer.Id);
                Console.WriteLine("Müşteri Adı  : " +customer.FirstName);
                Console.WriteLine("Müşteri Soyadı  : " +customer.LastName);
                Console.WriteLine("Müşterinin Adresi  : " +customer.Address);
                Console.WriteLine("Müşterinin Bakiyesi  : " +customer.Balance + " TL ") ;
                Console.WriteLine();
                Console.WriteLine("------------------------");
                Console.WriteLine();
            }
        }
    }
}
