using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "Hello World!";

            var length = sentence.Length;
            Console.WriteLine(length);

            var clone = sentence.Clone();
            sentence = "World Hello!";
            Console.WriteLine(clone);

            bool isEndsWith = sentence.EndsWith("!");
            Console.WriteLine(isEndsWith);
            bool isStartsWith = sentence.StartsWith("World");
            Console.WriteLine(isStartsWith);

            var indexOf = sentence.IndexOf("Hel");
            Console.WriteLine(indexOf);

            var lastIndexOf = sentence.LastIndexOf("Hel");
            Console.WriteLine(lastIndexOf);

            var insert = sentence.Insert(0, "English ");
            Console.WriteLine(insert);

            var substring = sentence.Substring(6);
            Console.WriteLine(substring);
            var substring2 = sentence.Substring(6, 5);
            Console.WriteLine(substring2);

            var toLower = sentence.ToLower();
            Console.WriteLine(toLower);
            var toUpper = sentence.ToUpper();
            Console.WriteLine(toUpper);

            var replace = sentence.Replace(" ", "-");
            Console.WriteLine(replace);

            var remove = sentence.Remove(0, 3);
            Console.WriteLine(remove);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";

            Console.WriteLine(city);
            Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.ReadLine();
        }
    }
}
