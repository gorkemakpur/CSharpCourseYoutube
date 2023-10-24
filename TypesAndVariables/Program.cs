using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            double number5 = 10.30;
            decimal number6 = 100.497777m;
            char character = 'a';
            bool condition = true;
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;

            var number7 = 10;//ilk atama neyse onu kabul eder
            number7 = 'A';   //burada char tanımladığımızda onun değerini alır

            if (Days.Tuesday.ToString() == DateTime.Now.DayOfWeek.ToString())
            {
                Console.WriteLine("Salı Günündesiniz");
            }
            Console.WriteLine(number1);
            Console.WriteLine("Number 1 is : {0}", number1);
            Console.WriteLine("Number 2 is : {0}", number2);
            Console.WriteLine("Number 3 is : {0}", number3);
            Console.WriteLine("Number 4 is : {0}", number4);
            Console.WriteLine("Number 5 is : {0}", number5);
            Console.WriteLine("Number6 is : {0}", number6);
            Console.WriteLine("condition is : {0}", condition);
            Console.WriteLine("character is : {0}", character);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);

            Console.ReadLine();
        }
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
