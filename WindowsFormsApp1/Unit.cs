using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal abstract class Unit
    {
       string Name;
       public int speed, number;

       public Unit(string name, int speed, int number)
        {
            this.Name = name;
            this.speed = speed;
            this.number = number;
        }


    }
}
