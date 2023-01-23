using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_4
{
    class Printer
    {
        public static void IAmPrinting(Equipment myEqu)
        {
             Console.WriteLine(myEqu.GetType());
            Console.WriteLine(myEqu.ToString());
        }
    }
}
