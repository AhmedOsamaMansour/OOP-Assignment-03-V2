using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_03_V2.Assignment03
{
    internal interface IShape
    {
        double Area { get; set; } // default public
        void DisplayShapeInfo();
    }
}
