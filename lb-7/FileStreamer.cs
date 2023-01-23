using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lb_7
{
    class FileStreamer

    //Добавьте методы сохранения объектов обобщённого типа в файл и чтения из него 
    {
        public static void WriteToFile(MyList<string> list)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\regin\OneDrive\Рабочий стол\file.txt"))
            {
                Node<string> temp = list.GetHead();
                while (temp.NextNode != null)
                {
                    sw.Write($"{temp.Data} --> ");
                    temp = temp.NextNode;
                }
                sw.WriteLine(temp.Data);
            }
        }

        public static void ReadFromFile(ref MyList<string> list)
        {
            using (StreamReader sw = new StreamReader(@"C:\Users\regin\OneDrive\Рабочий стол\file.txt"))
            {
                string[] items = sw.ReadToEnd().Split('-');
                foreach (string item in items)
                {
                    list.Add(item);
                }
            }
        }
    }
}
