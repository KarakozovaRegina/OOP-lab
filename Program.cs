using System;
using System.Text;

namespace lb_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //Типы
             // 1а-инициализация типов
             Console.WriteLine("1a");
             bool no = false;
             bool yes = true;
             sbyte s = -100;// -128 to 127
             short l = 102;//-32768 to 32767
             ushort k = 1;//0 to 65535;
             char c = 's';
             double d= 25.7;
             float f = 1.14F;
             int i = 25;
             uint h = 11;
             long kol = -10;
             ulong ul = 12;
             decimal dul = 2.1m;
             Console.WriteLine(5==5);
             Console.WriteLine($"{no},{yes},{s},{l},{k},{c},{d},{f},{i},{h},{kol},{ul},{dul}");

             Console.Write("число типа float: ");
             string f11 = Console.ReadLine();
             Console.Write("Привет ");
             Console.Write(f11);
             Console.WriteLine();
             Console.WriteLine();
             // 1b-явное и не явное приведениеи типов
             Console.WriteLine("1b");
             int h1 = 5;
             float h11 = h1;//неявн

             int h2 = 10;
             long h22 = h2; //неявн

             short h3 = 102;
             int h33 = h3; // неявн

             ushort h4 = 1;
             int h44 = h4; //неявн

             uint h5 = 11;
             long h55 = h5;

             float h6 = 25.98F;
             int h66 = (int)h6;//явн

             double h7 = 12.3;
             int h77 = (int)h7;//явн

             short h8 = 102;
             ushort h88 = (ushort)h8;//явн

             int h9 = 10;
             uint h99 = (uint)h9; //явн

             float h10 = 5.6578F;
             int h1010 = (int)h10;//явн
             Console.WriteLine($"{h11},{h22},{h33},{h44},{h55},{h66},{h77},{h88},{h99},{h1010}");
             Console.WriteLine();
             Console.WriteLine();
             // 1c-упаковка и распаковка значимых типов
             Console.WriteLine("1c");
             int price = 39;
             Object obj = price;//выделяем место в куче(упаковка)
             Console.WriteLine(obj);

             int price2 = (int)obj;//распаковка
             Console.WriteLine(price2);

             Console.WriteLine();
             Console.WriteLine();
             //1d-работа с неявно типизированной переменной
             Console.WriteLine("1d");
             float h555 = 25.98F;
             int h666 = (int)h555;
             int kvadrat = h666 * h666;
             Console.WriteLine(kvadrat);
             Console.WriteLine();
             Console.WriteLine();
             //1e-Nullable
             Console.WriteLine("1e");
             //Nullable - фича которая позволяет присвоить значения null значимым типам данных(ссылочный тип может быть null / string str = null)
             int? numbe1 = null;
             int? number2 = 23;
             Console.WriteLine(numbe1+"<-тут null");
             Console.WriteLine(number2);
             Console.WriteLine();
             Console.WriteLine();
             //1f
             Console.WriteLine("1f");
             var err1 = 16.3;
             err1 = 15;
             Console.WriteLine(err1);
             //так как string ссылочный тип данных  то ошибка будет 
             //var err12 = "hello"; 
             //err12 = 15;
             Console.WriteLine();
             Console.WriteLine();



             //строки
             //2a
             Console.WriteLine("2a");
             string l1 = "Masha";
             string l2 = "Alex";
             int result = String.Compare(l1,l2);
             Console.WriteLine(result);
             Console.WriteLine();
             Console.WriteLine();
             //2b
             Console.WriteLine("2b");
             string string1 = "red";
             string string2 = "green";
             string string3 = "blue we";
             string rContact = String.Concat(string1, string2, string3);
             Console.WriteLine(rContact);
             string rCopy = String.Copy(string1);
             Console.WriteLine(rCopy);
             string rSubstring = string2.Substring(2,2);
             Console.WriteLine(rSubstring);
             string[] rSplit = string3.Split(' ');
             Console.WriteLine("Количество слов в строке: " + rSplit.Length);
             for (int w = 0; w < rSplit.Length; w++)
             {
                 Console.Write(rSplit[w]);
                 Console.Write("|");
             }
             Console.WriteLine();
             string s3 = string3.Insert(5, "you ");
             Console.WriteLine(s3);
             string s33 = s3.Remove(5, 4);
             Console.WriteLine(s33);
             Console.WriteLine();
             Console.WriteLine();
             //2c
             //метод string.IsNullOrEmpty.---");
             //Указывает, действительно ли указанная строка является строкой null или пустой строкой ("")
             Console.WriteLine("2c");
             string pString = "";
             string nString = null;
             Console.WriteLine(String.IsNullOrEmpty(pString));
             Console.WriteLine(String.IsNullOrEmpty(nString));

             string mynull = null;
             string str = "Trafalgar Law";
             bool abraka = String.IsNullOrEmpty(mynull);
             bool dabra = String.IsNullOrEmpty(str);
             Console.WriteLine($"{abraka}, {dabra}");
             Console.WriteLine();
             Console.WriteLine();
             //2d
             Console.WriteLine("2d");
             StringBuilder sb = new StringBuilder("ABC",50);
             Console.WriteLine(sb);
             sb.Remove(1, 1);
             Console.WriteLine(sb);
             sb.Append('x');
             Console.WriteLine(sb);
             sb.Insert(0, 'x');
             Console.WriteLine(sb);
             Console.WriteLine();
             Console.WriteLine();
            

             //массивы
             //3a
             Console.WriteLine("3a");
             int[,] myArray = { { 0, 1, 2 }, { 3, 4, 5 } };
             int rows = myArray.GetUpperBound(0) + 1;    // количество строк
             int columns = myArray.Length / rows;
             for (int q = 0; q < rows; q++)
             {
                 for (int j = 0; j < columns; j++)
                 {
                     Console.Write($"{myArray[q, j]} \t");
                 }
                 Console.WriteLine();
             }
             Console.WriteLine();
             Console.WriteLine();

            
             //3b
             Console.WriteLine("3b");
             int[] oneArray = new int []{ 0, 1, 2, 3, 4, 5 };
             for (int r = 0; r < oneArray.Length; r++)
             {
                 Console.Write(oneArray[r]+" ");
             }
             Console.WriteLine();
             int aLevgth = oneArray.Length;
             Console.Write("Длина массива: "+ aLevgth);
             Console.WriteLine();

             int[] twoA = new int[] { 5, 6, 1, 3, 4, 2 };
             for (int y = 0; y < oneArray.Length; y++)
             {
                 Console.Write(twoA[y] + " ");
             }
             Console.WriteLine();
             Console.WriteLine("Введите номер элемента массива:");
             int element = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите номер места для перемещения элемента массива:");
             int place=Convert.ToInt32(Console.ReadLine());
             int kk = twoA[element-1];
             twoA[element-1] = twoA[place-1];
             twoA[place-1] = kk;
             for (int t = 0; t < oneArray.Length; t++)
             {
                 Console.Write(twoA[t] + " ");
             }
             Console.WriteLine();
             Console.WriteLine();

            

            //3c
            Console.WriteLine("3c");
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
            for (int ii=0; ii < 2; ii++)
            {
                Console.Write("Введите элемент 1-ой строки:" );
                int elementttt = Convert.ToInt32(Console.ReadLine());
                
                myArr[0][ii] = elementttt;
            }
            for (int ii = 0; ii < 3; ii++)
            {
                Console.Write("Введите элемент 2-ой строки:");
                int elementt = Convert.ToInt32(Console.ReadLine());

                myArr[1][ii] = elementt;
            }
            for (int ii = 0; ii < 4; ii++)
            {
                Console.Write("Введите элемент 3-ой строки:");
                int elementtt = Convert.ToInt32(Console.ReadLine());

                myArr[2][ii] = elementtt;
            }
            Console.WriteLine();

            for (int t = 0; t < 2; t++)
            {
                Console.Write("{0}\t", myArr[0][t]);
            }
            Console.WriteLine();
            for (int t = 0; t < 3; t++)
            {
                Console.Write("{0}\t", myArr[1][t]);
            }
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                
                Console.Write("{0}\t", myArr[2][j]);
            }
            Console.WriteLine();
            Console.WriteLine();

            
            //3d
            Console.WriteLine("3d");
            string[] YES = { "Vava", "Sanji", "Vivi", "Usopp", "Tony", "Brook", "Friday" };
            string yess;
            Console.WriteLine(YES);
            Console.WriteLine();
            Console.WriteLine();

            //кортежи
            //4a
            Console.WriteLine("4a");
            (int, string, char, string, ulong) elem= (1,"krolik", 'e',"cat", 7934076125);
             Console.WriteLine(elem);
            Console.WriteLine();
            //4b
            Console.WriteLine("4b");
            Console.WriteLine(elem.Item1.ToString()+" "+ elem.Item3);
            Console.WriteLine();
            Console.WriteLine();
            //4c
            Console.WriteLine("4c");
            var (name, age) = ("Alex", 18);
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine();
            //4d
            Console.WriteLine("4c-Распакковка кортежей");
            string oh = "Port";
            string oh2 = "Zoro";
            (oh, oh2) = (oh2, oh);
            Console.WriteLine(oh);
            Console.WriteLine(oh2);
            var _ = 6.6;
            Console.WriteLine(_);
            Console.WriteLine();
            //4d
            Console.WriteLine("4d-Сравните два кортежа");
            var tuple1 = (23, 36);
            var tuple2 = (17, 31);
            Console.WriteLine(tuple1 == tuple2);
            Console.WriteLine(tuple1 != tuple2);
            Console.WriteLine(_);
            Console.WriteLine();
            

            Console.WriteLine("5-Локальные функции");
            void Sum()
            {
                int[] Array = { 5, 2, 7, 4, 5 };
                string MString = "string";

                int maxElem=Array[0];
                int minElem=Array[0];
                int sumElem=0;

                (int, int, int, char) elems;

                foreach (int u in Array)
                {
                    if (maxElem < u)
                    {
                        maxElem = u;
                    }
                }

                elems.Item1 = maxElem;

                foreach (int u in Array)
                {
                    if (minElem > u)
                    {
                        minElem = u;
                    }
                }
                elems.Item2 = minElem;

                foreach (int number in Array)
                sumElem += number;
                elems.Item3 = sumElem;

                char firstChar = MString[0];
                elems.Item4 = firstChar;

                Console.WriteLine(elems);
            }
            Sum();
            

            Console.WriteLine("6-checked/unchecked");
            //выражение будет проверяться на переполнение,
            void f1()
            {
                int MaxInt = checked(int.MaxValue);
                Console.WriteLine(MaxInt);
            }
            void f2()
            {
                int MaxInt = unchecked(int.MaxValue);
                Console.WriteLine(MaxInt);
            }
            f1();
            f2();



            
            Console.ReadLine();// чтобы не закрывалась консоль автоматически

           
        }
    }
}
 