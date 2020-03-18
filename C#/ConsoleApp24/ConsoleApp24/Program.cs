using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();

            for (int i = 0; i < 40; i++)
            {
                tv.DownVolume();
                Console.WriteLine(tv.Volume);
            }

        }
    }

    class TV
    {
        private int volume = 50;
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
                if(1 <= value && value <= 12)
                {
                    this.channel = value;
                }
            }
        }

        public void UpVolume()
        {
            if(volume < 50)
            {
                volume++;
            }
        }
        public void DownVolume()
        {
            if(0 < volume)
            {
                volume--;
            }
        }

        public void UpChannel()
        {
            if(channel < 12)
            {
                channel++;
            }
            else if(channel == 12)
            {
                channel = 1;
            }
        }
        public void DownChannel()
        {
            if(1 < channel)
            {
                channel--;
            }
            else if(channel == 1)
            {
                channel = 12;
            }
        }
    }
}
