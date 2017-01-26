using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {

            CarApplication car = new CarApplication();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Color = "Yellow";
            car.Engine = 1.0;
            car.Speed = 100;
            car.Dizes = true;
            car.DoorCount = 2;
            car.PrintData();
            car.Accelerate();
            Console.WriteLine("Speed = " + car.Speed);


            //CarApplication nascar = new CarApplication("Speedtrep");
            //nascar.PrintData();

        }
    }
}
