using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend1
{
    internal class Class1
    {
    }
}

    abstract class Ishape
    {
        abstract public double calculateArea();
        abstract public double calculateperimeter();
    }


    class Circle : Ishape
    {

        public double radius { get; set; }
        public double area { get; set; }
        public static double PI = 3.14;
        public double perimeter { get; set; }
        public override double calculateArea()
        {
            area = PI * radius * radius;
            return area;
        }

        public override double calculateperimeter()
        {
            perimeter = 2 * radius * PI;
            return perimeter;
        }
    }

    class Rectangle : Ishape
    {
        public double perimeter { get; set; }
        public double area { get; set; }

        public double length { get; set; }
        public double width { get; set; }
        public override double calculateArea()
        {
            area = length * width;
            return area;
        }

        public override double calculateperimeter()
        {
            perimeter = 2 * (length * width);
            return perimeter;
        }
    }