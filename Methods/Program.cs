using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //var result = Add2(3,5);
            //var resultClyinder = Cylinder(3,5);
            //Console.WriteLine(result);
            //Console.WriteLine(resultClyinder);

            //int number1 = 20;
            //int number2 = 70;
            //var result2 = Add3(ref number1, number2);//refte number1 set edilmesi gerek
            //var result3 = Add4(out number1, number2);//outta böyle bi zorunluluk yok
            //Console.WriteLine(result3);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(3,5));
            Console.WriteLine(Multiply(3,5,7));


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int a, int b)
        {
            return a + b;
        }
        static double Cylinder(double r, double h, double pi = 3.14)
        {
            return pi * (r * r) * h;
        }


        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;

        }

        static int Add4(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;

        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 *number3;
        }

        static int Add5(int number, params int[] numbers) //params ile toplu değer alıp diziye atama yapabiliriz
        {
            return numbers.Sum();
        }


    }
}
