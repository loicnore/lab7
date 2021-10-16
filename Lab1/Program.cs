using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        class A
        {
            protected double[] x;
            public double[] Linear(double a, double b)
            {
                if(a==0)
                {
                    return null;
                }
                return x = new double[] { -b / a };
            }
        }
        class B : A
        {

            protected double Discriminant(double a,double b, double c)
            {
                return Math.Pow(b, 2) - 4 * a * c;
            }
            
            public double[] Solution(double a, double b, double c)
            {
                if (a == 0)
                {
                    return Linear(a, b);
                }
                double d = Discriminant(a, b, c);

                if (d < 0)
                {
                    return null;
                }
                if (d == 0)
                {
                    double[] dis1 = new double[1];
                    dis1[0] = -b/(2 * a);
                    return dis1;
                }

                d = Math.Sqrt(d);
                double[] dis2 = new double[2];
                dis2[0] = (-b + d) / (2 * a);
                dis2[1] = (-b - d) / (2 * a);
                return dis2;
            }
        }


        static void Main(string[] args)
        {

        }
    }
}
