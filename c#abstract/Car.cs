using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace c_abstract
{
    internal class Car :Vehicle
    {
        public string Brand;
        public string Model;
        private  int _maxSpeed;
        public int MaxSpeed
        {
            get { return MaxSpeed; }

            set
            {
                if (value >= 0)
                {
                    _maxSpeed = value;
                }
            }
        }
        public Car(string brand, string model,int _maxSpeed, int year, string color):base( year,color) 
        {
            Brand = brand;
            Model = model;
            MaxSpeed=_maxSpeed;
        }

       
        public override void ShowInfo()
        {

            Console.WriteLine($"{Brand},{Model},{MaxSpeed},{Year},{Color}");
            
        }
    }
}
