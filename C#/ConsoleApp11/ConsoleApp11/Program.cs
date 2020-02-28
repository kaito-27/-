using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteFoods = new List { "ラーメン", "ローストビーフ", "寿司" };
            for (int i = 0; i < favoriteFoods.Count; i++)
            {
                Console.WriteLine(favoriteFoods[i]);
            }
        }
    }
}
