﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userInputs = new int[10];

            for (int i = 0; i < userInputs.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                userInputs[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < userInputs.Length; i++)
            {
                if (userInputs[i] % 2 == 0)
                {
                    Console.WriteLine("The number {} is even.", userInputs[i]);
                }
                else
                {
                    Console.WriteLine("The number {} is odd.", userInputs[i]);
                }
                Console.ReadKey();
            }
    }
}
