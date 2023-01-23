using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyList<string> list = new MyList<string>();
                list.Add("Shayrma");
                list.Add("Salat");
                list.Add("HotDog");
                list.Add("Сurd");
                list.Add("Chips");
                list.Show();

                Console.WriteLine(list[0]);
                list[0] = "Pizza";
                list.Show();

                list.Delete("Salat");
                list.Show();
                FileStreamer.WriteToFile(list);

                MyList<string> listCopy = new MyList<string>();
                FileStreamer.ReadFromFile(ref listCopy);
                Console.Write("Copy: ");
                listCopy.Show();

                //////////////////////////////////////////////////////

                MyList<Inventory> inventory = new MyList<Inventory>();
                inventory.Add(new Mate());
                inventory.Add(new Ball());
                inventory.Show();
            }

            //////////////////////////////////////////////////////  finally
            catch (WrongIndexException ex) { Console.WriteLine(ex); }
            catch (WrongElementException ex) { Console.WriteLine(ex); }
            finally { Console.WriteLine("END"); }

            Console.ReadLine();
        }
    }
    }

