using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Gözde Ergin";
            customer1.CustomerAge = 22;
            customer1.CustomerSize = 68.5;
            customer1.CustomerId = 1;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Ahmet Arıkan";
            customer2.CustomerAge = 22;
            customer2.CustomerSize = 85;
            customer2.CustomerId = 2;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Berke Varol";
            customer3.CustomerAge = 22;
            customer3.CustomerSize = 80;
            customer3.CustomerId = 3;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerAge);
                Console.WriteLine(customer.CustomerSize);
                Console.WriteLine();
            }
        }
    }
}
