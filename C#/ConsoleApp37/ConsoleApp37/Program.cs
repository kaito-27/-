using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() { 2, 48, 12, 5, 31, 19, 22, 32 };
            var whereNums = nums.Where(x => x >= 25);
            Console.WriteLine(string.Join(" ", whereNums));
        }
    }
}
