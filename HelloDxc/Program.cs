using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDxc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Dxc");
            Console.WriteLine("Write the first integer:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the second integer:");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the third integer:");
            int three = Convert.ToInt32(Console.ReadLine());
            int result = first * second;
            int results = first * three;
            Console.WriteLine($"The result is {result}");
            Console.WriteLine($"The result is {results}");
            Console.ReadKey();
        }
    }
}
