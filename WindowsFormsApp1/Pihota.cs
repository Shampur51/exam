using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Pihota : Unit, IWine, IGold, ISpeed
    {
        int gold, wine;
        public Pihota(int n) : base("Pihota", 5, n)
        {
            this.wine = 1;
            this.gold = 1;
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
    }
}

