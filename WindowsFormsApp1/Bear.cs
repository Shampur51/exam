using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Beer : Unit, IMeat, ISpeed
    {
        int meat;
        public Beer(int n) : base("Beer", 30, n)
        {
            this.meat = 1;
        }

        public int SpeedPerDay()
        {
            return this.speed;
        }

        public double MeatPerDay()
        {
            return meat * number;
        }
    }

}
