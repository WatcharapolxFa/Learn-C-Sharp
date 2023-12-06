using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            float b = 10.00f;
            int number = 1234567; 
            Console.WriteLine(" Hello World ! ");
            Console.WriteLine("Number = {0:E}", number);
            Console.WriteLine("Number = {0:G}",number);
            Console.WriteLine("Number = {0:N}", number);
            Console.WriteLine("Number = {0:x}", number);
            Console.ReadKey();
        }
    }
}
