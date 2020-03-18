using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            var recipe = new Dictionary<string, int>
            {
                { "カレールウ", 70 },
                { "ごはん" , 300 },
                { "たまねぎ", 50 },
                { "にんじん" , 80 },
                { "じゃがいも", 50 }
            };

            var stock = new Dictionary<string, int>
            {
                { "カレールウ" , 180 },
                { "ごはん", 50000 },
                { "たまねぎ", 150 },
                { "鶏肉", 2 },
                { "にんじん" , 500},
                { "じゃがいも" , 900}
            };

            Console.WriteLine(CalculateHowManyDishes(recipe, stock));
        }

        static int CalculateHowManyDishes(Dictionary<string, int> recipe, Dictionary<string, int> stock)
        {
            foreach(var Key in recipe.Keys)
            {
                
            }
        }
    }
}
