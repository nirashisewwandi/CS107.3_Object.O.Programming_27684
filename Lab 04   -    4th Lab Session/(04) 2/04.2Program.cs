using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class FindValues
    {
        public double findArea(double radius)
        {
            double pi = 3.14159;
            double area = pi * radius * radius;
            return area;
        }
        public double findCircumference(double radius)
        {
            double pi = 3.14159;
            double circumference = 2 * pi * radius;
            return circumference;
        }
    }
}
