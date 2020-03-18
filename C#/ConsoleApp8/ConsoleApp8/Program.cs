using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPresident("遅越彰"));
        }
        
        static bool IsPresident(string name)
        {
            name = name.Trim();
            return name == "遅越彰" || name == "遅越 彰" || name == "遅越　彰";
        }

    }
}