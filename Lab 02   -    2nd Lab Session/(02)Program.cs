using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int no2 = Convert.ToInt32(Console.ReadLine());

            int sum = no1 + no2;
            int sub = no1 - no2;
            int multip = no1 * no2;
            float divi = no1 / no2;

            Console.WriteLine("The sum of the two numbers is: {0}", sum);
            Console.WriteLine("The subtraction of the two numbers is: {0}", sub);
            Console.WriteLine("The multiplication of the two numbers is: {0}", multip);
            Console.WriteLine("The divition of the two numbers is: {0}", divi);
            Console.ReadKey();
        }
    }
}
