﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
     class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MysqlCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, Name = "Aziz", Surname = "ss", Address = "aa" });

            Student student = new Student { Id = 1, Name = "Aziz", Surname = "ss", Departmant = "aa" };

            Worker worker = new Worker { Id = 1, Name = "Aziz", Surname = "ss", Departmant = "aa" };

            personManager.Add(worker);
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
    }
 
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Departmant {  get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Departmant { get; set; }
    }



    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }
    }


}
