using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Parallelogram :Shape
    {
        public double Base { get; private set; }
        public double Height { get; private set; }
        public void SetLengths(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                throw new ArgumentException("Invalid input , input value can not be negative. ");             
            }
            Base = a;
            Height = b;
        }
        public override double CalculateArea()
        {
            return Base * Height;
        }

        public override string AreaFormula()
        {
            return "Area = b × h =  ";
        }
    }
}
