using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(10, 30, 0);
            TimeSpan t2 = new TimeSpan(21, 00, 15);
            TimeSpan t_t = t2 - t1;
            Console.WriteLine(t_t);
        }
    }
}
