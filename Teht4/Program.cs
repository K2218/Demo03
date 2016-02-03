using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teht4
{
  class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Car";
            vehicle.Speed = 70;
            vehicle.Tyres = 4;
            vehicle.PrintData();

             Console.WriteLine(vehicle.ToString());
            Console.ReadLine();


        }

    }
    
}
