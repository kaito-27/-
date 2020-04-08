using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Derivative(x => Math.Sin(x) + Math.Cos(x), 1));
        }

        static double Derivative(Func<double, double> f, double a)
        {
            double h = 0.00001;
            return (f(a + h) - f(a)) / ((a + h) - a);
        }
    }
}
