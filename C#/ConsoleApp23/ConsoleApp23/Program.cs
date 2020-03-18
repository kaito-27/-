using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();
            Console.WriteLine(human.Name);
            Console.WriteLine(human.Age);
        }

        class Human
        {
            public string Name { get; set; } = "名無しの権兵衛";
            public int Age { get; set; } = 25;
        }
    }
}
