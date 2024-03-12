using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8051_Week_10_Sec_1_Lec_1.Car
{
    class Tesla : Car // child class
    {
        public string model = "modelX";

        public override void Honk()
        {

            Console.WriteLine("Honk Honk Tesla");
        }
    }
}
