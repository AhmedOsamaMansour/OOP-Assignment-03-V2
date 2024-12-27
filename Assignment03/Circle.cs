using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_03_V2.Assignment03
{
    internal class Circle: ICircle
    {
        public double Radius { get; set; }

        double IShape.Area {get; set;}
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with Radius: {Radius}");
            Console.WriteLine("Area = " + Math.PI * Radius * Radius);
        }
    }
}
