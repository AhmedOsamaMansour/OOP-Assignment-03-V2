using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_03_V2.Assignment03
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        double IShape.Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with Width: {Width}, Height: {Height}");
            Console.WriteLine("Area = " + (this.Width * Height));
        }
    }
}
