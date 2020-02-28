using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program IM = new Program();
            IM.IntroduceMyself("福田魁斗", 21, false);
            
        }

        public void IntroduceMyself(string name, int age, bool livingAtHome)
        {
            Console.WriteLine("名前は" + name + "です。");
            Console.WriteLine("年齢は" + age + "です。");
            Console.WriteLine(livingAtHome);
        }
    }
}
