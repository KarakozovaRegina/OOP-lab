using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_8
{
    public static class StringHandler
    {
        //2.Создайте пять методов пользовательской обработки строки (например, удаление знаков препинания, добавление символов, замена на заглавные,
        //удаление лишних пробелов и т.п.). Используя стандартные типы делегатов (Action, Func) организуйте алгоритм последовательной обработки строки
        //написанными вами методами.
        public static string RemoveS(string str, Func<string, string> test1) { return test1(str); }      //удаление знаков
        public static void AddToString(string str, Action<string> test2) => test2(str);                 //добавление строки
        public static string RemoveSpase(string str, Func<string, string> test3) { return test3(str); }  //удаление пробелов
        public static string Upper(string str, Func<string, string> test4) { return test4(str); }       //в верхний регистр
        public static string Lower(string str, Func<string, string> test5) { return test5(str); }       //в нижний регистр
    }
}










/*Делегат Action представляет некоторое действие, которое ничего не возвращает, то есть в качестве возвращаемого типа имеет тип void:
Как правило, этот делегат передается в качестве параметра метода и предусматривает вызов определенных действий в ответ на произошедшие действия.*/

/*Func Он возвращает результат действия и может принимать параметры.*/

//изменение и возвращение 