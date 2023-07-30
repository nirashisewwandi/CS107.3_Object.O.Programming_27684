using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Class
    {
        static void Main(string[] args)
        {
            int no1, no2, choice;

            Console.WriteLine("Enter the first number: ");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What arithmetic operation would you like to perform?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            int answer;
            switch (choice)
            {
                case 1:
                    answer =  CalculateValues.Addition(no1, no2);
                    break;
                case 2:
                    answer = CalculateValues.Subtraction(no1, no2);
                    break;
                case 3:
                    answer = CalculateValues.Multiplication(no1, no2);
                    break;
                case 4:
                    answer = CalculateValues.Division(no1, no2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
            Console.WriteLine("The answer is: {}", answer);
            Console.ReadKey();
        }
    }
}
