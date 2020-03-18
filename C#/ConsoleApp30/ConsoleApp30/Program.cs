using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new TimeSpan(17, 0, 0);
            var t2 = new TimeSpan(19, 0, 0);
            var t3 = new TimeSpan(18, 0, 0);
            var t4 = new TimeSpan(20, 0, 0);
            Console.WriteLine(Calculation(t1, t2, t3, t4));
        }

        static TimeSpan Calculation(TimeSpan t1, TimeSpan t2, TimeSpan t3, TimeSpan t4)
        {
            if(t4 <= t1 || t2 <= t3)
            {
                return TimeSpan.Zero;
            }
            else
            {
                return t2 - t3;
            }
        }
    }
}
