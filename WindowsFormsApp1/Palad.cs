using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Palad:Unit, IWine, IGold, IFeed, ISpeed
    {
        int gold, wine, feed;
        public Palad(int n) : base ("Paladin", 15, n)
        {
            wine = 3;
            gold = 2;
            feed = 1;
        }

        public int SpeedPerDay()
        {
            return this.speed;
        }

        public double WinePerDay()
        {
            return wine * number;
        }

        public double GoldPerDay()
        {
            return Convert.ToDouble(gold * number);
        }

        public double FeedPerDay()
        {
            return Convert.ToDouble(feed * number);
        }
    }
}
