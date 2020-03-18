using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>()
            {
                "animation",
                "civilization",
                "occupation",
                "normalization",
                "extention",
                "activation",
                "calculation",
                "linearization"
            };

            var newWords = words.Where(x => x.Length >= 10).Select(x => x.First().ToString() + (x.Length - 2) + x.Last().ToString());
            Console.WriteLine(string.Join(" ", newWords));
        }
    }
}
