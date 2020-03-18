using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class TV
    {
        private int volume = 10;
        private int channel = 1;

        public int Volume
        {
            get
            {
                return this.volume;
            }
            set
            {
                if (0 <= value && value <= 50)
                {
                    this.volume = value;
                }
            }
        }
        public int Channel
        {
            get
            {
                return this.channel;
            }
            set
            {
                if (1 <= value && value <= 12)
                {
                    this.channel = value;
                }
            }
        }

        private int[] ChannelNum;
        private Dictionary<int, string> Channels;

        public TV()
        {
            ChannelNum = new int[] { 1, 2, 4, 6, 7, 8, 10 };
            Channels = new Dictionary<int, string>()
            {
                {1, "NHK総合"},
                {2, "NHKEテレ"},
                {4, "MBS毎日放送"},
                {6, "ABCテレビ"},
                {7, "テレビ大阪"},
                {8, "関西テレビ"},
                {10, "読売テレビ"}
            };
        }

        public void UpChannel()
        {
            if(channel == ChannelNum[ChannelNum.Length - 1])
            {
                channel = ChannelNum[0];
            }
            else
            {
                do
                {
                    channel++;
                }
                while (!ChannelNum.Contains(channel));
            }
        }

        public void DownChannel()
        {
            
        }

        
    }
}
