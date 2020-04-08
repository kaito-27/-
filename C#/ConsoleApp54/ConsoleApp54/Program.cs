using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"条件を満たす日数は{CountIf(weathers, DailyDifference)}日です。");
        }
        
        static double DailyDifference(Weather w)
        {
            return w.HighestTemperature - w.LowestTemperature;
        }

        static int CountIf(List<Weather> weather, Func<Weather, double> func)
        {
            int count = 0;
            foreach(var w in weather)
            {
                if (func(w) >= 10)
                {
                    count++;
                }
            }
            return count;
        }
    }

    class Weather
    {
        public string Locate { get; set; }
        public DateTime Date { get; set; }
        public double LowestTemperature { get; set; } // 最低気温
        public double HighestTemperature { get; set; } // 最高気温
        public double Precipitation { get; set; } // 降水量
        private static Random random = new Random();

        private readonly string[] LOCATES = new string[] { "大阪", "京都", "神戸" };
        private readonly DateTime DATE_MIN = new DateTime(1900, 1, 1);

        public Weather()
        {
            Locate = LOCATES[random.Next(3)];
            int dateRange = (DateTime.Today - DATE_MIN).Days;
            Date = DATE_MIN.AddDays(random.Next(dateRange));
            double temperature1 = CalculateAppropriateLowestTemperature(Date.Month);
            double temperature2 = CalculateAppropriateHighestTemperature(Date.Month);
            LowestTemperature = Math.Min(temperature1, temperature2);
            HighestTemperature = Math.Max(temperature1, temperature2);
            Precipitation = CalculateAppropriatePrecipitation(Date.Month);
        }

        private double CalculateAppropriateLowestTemperature(int month)
        {
            // 多項式回帰式
            double lowestTempRegression = 0.0198 * Math.Pow(month, 4) - 0.5848 * Math.Pow(month, 3) + 5.1325 * Math.Pow(month, 2) - 11.972 * month + 9.7374;
            return GetNormalRandomNumber(lowestTempRegression, 5);
        }

        private double CalculateAppropriateHighestTemperature(int month)
        {
            // 多項式回帰式
            double highestTempRegression = 0.0161 * Math.Pow(month, 4) - 0.4766 * Math.Pow(month, 3) + 4.0079 * Math.Pow(month, 2) - 7.2896 * month + 11.886;
            return GetNormalRandomNumber(highestTempRegression, 5);
        }

        private double CalculateAppropriatePrecipitation(int month)
        {
            // 多項式回帰式
            double precipitationRegression = -3.7305 * Math.Pow(month, 2) + 49.228 * month - 11.159;
            int i = random.Next(30);
            // 6月9月以外は雨が降りにくい
            if (month != 6 || month != 9)
            {
                if (i < 10)
                {
                    double precipitationPerDay = GetNormalRandomNumber(precipitationRegression / 10, 20);
                    return Math.Max(precipitationPerDay, 0);
                }
                else
                {
                    return 0;
                }
            }
            else
            // 6月9月は雨が降りやすい
            {
                if (i < 20)
                {
                    double precipitationPerDay = GetNormalRandomNumber(precipitationRegression / 20, 20);
                    return Math.Max(precipitationPerDay, 0);
                }
                else
                {
                    return 0;
                }
            }
        }

        //　正規乱数を返す
        private double GetNormalRandomNumber(double mean, double sigma)
        {
            double d1 = random.NextDouble();
            double d2 = random.NextDouble();
            double normalRand = Math.Sqrt(-2 * Math.Log(d1)) * Math.Cos(2 * Math.PI * d2);
            return sigma * normalRand + mean;
        }
    }
}
