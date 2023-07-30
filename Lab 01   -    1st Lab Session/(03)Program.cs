using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double no1, no2;
            Console.WriteLine("Enter the first number: ");
            no1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            no2 = double.Parse(Console.ReadLine());
            double Sum;
            Sum = no1 + no2;
            Console.WriteLine("Sum of two nmbers: " + Sum.ToString());
            Console.ReadLine();
        }
    }
}
