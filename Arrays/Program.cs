using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "1";
            students[1] = "2";
            students[2] = "3";

            string[] students2 = new string[3] { "4", "5", "6" };
            string[] students3 = { "7", "8", "9" };

            foreach (var item in students2)
            {
                Console.WriteLine(item);
            }

            string[,] regions = new string[5, 3]
            {
                { "İstanbul","Bursa","Yalova"},
                { "Ankara","Kırşehir","Nevşehir"},
                { "Antalya","Adana","Mersin"},
                { "Samsun","Ordu","Rize"},
                { "İzmir","Aydın","Muğla"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int x = 0; x <= regions.GetUpperBound(1); x++)
                {
                    Console.Write(regions[i,x]+",");
                }
                Console.WriteLine("");
                Console.WriteLine("----");
            }

            Console.ReadLine();
        }
    }
}
