using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 1; x <= 300; x++)
            {
                for(int y = 1; y <= 300; y++)
                {
                    for(int z = 1; z <= 300; z++)
                    {
                        if(Math.Pow(x, 4) + Math.Pow(y, 4) == Math.Pow(z, 4))
                        {
                            Console.WriteLine("成立してない");
                        }
                    }
                }
            }
        }
    }
}
