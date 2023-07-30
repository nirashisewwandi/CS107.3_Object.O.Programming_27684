using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee's salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tax rate: ");
            double taxRate = double.Parse(Console.ReadLine());
            double salaryTax = salary - (salary * taxRate);
            Console.WriteLine("The salary after tax is {}.", salaryTax);
            Console.ReadLine();
        }
    }
}
