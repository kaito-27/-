using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kaibun("たしかにこのやおやのこにかした"));
        }

        static bool Kaibun(string str)
        {
            string inversionStr = new string(str.Reverse().ToArray());
            return str == inversionStr;
        }
    }
}
