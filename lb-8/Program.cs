using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Используя делегаты (множественные) и события промоделируйте ситуации. При реализации методов везде где возможно использовать лямбда-выражения.
//Создать класс Игра с событиями Атака и Лечить.
namespace Lab_OOP_8
{
    public class Game
    {
        public string name;
        public int health;
        public Game()
        {
            name = "NoName";
            health = 100;
        }
        public Game(string name, int health)
        {
            this.name = name;
            this.health = health;
        }
        public event EventHandler<ActArgs> Attack;      //события на основе стандартного делегата
        public event EventHandler<ActArgs> Treatment;
        public void ToAtt()    //метод, инициирующий событие
        {
            Console.WriteLine(this.name + ", you have been attacked.");
            Attack?.Invoke(this, new ActArgs(this.health));//вызов события, если не null
        }
        public void ToTr()
        {
            Console.WriteLine(this.name + ", you have been treated.");
            Treatment?.Invoke(this, new ActArgs(this.health));
        }
    }




}