using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_7
{
    //обобщенный интерфейс//
    interface IGeneric<T>
    {
        void Add(T item);
        void Delete(T item);
        void Show();
    }
}
