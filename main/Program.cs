using System;
using static System.Console;

namespace main
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal pi = 3.141592653589793238462643383279M;
            decimal s;
            decimal h;
            int x0;
            int x1;
            int x2;
            int r;
            int a;
            int b;
            int c;
            
            WriteLine("Please enter a radius of a sphere");
            r = Convert.ToInt16(ReadLine());
            WriteLine(Sphere(r));

            decimal Sphere(decimal r)
            {
                decimal v;
                v = (4*pi*(r*r*r))/3;
                return v;
            }

            WriteLine("Please enter the edge length of the bottom of the pyramid");
            s = Convert.ToDecimal(ReadLine());
            WriteLine("Now enter the height of the pyramid");
            h = Convert.ToDecimal(ReadLine());
            WriteLine(Pyramid(s,h));

            WriteLine("Enter an equation");
            //F(equation)
            WriteLine("Enter a point");
            //F(x)
            WriteLine("The slope at that point is {}");
            //slope

            decimal Pyramid(decimal s, decimal h)
            {
                decimal v;
                v = (s*s)*(h/3);
                return v;
            }

            string Slope()
            {
                return null;
            }
            
            string Quadratic()
            {
                if (false)//imaginary
                {
                    return null;
                }
                return null;
            }

            decimal Zeros()
            {
                return 5;
            }

            decimal Riemann(int a, int b, int n, int c)
            {
                return 5;
            }

            void F(int x3, int n3, int x2, int n2, int x1, int n1, int c)
            {
                
            }
        }
    }
}
