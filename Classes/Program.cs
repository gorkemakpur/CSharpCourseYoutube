using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();
            productManager.Update();
            customerManager.Add();

            Customer customer = new Customer();
            customer.FirstName = "Test";
            customer.LastName = "Test-2";
            customer.City = "İstanbul";
            customer.ID = 1;

            Customer customer1 = new Customer
            {
                FirstName = "2-Test",
                LastName = "2-Test2",
                City = "Ankara",
                ID = 2
            };

            Console.WriteLine(customer.FirstName);

            Console.ReadLine();
        }
    }


}
