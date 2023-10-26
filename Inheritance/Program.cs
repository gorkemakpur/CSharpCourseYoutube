using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Test";
            customer.Surname = "Test";
            customer.ID = 1;
            customer.City= "Test";

            Person[] persons = new Person[3]
            {
                new Customer()
                {
                    Name = "TestCustomer",
                },

                new Student{
                    Name = "TestStudent",
                },
                
                new Person
                {
                    Name= "TestPerson",   
                }
            };
            foreach (var item in persons)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }


    class Person2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }


    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
