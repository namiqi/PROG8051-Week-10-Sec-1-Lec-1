using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Week_10_Sec_1_Lec_1.Car
{
    class Lexus : Car // child class
    {
        public string model = "RX350";

        public override void Honk()
        {

            Console.WriteLine("Honk Honk Lexus");
        }

    }
}
