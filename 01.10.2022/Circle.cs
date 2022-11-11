using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._10._2022
{
    internal class Circle : IFigure
    {
        public string Name { get; set; }
        public double Radius { get; set; }

        public double GetArea()
        {
            Console.WriteLine("Circle");
            return (Math.PI * Math.Pow(Radius, 2));
        }
        public double GetPerimetr()
        {
            return (Math.PI * (Radius * 2));
        }
       

    }
}
