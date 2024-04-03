using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_abstract
{
    internal abstract class Vehicle
    {
        public string Color;
        public int Year;
        
        public Vehicle(int year,string color)
        {
            Year = year;
            Color = color;
        }

        public abstract void ShowInfo();
    }
}
