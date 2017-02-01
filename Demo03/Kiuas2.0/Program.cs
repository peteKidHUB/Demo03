using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas2._0
{

    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();
            kiuas.ISON = true;
            kiuas.lampotila = 100;
            kiuas.kosteus = 85.5;
            kiuas.vettakiukaalle();
            Console.WriteLine("Tervetuloa käytämään saunasimulaatio kaks piste nollaa");
            Console.WriteLine("kuumaa on " + kiuas.lampotila + "selsius astetta");
            Console.WriteLine("märkää on " + kiuas.kosteus + "%");
        }
    }

}

