using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() { 2, 48, 12, 5, 31, 19, 22, 32 };
            var allNums = nums.All(x => x <= 100);
            Console.WriteLine(string.Join(" ", allNums));

            var anyNums = nums.Any(x => x >= 30);
            Console.WriteLine(string.Join(" ", anyNums));

            var containsNums = nums.Contains(19);
            Console.WriteLine(string.Join(" ", containsNums));

        }
    }
}
