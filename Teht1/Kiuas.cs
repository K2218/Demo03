using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Kiuas
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public bool IsOn { get; set; }

        public Kiuas(int temperature)
        {
            Temperature = temperature;
        }

        public void IncreaseTemperature()
        {
            Temperature += 5; 
        }

        public void DecreaseTemperature()
        {
            Temperature -= 5;
        }

        //Print properties to console
        public void PrintData()
        {
            Console.WriteLine("Kiuas properties:");
            Console.WriteLine("- Temperature {0}", Temperature);
            Console.WriteLine("- Humidity {0}", Humidity);
            Console.WriteLine("- Kiuas is on: {0}", IsOn);
        }

        //Method returns obejct properties in a one string
        public override string ToString()
        {
            return "temp = " + Temperature + " Humi = " + Humidity + " IsOn = " + IsOn;
        }
   
    }
}
