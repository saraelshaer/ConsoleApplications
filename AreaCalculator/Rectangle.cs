using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Rectangle :Shape
    {
        public double Length { get; private set; }
        public double Width { get; private set; }
        public void SetLengths(double a, double b )
        {
            if (a < 0 || b < 0 )
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                throw new ArgumentException("Invalid input , input value can not be negative. ");
               


            }
            Length = a;
            Width = b;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        public override string AreaFormula()
        {
            if( Length == Width ) return "Area = l × l = ";
            return "Area = l × w = ";
        }
    }
}
