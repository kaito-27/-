using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Open("水", "夜間"));
        }

        static bool Open(string week, string time)
        {
            if (week == "月")
            {
                if (time == "午前" || time == "午後")
                {
                    return true;
                }
            }

            else if (week == "火")
            {
                return true;
            }

            else if (week == "水")
            {
                if (time == "夜間")
                {
                    return true;
                }
             }

            else if (week == "木")
            {
                return true;
            }

            else if (week == "金")
            {
                if (time == "午後" || time == "夜間")
                {
                    return true;
                }
            }

            else if (week == "土")
            {
                if (time == "午後")
                {
                    return true;
                }
            }
            return false;
            
            
        }
    }
}
