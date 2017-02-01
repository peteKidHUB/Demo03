using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class tv
    {
        public bool Power { get; set; }
        public int Kanava { get; set; }
        public int Volume { get; set; }

        public void DataPrint()
        {
            Console.WriteLine("Power " + Power);
            Console.WriteLine("katselet kanavaa " + Kanava);
            Console.WriteLine("volaa on " + Volume);

        }
    }

}