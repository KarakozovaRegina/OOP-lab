using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_4
{
    //interface
    interface Message
    {
        void MyMessage();
        void Same();

    }
    public class Equipment : Abstract, Message //Инвентарь
    {
        public string name { get; set; }
        public int coutForMoney20_50;
        public int coutForMoney60_100;
        public void Name()
        {

        }

        public void MyMessage()
        {
            Console.WriteLine("Сообщение написано");
        }
        protected string company;
        protected int idCompany;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        //переопределение ToString
        public override string ToString()
        {
            return ($" В организации {this.company} есть");
        }
        //переопределение GetHashCode
        public override int GetHashCode()
        {
            return (int)idCompany;
        }
        //переопределение Equal
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Equipment b = obj as Equipment; // возвращает null если объект нельзя привести к типу bus
            if (b as Equipment == null)
                return false;

            return b.idCompany == this.idCompany;

        }
        //abstract
        public override void gfg()
        {

        }
        public override void Same()
        {                               //реализация для абстрактного метода
            Console.WriteLine("method(abstract)!");
        }
        void Message.Same()
        {                               //реализация для метода интерфейса
            Console.WriteLine("method(interface)!");
        }
    }



    sealed class Bench : Equipment//Скамейка
    {
        public string name { get; set; }
        public void Name()
        {
            Console.WriteLine($"Вид инвентаря: {name}");

        }
        public int coutForMoney20_50 = 10;
        public int coutForMoney60_100 = 25;


        public string idTypeBench;
        public int countThisTypeBench;
        public string IdTypeBench
        {
            get { return idTypeBench; }
            set { idTypeBench = value; }
        }
        public int CountThisTypeBench
        {
            get { return countThisTypeBench; }
            set { countThisTypeBench = value; }
        }

        public Bench(string ourCompany, string idTypeBench, int countThisTypeBench, string name)//конструктор с параметрами
        {
            this.idTypeBench = idTypeBench;
            this.countThisTypeBench = countThisTypeBench;
            this.company = ourCompany;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.Write("Скамейка типа " + idTypeBench + " с количеством " + countThisTypeBench);
        }

        public override string ToString()
        {
            return "" + base.ToString() + " ^Объект Bench имееет типа:" + idTypeBench + " в количестве:" + countThisTypeBench;
        }

    }


    class Balls : Equipment//Мячи
    {
        public string name { get; set; }
        public void Name()
        {
            Console.WriteLine($"Вид инвентаря: {name}");

        }
        public int coutForMoney20_50 = 54;
        public int coutForMoney60_100 = 100;

        public string idTypeBalls;
        public int countThisTypeBalls;
        public Balls(string ourCompany)
        {
            this.company = ourCompany;
        }
        public string IdTypeBalls
        {
            get { return idTypeBalls; }
            set { idTypeBalls = value; }
        }
        public int CountThisTypeBalls
        {
            get { return countThisTypeBalls; }
            set { countThisTypeBalls = value; }
        }
        public Balls(string ourCompany, string idTypeBalls, int countThisTypeBalls, string name)//конструктор с параметрами
        {
            this.idTypeBalls = idTypeBalls;
            this.countThisTypeBalls = countThisTypeBalls;
            this.company = ourCompany;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.Write("Мячи типа " + idTypeBalls + " с количеством " + countThisTypeBalls);
        }
        public override string ToString()
        {
            return "" + base.ToString() + " ^Объект Balls имееет типа:" + idTypeBalls + " в количестве:" + countThisTypeBalls;
        }
    }

    class Mats : Equipment//Маты
    {
        public string name { get; set; }
        public void Name()
        {
            Console.WriteLine($"Вид инвентаря: {name}");

        }
        public int coutForMoney20_50 = 5;
        public int coutForMoney60_100 = 10;

        public string idTypeMats;
        public int countThisTypeMats;
        public Mats(string ourCompany)
        {
            this.company = ourCompany;
        }
        public string IdTypeMats
        {
            get { return idTypeMats; }
            set { idTypeMats = value; }
        }
        public int CountThisTypeMats
        {
            get { return countThisTypeMats; }
            set { countThisTypeMats = value; }
        }
        public Mats(string ourCompany, string idTypeMats, int countThisTypeMats, string name)//конструктор с параметрами
        {
            this.idTypeMats = idTypeMats;
            this.countThisTypeMats = countThisTypeMats;
            this.company = ourCompany;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.Write("Маты типа " + idTypeMats + " с количеством " + countThisTypeMats);
        }
        public override string ToString()
        {
            return "" + base.ToString() + " ^Объект Mats имееет типа:" + idTypeMats + " в количестве:" + countThisTypeMats;
        }
    }

    class Basketball : Equipment//Баскетбольный мяч
    {
        public string name { get; set; }
        public void Name()
        {
            Console.WriteLine($"Вид инвентаря: {name}");

        }
        public int coutForMoney20_50 = 12;
        public int coutForMoney60_100 = 22;

        public string idTypeBasketball;
        public int countThisTypeBasketball;
        public Basketball(string ourCompany)
        {
            this.company = ourCompany;
        }
        public string IdTypeBasketball
        {
            get { return idTypeBasketball; }
            set { idTypeBasketball = value; }
        }
        public int CountThisTypeBasketball
        {
            get { return countThisTypeBasketball; }
            set { countThisTypeBasketball = value; }
        }
        public Basketball(string ourCompany, string idTypeBasketball, int countThisTypeBasketball, string name)//конструктор с параметрами
        {
            this.idTypeBasketball = idTypeBasketball;
            this.countThisTypeBasketball = countThisTypeBasketball;
            this.company = ourCompany;
            this.name = name;
        }
        public void Print()

        {
            Console.WriteLine();
            Console.Write("Баскетбольный мяч типа " + idTypeBasketball + " с количеством " + countThisTypeBasketball);
        }
        public override string ToString()
        {
            return "" + base.ToString() + " ^Объект Basketball имееет типа:" + idTypeBasketball + " в количестве:" + countThisTypeBasketball;
        }
    }

    class Tennis : Equipment//Теннис
    {
        public string name { get; set; }
        public void Name()
        {
            Console.WriteLine($"Вид инвентаря: {name}");

        }
        public int coutForMoney20_50 = 1;
        public int coutForMoney60_100 = 2;

        public string idTypeTennis;
        public int countThisTypeTennis;
        public Tennis(string ourCompany)
        {
            this.company = ourCompany;
        }
        public string IdTypeTennis
        {
            get { return idTypeTennis; }
            set { idTypeTennis = value; }
        }
        public int CountThisTypeBasketball
        {
            get { return countThisTypeTennis; }
            set { countThisTypeTennis = value; }
        }

        public Tennis(string ourCompany, string idTypeTennis, int countThisTypeTennis, string name)//конструктор с параметрами
        {
            this.idTypeTennis = idTypeTennis;
            this.countThisTypeTennis = countThisTypeTennis;
            this.company = ourCompany;
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.Write("Теннис мяч типа " + idTypeTennis + " с количеством " + countThisTypeTennis);
        }
        public override string ToString()
        {
            return "" + base.ToString() + " ^Объект Tennis имееет типа:" + idTypeTennis + " в количестве:" + countThisTypeTennis;
        }

    }


    class Elements : Equipment//Баскетбольный мяч
    {
        public string name { get; set; }
        public int coutForMoney20_50 ;
        public int coutForMoney60_100 ;
        public void Name()
        {
            Console.WriteLine($"Вид инвентаря: {name}");

        }

        public Elements(string name, int coutForMoney20_50, int coutForMoney60_100)//конструктор с параметрами
        {
            this.coutForMoney20_50 = coutForMoney20_50;
            this.coutForMoney60_100 = coutForMoney60_100;
            this.name = name;
        }

    }

}
