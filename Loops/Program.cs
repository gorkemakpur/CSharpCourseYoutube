using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int index = 1;
            //string[] students = new string[4] { "First", "Second", "Third", "Fourth" };
            //OneToHundred();
            //OneToHundredOdd();
            //OneToHundredWhile(index);
            //OneToHundredDoWhile(index);
            //Foreach(students);
            while (true) { 
            Console.WriteLine("Sayı giriniz");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrimeNumber(number))
            {
                Console.WriteLine("{0} -> This is a Prime Number",number);
            }
            else
            {
                Console.WriteLine("{0} -> This is not a prime number", number);
            }
            Console.WriteLine("Finished!");
            Console.ReadLine();
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static void Foreach(string[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static int OneToHundredDoWhile(int index)
        {
            do
            {
                Console.WriteLine(index);
                index++;
            }
            while (index < 101);
            return index;
        }

        private static int OneToHundredWhile(int index)
        {
            while (index < 101)
            {
                Console.WriteLine(index);
                index++;
            }

            return index;
        }

        private static void OneToHundredOdd()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        private static void OneToHundred()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
