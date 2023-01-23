using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_4
{
    public abstract class Abstract
    {

        public virtual void APrint()
        {
            Console.WriteLine("<- abstract class ->");
        }
        public virtual void gfg()
        {

        }

        public abstract void Same();

    }

    
    }
/*2.1
           Console.WriteLine("Напишите число!");
           try
           {
               int number = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine($"Вы ввели число\t{number}");

           }
           catch (FormatException exx)
           {
               Console.WriteLine("Cказано написать число!");
           }
           finally
           {
               Console.WriteLine("Спасибо!");
           }
          */