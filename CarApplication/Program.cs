using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Color = "Yellow";
            car.Engine = 0.4;
            car.DoorCount = 2;
            car.Accelerate();
            car.PrintData();
            Console.ReadLine();

            //Create another car object
            string model = "Jeep";
            Car car2 = new Car(model);
            car2.PrintData();
            car2.Color = "Black";
            car2.Engine = 5.0;
            car2.DoorCount = 4;
            car2.FuzzyDices = false;
            car2.Brake();
            car2.PrintData();
            Console.ReadLine();
        }
    }
}
