using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using static lb_4.Exceptions;
using System.IO;
namespace lb_4
{



    class Program
    {
        static void Main(string[] args)
        {
            //Создаем объекты
            Bench MyBench = new Bench( "Epam","Простая",3, "Скамейка");
            Bars MyBars = new Bars("Epam", "Весом 5 кг ", 10);
            Balls MyBalls = new Balls("Epam", "Обычный", 11, "Мячи");
            Mats MyMats = new Mats("Epam", " Высотой 20см", 6, "Маты");
            Basketball MyBasketball = new Basketball("Epam", "Для женеского пола", 20, "Баскетбольный мяч");
            Tennis MyTennis = new Tennis("Epam", "Простой", 16, "Теннис");
            Console.WriteLine(MyBench);
            MyBench.Print();
            MyBars.Print();
            MyBalls.Print();
            MyMats.Print();
            MyBasketball.Print();
            MyTennis.Print();

            Console.WriteLine();
            Console.WriteLine();
            Message myMessage = new Equipment();
            myMessage.MyMessage();

            MyBench.APrint();

            //вызов одноименных методов
            MyBench.Same();
            ((Message)MyBench).Same();
            Console.WriteLine();

            //is & as
            Equipment myEquipment1 = new Equipment();
            Equipment myEquipment2 = new Equipment();
            Abstract abs= myEquipment1;
            Abstract abs1 = myEquipment2 as Abstract;

            Console.WriteLine(abs is Equipment);
            Console.WriteLine(abs1 is Bench);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("ToString in objects");

            //создание массива
            /*
            Equipment[] arr = { MyBench, MyBars, MyBalls, MyMats, MyBasketball,MyTennis};
            for (int i = 0; i < arr.Length; i++)
            {
                Printer.IAmPrinting(arr[i]);
            }*/

            Console.WriteLine("\n-----LB-5-----");

            /*1*/
            void Message(MyEnum myEnum)
            {
                switch (myEnum)
                {
                    case MyEnum.AllGood:
                        Console.WriteLine("Спортзал оснащен всем необходимым оборудованием");
                        break;
                    case MyEnum.Need:
                        Console.WriteLine("Спортзал нуждается в обновлении");
                        break;
                    case MyEnum.Nothing:
                        Console.WriteLine("Спортзал украли");
                        break;
                }
            }
            Message(MyEnum.Nothing);
            Message(MyEnum.Need);
            Message(MyEnum.AllGood);

            Console.WriteLine("");
            Adress myAdress;                      
            myAdress.name = "Беларуская";
            myAdress.home = "21";
            myAdress.Print();

            /*3*/
            Console.WriteLine("-----3-----");
            Elements elemm1 = new Elements("Футбольный мяч",15,16);
            Elements elemm2 = new Elements("Лыжи", 2, 55);
            Elements elemm3 = new Elements("Канат", 88, 190);
            Elements elemm4 = new Elements("Маты", 5, 10);
            Elements elemm5 = new Elements("Баскетбольные корзины", 2, 4);
            Controller controll = new Controller();
            controll.AddItem(elemm1);
            controll.AddItem(elemm2);
            controll.AddItem(elemm3);
            controll.AddItem(elemm4);
            controll.AddItem(elemm4); 
            controll.DeleteItem(elemm4);
            controll.AddItem(elemm5);
            controll.Sort();
            controll.Poisk();


            /*B-6*/
            Console.WriteLine("\n-----LB-6-----");
            /*2*/

            int value = 32769;//превышает диапозон и сужение происходит
            checked
            {
                try
                {
                    short newValue = (short)value;
                }
                catch (OverflowException )
                {
                    Console.WriteLine("Так нельзя");
                }
            }

            



            int[] num = new int[8];
            try
            {
                num[10] = 5;
            }
            catch (IndexOutOfRangeException exx)
            {
                Console.WriteLine(exx.Message);

            }
            catch (Exception)
            {
                Console.WriteLine("Возникла непредвиденная ошибка, описание ошибки:");
            }
            



            try
            {
                string n = null;
                if (n == null) { 

                throw new StringException("строка пустая");
                }

            }
            catch (StringException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Повторитkjь");
            }
            
           



            try
            {
                int b = 0;
                if (b == 0)
                    throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникла непредвиденная ошибка, описание ошибки:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            catch
            {
                Console.WriteLine("Ошибка!");
            }

            /*4
            int x = 9;
            int y = 0;
            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
                throw;
            }
            
            finally
            {
                Console.WriteLine("Ошибок нет!");
            }
            */
            Debug.Assert(100 == 100, "Chek");

            Console.ReadLine();
        }



        /*3*/
        public class Gym
        {
            public List<Elements> container { set; get; }

            public Gym()
            {
                container = new List<Elements>();
            }

            public void AddItem(Elements elem) => container.Add(elem);
            public void DeleteItem(Elements elem) => container.Remove(elem);

            public void Print()
            {
                Console.WriteLine("Контейнер содержить эелементы: ");
                foreach (var i in container)
                {
                    Console.WriteLine("   " + i.name);
                }
                Console.WriteLine('\n');
            }

        }

        class Controller : Gym
        {
            public int d20_50=30;
            public int d60_100 = 40;
            public void Poisk()
            {
                Console.WriteLine('\n');
                Console.WriteLine("Инвентарь, который можно купить при диапозоне 20-50 руб");
                foreach (var item in container)
                {
                    if (d20_50 == 30)
                    {
                        Console.WriteLine(item.name + "ов:" + item.coutForMoney20_50);
                    }
                 
                }
            }

            public void Sort2(string n)
            {

            }

            public void Sort()
            {
                
                var sorted = from p in container
                             orderby p.coutForMoney60_100 descending
                             select p;
                Console.WriteLine(" Диапозон от 60 до 100 руб");
                foreach (var item in sorted)
                {
                    Console.WriteLine("Инвентарь "+item.name+" при заданом диапозоне можно купить "+item.coutForMoney60_100);
                }
            }
           
        }



        

    }

}
