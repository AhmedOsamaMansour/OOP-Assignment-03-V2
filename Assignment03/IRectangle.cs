using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_03_V2.Assignment03
{
    internal interface IRectangle:IShape
    {       
        double Width { get; set; }
        double Height { get; set; }
    }
}
