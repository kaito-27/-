﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            var warriors = new List<Warrior>()
            {
                new Warrior("伊達政宗", 1567, 1636),
                new Warrior("織田信長", 1534, 1582),
                new Warrior("真田幸村", 1567, 1615),
                new Warrior("真田昌幸", 1547, 1611),
                new Warrior("上杉謙信", 1530, 1578),
                new Warrior("毛利元就", 1497, 1571),
                new Warrior("立花宗茂", 1567, 1643),
                new Warrior("島津義弘", 1535, 1619)
            };

            var newWarriors = warriors.Select(x => new { Name = x.Name, Age = x.Death - x.Birth }).OrderByDescending(x => x.Age);

            foreach(var warrior in newWarriors)
            {
                Console.WriteLine(warrior);
            }
        }
    }

    class Warrior
    {
        public string Name { get; set; }
        public int Birth { get; set; }
        public int Death { get; set; }

        public Warrior(string name, int birth, int death)
        {
            Name = name;
            Birth = birth;
            Death = death;
        }
    }
}
