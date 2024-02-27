using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Ellipse : Circle
    {
        private double radius2;
        public double Radius2
        {
            get
            {
                return radius2;
            }
            set
            {
                if (value < 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    throw new ArgumentException("Invalid input , input value can not be negative. ");

                }
                radius2 = value;
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius2;
        }

        public override string AreaFormula()
        {
            return "Area =  π x a x b = ";
        }
    }
}
