using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Circle :Shape
    {
        private double radius;
        public double Radius 
        {
            get 
            {
                return radius;
            }
            set 
            {
                if (value < 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    throw new ArgumentException("Invalid input , input value can not be negative. ");
                }
                radius = value;
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string AreaFormula()
        {
            return "Area =  π x r² = ";
        }
    }
}
