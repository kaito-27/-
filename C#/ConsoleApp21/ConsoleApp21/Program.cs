using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();
            human.Name = "福田魁斗";
            Console.WriteLine(human.Name);
        }
    }

    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
