using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Time(200));
        }

        static TimeSpan Time(double distance, bool shinkansen = true)
        {
            if(distance < 100)
            {
                shinkansen = false;
            }

            double speed = 150;
            speed = shinkansen ? 150 : 50;
            return TimeSpan.FromHours(distance / speed);
        }
    }
}
