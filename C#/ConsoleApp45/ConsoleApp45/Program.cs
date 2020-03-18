using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            var characters = new List<Character>()
            {
                new Character("森嶋帆高", "男", 16, "天気の子"),
                new Character("天野陽菜", "女", 15, "天気の子"),
                new Character("天野凪", "男", 10, "天気の子"),
                new Character("レオ", "女", null, "さよならくちびる"),
                new Character("ハル", "女", null, "さよならくちびる"),
                new Character("シマ", "男", null, "さよならくちびる"),
                new Character("ミゲル・リヴェラ", "男", 12, "リメンバーミー"),
                new Character("ヘクター・リヴェラ", "男", 21, "リメンバーミー"),
                new Character("エルネスト・デラクルス", "男",  41, "リメンバーミー")
            };

            var workNames = characters.GroupBy(x => x.Workname);

            foreach(var group in workNames)
            {
                Console.Write(group.Key + ": ");
                foreach(var character in group)
                {
                    Console.Write(character.Name + " ");
                }
                Console.WriteLine();
            }

            var Genders = characters.GroupBy(x => x.Gender);
            
            foreach(var group in Genders)
            {
                Console.Write(group.Key + ": ");
                foreach(var character in group)
                {
                    Console.Write(character.Name + "(" + character.Age + ")");
                }
                Console.WriteLine();
            }
        }
    }

    class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string Workname { get; set; }

        public Character(string name, string gender, int? age, string workname)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Workname = workname;
        }
    }
}
