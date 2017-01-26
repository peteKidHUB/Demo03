using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class CarApplication
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool Dizes { get; set; }
        public int DoorCount { get; set; }


        //public CarApplication (string model);

   //     {

       //     Model = model;

     //   }



        public void Accelerate()
        {

            Speed += 10;

        }

        public void Break(int value)
        {

            Speed -= value;

        }

        public void PrintData()
        {

            Console.WriteLine("Car data: ");
            Console.WriteLine("- model:" + Model);
            Console.WriteLine("- color:" + Color);
            Console.WriteLine("- engine:" + Engine);
            Console.WriteLine("- speed" + Speed);
            Console.WriteLine("- dizes:" + Dizes);
            Console.WriteLine("- Doors:" + DoorCount);

        }


       // ~Car()

        //{

           // Console.WriteLine("Car Destoyed!!");

        //}

    }
}
