using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukone
{
    class Program
    {
        static void Main(string[] args)
        {
            pesukone Pesukone = new pesukone();

            Pesukone.Power = true;
            Pesukone.Water = true;
            Pesukone.lampotila = 60;
            Pesukone.Aika = 60;

            Console.WriteLine("Power: " + Pesukone.Power);
            Console.WriteLine("Water: " + Pesukone.Water);
            Console.WriteLine("Vesi on : " + Pesukone.lampotila + " astetta lämmintä");
            Console.WriteLine("Aikaa jäljellä: " + Pesukone.Aika + " Minuuttia");

            Console.WriteLine("muutama minuutti jäljellä");
            Console.WriteLine("PEEP PEEP VALMIS");
            //Linkous???();
        }
    }
}
