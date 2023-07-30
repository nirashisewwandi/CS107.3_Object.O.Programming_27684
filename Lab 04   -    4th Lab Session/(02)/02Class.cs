using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var converter = new ConvertValues();

            Console.Write("Enter the value in kilometers (km): ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            converter.KilometerToMeter(kilometers);

            Console.ReadLine();
        }
    }
}
