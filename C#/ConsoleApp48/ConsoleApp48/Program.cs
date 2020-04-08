using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class UserPoint
    {
        public DateTime GivenDate { get; set; }
        public DateTime ExpriedDate { get; set; }
        public int GivenPoint { get; set; }
        public int UsedPoint { get; set; }

        public UserPoint(DateTime givenDate, int givenPoint)
        {
            GivenDate = givenDate;
            ExpriedDate = new DateTime(givenDate.Year + 1);
            GivenPoint = givenPoint;
            UsedPoint = 0;
        }

        public bool EffectiveDate()
        {
            return ExpriedDate >= DateTime.Today;
        }

        public int EffectivePoints()
        {
            if (ExpriedDate <= DateTime.Today)
            {
                throw new Exception("有効期限切れ");
            }
            return GivenPoint - UsedPoint;
        }

        public int Use(int point)
        {
            if(EffectivePoints() >= point)
            {
                return 0;
            }
            else 
                return point - EffectivePoints();
            }

    }
}
