using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_7
{
    class Inventory
    {
    }

    class Ball : Inventory
    {
        public override string ToString() => "Ball'";
    }

    class Mate : Inventory
    {
        public override string ToString() => "Mate";
    }
}
