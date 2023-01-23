using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_4
{

    /*lb-5*/
    enum MyEnum
    {
        Need,
        AllGood,
        Nothing
    }
   
        struct Adress : Message
    {
        public string home;
        public string name;

        public void MyMessage()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine($"Спортзал расположен по адресу  {name}  {home}");
        }

        public void Same()
        {
            throw new NotImplementedException();
        }
    }

    /*2*/
    partial class Bars : Equipment//Брусья
    {
        public string idTypeBars;
        public int countThisTypeBars;
        public Bars(string ourCompany)
        {
            this.company = ourCompany;
        }
        public string IdTypeBars
        {
            get { return idTypeBars; }
            set { idTypeBars = value; }
        }
        public int CountThisTypeBench
        {
            get { return countThisTypeBars; }
            set { countThisTypeBars = value; }
        }
        public Bars(string ourCompany, string idTypeBars, int countThisTypeBars)//конструктор с параметрами
        {
            this.idTypeBars = idTypeBars;
            this.countThisTypeBars = countThisTypeBars;
            this.company = ourCompany;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.Write("Брусья типа " + idTypeBars + " с количеством " + countThisTypeBars);
        }
        public override string ToString()
        {
            return "" + base.ToString() + " ^Объект Bars имееет типа:" + idTypeBars + " в количестве:" + countThisTypeBars;
        }



    }
}
