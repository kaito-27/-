using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hiduke(null));
        }

        static string Hiduke(DateTime? d)
        {
            d = d ?? DateTime.Now;
            return d.ToString();
        }
    }
}
