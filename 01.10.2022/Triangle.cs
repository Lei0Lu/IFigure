using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._10._2022
{
    internal class Triangle : IFigure
    {
        public string Name { get; set; }
        public double side1 { get; set; }
        public double side2 { get; set; }

        public double hypotenuse { get; set; }
        public double GetArea()
        {
            Console.WriteLine("Triangle");
            return ((1/2)* side1* side2);
        }
        public double GetPerimetr()
        {
            return side1+ side2+ hypotenuse;
        }

    }
}
