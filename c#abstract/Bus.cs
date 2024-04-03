using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_abstract
{
    internal class Bus : Vehicle
    {

        private static int _passengerCount; 
        private int PassengerCount
        {
            get { return PassengerCount; }

            set 
            { 
                if(value >= 0)
                {
                  _passengerCount = value;
                }
            }
        }
        public Bus(int _passengerCount, int year, string color) : base(year, color)
        {
            PassengerCount = _passengerCount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Year},{Color},{PassengerCount}");
        }
    }
}
