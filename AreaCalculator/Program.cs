namespace AreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area Calculator");
            Console.Write("Choose number from those numbers :\n 1: Square \n 2: Rectangle \n 3: Parallelogram \n 4: Triangle \n 5: Circle \n 6: Ellipse : ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------\n");           
            double a, b, c;
            if (n == 1 )
            {
                Rectangle rec = new Rectangle();
                Console.Write("Enter the length (l) : ");
                a = Convert.ToDouble(Console.ReadLine());
                rec.SetLengths(a, a);
                rec.PrintArea();
            }
            else if (n == 2)
            {
                Rectangle rec = new Rectangle();
                Console.Write("Enter the length (l) : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width (w) : ");
                b = Convert.ToDouble(Console.ReadLine());
                rec.SetLengths(a,b);
                rec.PrintArea();
            }
            else if(n == 3)
            {
                Parallelogram parallelogram = new Parallelogram();
                Console.Write("Enter the base (b) : ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height (h) : ");
                double h = Convert.ToDouble(Console.ReadLine());
                parallelogram.SetLengths(h,b);
                parallelogram.PrintArea();

            }
            else if (n == 4)
            {
                Triangle tri = new Triangle();
                Console.Write("Enter the Edge 1 (a): ");
                a = Convert.ToDouble(Console.ReadLine());           
                Console.Write("Enter the Edge 2 (b): ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the Edge 3 (c): ");
                c = Convert.ToDouble(Console.ReadLine());
                tri.SetLengths(a, b, c);
                tri.PrintArea();

            }
            else if (n == 5)
            {
                Circle circle = new Circle();
                Console.Write("Enter the radius (r) :");
                a = Convert.ToDouble(Console.ReadLine());
                circle.Radius = a;
                circle.PrintArea();

            }
            else if (n == 6)
            {
                Ellipse ellipse = new Ellipse();
                Console.Write("Enter the Semi-major Axes (a) :");
                a = Convert.ToDouble(Console.ReadLine());                
                Console.Write("Enter the Semi-minor Axes (b) :");
                b = Convert.ToDouble(Console.ReadLine());
                ellipse.Radius = b;
                ellipse.Radius2 = a;
                ellipse.PrintArea();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            Console.ReadKey();

        }
    }
    
}