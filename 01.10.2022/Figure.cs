using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._10._2022
{
    internal interface IFigure
    {
        string Name { get; set; }

        double GetArea();
        double GetPerimetr();
    }
}

