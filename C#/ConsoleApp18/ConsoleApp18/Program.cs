using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Number(654));
        }

        static int Number(int n)
        {
            int repeat = 0;

            while(n > 1)
            {
                if(n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n *= 3;
                    n += 1;
                }
                repeat++;
            }
            return repeat;
        }
    }
}
