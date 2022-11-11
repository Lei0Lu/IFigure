using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01._10._2022
{
   public class Rectangle : IFigure
    {


        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            Console.WriteLine("Rectangle");
            return (Height * Width);
        }
        public double GetPerimetr()
        {
            return 2 * (Height * Width);
        }

    }
}
