using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            var robert = new List<string> { "秋山", "馬場", "山本" };
            var dachou = new List<string> { "肥後", "寺門", "上島" };
            var neptune = new List<string> { "名倉", "堀内", "原田" };
            var yasuda = new List<string> {"クロちゃん", "安田", "HIRO"};

            var group = new Dictionary<string, List<string>>();
            group["ロバート"] = robert;
            group["ダチョウ倶楽部"] = dachou;
            group["ネプチューン"] = neptune;
            group["安田大サーカス"] = yasuda;

            Console.WriteLine(group["ネプチューン"]);
            
        }
    }
}
