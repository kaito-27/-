using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human() { Name = "福田魁斗", Age = 22 };
            Console.WriteLine(human.Name);
            Console.WriteLine(human.Age);
        }

        class Human
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
