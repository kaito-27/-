using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2, 48, 12, 5, 31, 19, 22, 32 };
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Average());
            Console.WriteLine(nums.Count());
        }
    }
}
