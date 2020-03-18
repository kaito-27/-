using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            var limited = new LimitedList<int>(50);
            for(int i = 0; i < 100; i++)
            {
                limited.Add(i);
            }
            Console.WriteLine(limited.Get(0));
        }
    }

    class LimitedList<T>
    {
        private List<T> list;
        private int maxCount = 0;

        public LimitedList (int maxCount)
        {
            list = new List<T>();
            this.maxCount = maxCount;
        }

        public void Add(T element)
        {
            list.Add(element);
            if(list.Count > maxCount)
            {
                list.RemoveAt(0);
            }
        }

        public T Get(int i)
        {
            return list[i];
        }
    }
}