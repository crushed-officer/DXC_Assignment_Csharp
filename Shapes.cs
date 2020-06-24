using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentCsharp
{
    class Shapes
    {
        void calculateArea(float x)
        {
            Console.WriteLine("Area of the square: " + x * x);
        }
        void calculateArea(float x, float y)
        {
            Console.WriteLine("Area of the rectangle: " + x * y + " sq units");
        }
        void calculateArea(double r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area of the circle: " + area + " sq units");
        }
        public static void Main()
        {
            Shapes obj = new Shapes();
            obj.calculateArea(9.7f);
            obj.calculateArea(52, 86);
            obj.calculateArea(4.2);
        }
    }
}
