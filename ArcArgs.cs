using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_8
{
    public class ActArgs : EventArgs  //класс, содержащий инф. о событиях
    {/*Представляет базовый класс для классов, содержащих данные событий, и предоставляет значение для событий, не содержащих данных.*/
        int h;
        public ActArgs(int h)
        {
            this.h = h;
        }
        public void ToAttack()  //метод-обработчик события
        {
            int heal = h;
            h -= 10;
            if (h <= 0)
            {
                Console.WriteLine("You are dead (*o*)");
            }
            else
            {
                Console.WriteLine("Health level dropped from {0} to {1}!", heal, h);
            }
        }
        public void ToTreat()
        {
            h += 20;
            if (h > 100) { h = 100; }
            Console.WriteLine("Now the level of health is {0}.", h);
        }
    }
}
