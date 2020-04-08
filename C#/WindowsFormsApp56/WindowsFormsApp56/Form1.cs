using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp56
{
    public partial class Form1 : Form
    {
        TimeSpan NormalWorkingTime = new TimeSpan(8, 0, 0);
        TimeSpan StartLunch = new TimeSpan(12, 0, 0);
        TimeSpan EndLunch = new TimeSpan(13, 0, 0);
        TimeSpan StartLateNight = new TimeSpan(22, 0, 0);
        TimeSpan EndLateNight = new TimeSpan(5, 0, 0);
        double OrverTimeWork = 0.25;
        double HolidayWork = 0.35;
        double LateNightWork = 0.25;
        int MinWage = 964;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcuButton_Click(object sender, EventArgs e)
        {
            DateTime date = datePicker.Value;
            DateTime goingDt = goingPicker.Value;
            DateTime departureDt = departurePicker.Value;
            string hourlyStr = hourlyText.Text;
          
            int hourlyWage = int.Parse(hourlyStr);
            wageText.Text = WageCalc(date, goingDt, departureDt, hourlyWage).ToString();

            string errorMg = ErrorMessage(hourlyStr, date, goingDt, departureDt, hourlyWage);
            if (errorMg != "" || errorMg != null)
            {
                errorLabel.Text = errorMg;
                return;
            }
        }

        private int WageCalc(DateTime date, DateTime goingDt, DateTime departureDt, int hourlyWage)
        {
            TimeSpan goingAt= goingDt.TimeOfDay;
            TimeSpan departureAt = departureDt.TimeOfDay;
            TimeSpan allTime = departureAt - goingAt;
            TimeSpan lunchTime = Comparison(goingAt, departureAt, StartLunch, EndLunch);
            TimeSpan workingTime = allTime - lunchTime;

            double normalWage = 0;
            normalWage = workingTime.TotalHours * hourlyWage; //普通賃金
            
            double holidayWage = 0;
            double overTimeWage = 0;
            if (date.DayOfWeek == DayOfWeek.Sunday) //日曜日
            {
                holidayWage = hourlyWage * workingTime.TotalHours * HolidayWork;
            }
            else　//平日
            {
                TimeSpan overTimeHour = workingTime - NormalWorkingTime;
                if(overTimeHour > TimeSpan.Zero)
                {
                    overTimeWage = overTimeHour.TotalHours * OrverTimeWork * hourlyWage;
                }
            }

            double lateNightWage = 0;
            TimeSpan midnight = new TimeSpan(24, 0, 0); //深夜
            TimeSpan lateNightHourPM = Comparison(goingAt, departureAt, StartLateNight, midnight);
            TimeSpan lateNightHourAM = Comparison(goingAt, departureAt, TimeSpan.Zero, EndLateNight);
            TimeSpan lateNightHour = lateNightHourAM + lateNightHourPM;
            lateNightWage = hourlyWage * lateNightHour.TotalHours * LateNightWork;


            double total = normalWage + overTimeWage + holidayWage + lateNightWage;
            int totalWage = (int)total;
            return totalWage;
            
        }

        private TimeSpan Comparison(TimeSpan t1, TimeSpan t2, TimeSpan t3, TimeSpan t4)
        {
            if(t2 <= t3 || t4 <= t1)
            {
                return TimeSpan.Zero;
            }
            else
            {
                var List = new TimeSpan[] { t1, t2, t3, t4 };
                var orderList = List.OrderBy(t => t).ToArray();
                return orderList[2] - orderList[1];
            }
        }

        private string ErrorMessage(string hourlyStr, DateTime date, DateTime goingDt, DateTime departureDt, int hourlyWage)
        {   

            if(goingDt > departureDt)
            {
                return "退勤時刻を出勤時刻より前にしてください。";
            }

            if (hourlyWage != int.Parse(hourlyStr))
            {
                return "数値を入力してください。";
            }
            
            if(hourlyWage < MinWage )
            {
                return "最低賃金を下回っています。";
            }

            return null;
        }
    }
}