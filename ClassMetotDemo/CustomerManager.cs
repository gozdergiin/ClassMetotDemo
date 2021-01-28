using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşterinin Adı= " + customer.CustomerName);
            Console.WriteLine("Müşterinin Yaşı= " + customer.CustomerAge);
            Console.WriteLine("Müşterinin Kilosu= " + customer.CustomerSize);
        }
        public void List(ref List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşterinin Adı= " + customer.CustomerName);
                Console.WriteLine("Müşterinin Yaşı= " + customer.CustomerAge);
                Console.WriteLine("Müşterinin Kilosu= " + customer.CustomerSize);
            }
            Console.ReadKey();
        }
        public void Delete(ref List<Customer> customers, ref int IdCounter)
        {
            IdCounter--;
            customers.RemoveAt(customers.Count - 1);
            Console.WriteLine("Müşteri silindi.");
        }
    }
}
