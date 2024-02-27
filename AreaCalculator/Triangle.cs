using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    internal class Triangle : Shape
    {
        public double Edge1 { get; private set; }
        public double Edge2 { get; private set;}
        public double Edge3 { get; private set;}
        public void SetLengths(double a , double b , double c)
        {
            if(a<0 || b<0 || c < 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                throw new ArgumentException("Invalid input , input value can not be negative. ");
                
            }
            double temp;
            if (a > b)
            {
                temp = b;
                b = a;
                a = temp;
            }
            if (b > c)
            {
                temp = c;
                c = b;
                b = temp;
            }
            if ((a + b) > c)
            {
                Edge1 = a;
                Edge2 = b;
                Edge3 = c;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                 throw new ArgumentException("Invalid Approach: A triangle is valid if sum of its two sides is greater than the third side.");           
            }

        }

        public override double CalculateArea()
        {
            double s = (Edge1 + Edge2 + Edge3) / 2;
            return Math.Sqrt(s * (s - Edge1) * (s - Edge2) * (s - Edge3));
        }

        public override string AreaFormula()
        {
            return "Area =  √(s(s - a)(s - b)(s - c)) = ";
        }
        public override void PrintArea()
        {
            double s = (Edge1 + Edge2 + Edge3) / 2;
            Console.WriteLine($"s = (a + b + c)/2 = {s:0.00} m²");
            base.PrintArea();
        }

    }
}
