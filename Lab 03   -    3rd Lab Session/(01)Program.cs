﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string EvenOROdd = number % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine("The number is {0}.", EvenOROdd);
            Console.ReadKey();
        }
    }
}
