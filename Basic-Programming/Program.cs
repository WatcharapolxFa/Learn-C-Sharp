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
            double weight, hight;
            Console.WriteLine("   BMI  ");
            Console.Write("Please enter your weight : ");
            double.TryParse(Console.ReadLine(), out weight);
            Console.Write("Please enter your hight : ");
            double.TryParse(Console.ReadLine(), out hight);
            double bmi = weight / hight * hight;
            Console.WriteLine("BMI = {0}",bmi);
            Console.ReadKey();
        }
    }
}
