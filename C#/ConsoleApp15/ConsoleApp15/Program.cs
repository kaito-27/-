using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = new List<string> { "ロシア", "カナダ", "アメリカ", "中国", "ブラジル" };

            var population = new Dictionary<string, int>()
            {
                {"中国", 1386390000 },
                {"インド", 1339180000},
                {"アメリカ", 325710000 },
                {"インドネシア", 263990000 },
                {"ブラジル", 209280000 }
            };

            foreach(string Key in population.Keys)
            {
                Console.WriteLine(Key);
            }
            foreach(int Value in population.Values)
            {
                Console.WriteLine(Value);
            }
            foreach(KeyValuePair<string, int> item in population)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
    }
}
