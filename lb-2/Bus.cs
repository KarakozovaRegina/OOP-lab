using System;

namespace lb_2
{
    public partial class Bus
    {
        // Поля
        private int id;
        public string surname;
        public string theFirstLetters;
        public string numberBus;
        public string numberRoute;
        public string marka;
        public int startYear;
        public string runs;

        private static readonly string country;
        public static string nameCompany;
        private static int count;
        public const string city = "Minsk";

        //конструкторы
        public Bus()//явно написали конструктор по умолчани и конструктор без параметров
        {
            Console.WriteLine("конструктор");
        }
        public Bus(string surname, string theFirstLetters, string numberBus, string numberRoute, string marka, int startYear, string runs,int id)//конструктор с параметрами
        {
            this.surname = surname;
            this.theFirstLetters = theFirstLetters;
            this.numberBus = numberBus;
            this.numberRoute = numberRoute;
            this.marka = marka;
            this.startYear=startYear;
            this.runs = runs;
            this.id = id;
        }
        static Bus()//статический конструктор
        {
            Console.WriteLine("sfdfwe");
        }
        private Bus(int id)
        {
            this.id = id;
        }
        //свойства
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (surname == null)
                {
                    Console.WriteLine("surname no");
                }
                else
                {
                    surname = value;
                }
            }
        }
        public string TheFirstLetters
        {
            get
            {
                return theFirstLetters;
            }
            set
            {
                if (theFirstLetters == null)
                {
                    Console.WriteLine("theFirstLetters no");
                }
                else
                {
                    theFirstLetters = value;
                }
            }
        }
       public string NumberBus
        {
            get
            {
                return numberBus;
            }
            set
            {
                if (numberBus == null)
                {
                    Console.WriteLine("numberBus no");
                }
                else
                {
                    numberBus = value;
                }
            }
        }
       
        public string NumberRoute
        {
            get
            {
                return numberRoute;
            }
            set
            {
                if (numberRoute == null)
                {
                    Console.WriteLine("numberRoute");
                }
                else
                {
                    numberRoute = value;
                }
            }
        }
        public string Marka
        {
          
            set
            {
                if (marka == null)
                {
                    Console.WriteLine("marka no");
                }
                else
                {
                    marka = value;
                }
            }
        }


        //методы
        public void Printt()
        {
            Console.WriteLine("\nBus");
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("TheFirstLetters: " + theFirstLetters);
            Console.WriteLine("NumberBus: " + numberBus);
            Console.WriteLine("NumberRoute: " + numberRoute);
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("StartYear: " + startYear);
            Console.WriteLine("Runs: " + runs);
            Console.Write('\n');
        }
        public void Print()
        {
            Console.WriteLine("\nBus");
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("TheFirstLetters: " + theFirstLetters);
            Console.WriteLine("NumberBus: " + numberBus);
            Console.WriteLine("NumberRoute: " + numberRoute);
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("StartYear: " + startYear);
            Console.WriteLine("Runs: " + runs);
            StartYearChet(ref startYear);
            kol_vo++;
            Console.Write('\n');
        }
        static int kol_vo = 0;
        public static void Kolichestvo()
        {
            Console.WriteLine("Количество созданных объектов: " + kol_vo);
        }

        
         public void StartYearChet(ref int startYear) {
            int Start;
             Start=2022 - startYear;
            Console.WriteLine(Start);
         }
        public void ChangeStart(out int startYear,int newStartYear)
         {
             startYear = newStartYear;
         }
       
    }
}
