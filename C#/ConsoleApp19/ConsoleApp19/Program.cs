using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human();
            human.SetName("福田魁斗");
            human.SetAge(22);
            Console.WriteLine(human.GetName());
            Console.WriteLine(human.GetAge());
        }
    }

    class Human
    {
        private string name;
        private int age; 

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
