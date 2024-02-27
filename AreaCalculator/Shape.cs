using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract string AreaFormula();

        public virtual void PrintArea()
        {
            Console.WriteLine($"{AreaFormula()} {CalculateArea():0.00} m²");
        }




    }
}
