using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_2
{
    public partial class Bus
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Bus b = obj as Bus; // возвращает null если объект нельзя привести к типу bus
            if (b as Bus == null)
                return false;

            return b.id == this.id;

        }
        public override string ToString()
        {
            return ($"\nSurname: {this.surname}\nMarka: {this.marka}\nId: {this.id}");
        }

        public override int GetHashCode()
        {
            return (int)startYear;
        }
    }
}
