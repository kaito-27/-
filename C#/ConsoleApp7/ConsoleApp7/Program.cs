using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetTemperature(26.0, -1.0));
        }

        static string GetTemperature(double high, double low)
        {
            if(high <= 0)
            {
                return ("真冬日");
            }
            else if(high >= 35)
            {
                return ("猛暑日");
            }
            else if(high >= 30)
            {
                return ("真夏日");
            }
            else if(high >= 25)
            {
                return ("夏日");
            }
            if(low <= 0)
            {
                return ("冬日");
            }
            return null;
        }
    }
}
