using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your batch");
            string batch = Console.ReadLine();

            Console.WriteLine("Your name is {} and your batch is {}.", name, batch);
            Console.ReadLine();
        }
    }
}
