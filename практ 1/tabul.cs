using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практ_1
{
    internal class tabul
    {
        public double[,] xy = new double[1000, 2];

        public int n = 0;

        private double f1(double x)
        {
            double numerator = 2 * x + 5;
            double denominator = Math.Pow(x, 3) + 2;
            double result = Math.Pow(numerator / denominator, 1.0 / 3.0);

            return result;
        }
        private double f2(double x)
        {
            double numerator = Math.Sqrt(Math.Sin(x * x + 3) + 4);
            double denominator = x * x + 2;
            double result = numerator / denominator;

            return result;
        }

        private double f3(double x)
        {
            double result = Math.Pow(Math.Sin(x + 2), 3) / Math.Log(x * x + 3 * x + 1);


            return result;
        }


        public void tab(double xn = 2.1, double xk = 16.5, double h = 0.2, double a = 0.8)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x < 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x >= 0) && (x < a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy[i, 0] = x;
                xy[i, 1] = y;
                x = x + h;
                i++;
            }
            n = i;
        }

    }
}
