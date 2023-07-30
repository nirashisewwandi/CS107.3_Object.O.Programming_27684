using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDog = new Dog();
            myDog.Animal();
            myDog.Dog();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
