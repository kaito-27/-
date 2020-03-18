using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>()
            {
                { "1", "フシギダネ" },
                { "2", "フシギソウ" },
            };
            dict.GetOrDefault(3);              // null
            dict.GetOrDefault(3, "フシギバナ");
        }
    }
    
    static class DictionaryExtention
    {
        public static TValue GetOrDefault<TKey, TValue>(
        this Dictionary<TKey, TValue> self,
        TKey key,
        TValue defaultValue = default(TValue))
        {
            TValue value;
            return self.TryGetValue(key, out value) ? value : defaultValue;
        }
    }
}
