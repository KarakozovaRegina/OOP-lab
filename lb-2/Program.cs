using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_2
{
    public class Program
    {
       public static void Main()
        {
            Bus[] buss = new Bus[3];
            buss[0] = new Bus("Karakozova", "KRV", "4689", "M1", "BMV", 2006, "10000", 1245);
            buss[1] = new Bus("Ivanov", "IHY", "1119", "M2", "Porshe", 2007, "2000", 6854);
            buss[2] = new Bus("Stevanov", "WWW ", "8079", "M3", "BMV", 2015, "73000", 5775);
           

            foreach (Bus b in buss)
            {
                    b.Print();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("With BMV");
            foreach (Bus k in buss)
            {
                if (k.marka == "BMV")
                {
                    k.Printt();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(">2010");
            foreach (var i in buss)
            {
                if (i.startYear> 2010)
                {
                    i.Printt();
                }
            }

            Bus.Kolichestvo();
            Console.WriteLine("Equals: " + buss[0].Equals(buss[1]));
            Console.WriteLine("ToString: " + buss[0].ToString() + "\n");
            Console.WriteLine("GetHashCode: " + buss[1].GetHashCode());

            var user = new { Surame = "Tomuif", theFirstLetters = "GGG" };
            Console.WriteLine("Surame: " + user.Surame + " TheFirstLetters: " + user.theFirstLetters);
            
            Console.ReadLine();
        }
    }
}
