using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukone
{
    class pesukone
    {
        public bool Power { get; set; }
        public bool Water { get; set; }
        public int lampotila { get; set; }
        public double Aika { get; set; }

        public void Pesu()
        {
            Console.WriteLine("Pesu vaihe menossa");
        }
        public void Linkous()
        {
            Console.WriteLine("Linkous vahe menossa");
        }

    }
}