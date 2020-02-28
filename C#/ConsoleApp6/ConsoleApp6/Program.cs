using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i + " アホ");
                }
                else if (i.ToString().Contains("3"))
                {
                    Console.WriteLine(i + " アホ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
