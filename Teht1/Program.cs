using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 70;
            Kiuas kiuas = new Kiuas(temperature);
            kiuas.IsOn = true;
            kiuas.IncreaseTemperature();
            kiuas.Humidity = 50;
            kiuas.PrintData();

            Console.WriteLine("Temperature =" + kiuas.Temperature);

            Console.WriteLine(kiuas.ToString());
            Console.ReadLine();
        }
    }
}
