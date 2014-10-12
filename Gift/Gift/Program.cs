using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    class Program
    {
        static void Main(string[] args)
        {
            Gift gift = new Gift();
            
            gift.AddComponent(new Candy("Candy", "qwe", 50, 52, 46, 2.9, "asd", "zxc"));
            gift.AddComponent(new Cookie("Cookie", "quqi", 80, 60, 38, 8.4, "fgd", "cvb"));
            gift.AddComponent(new Fruit("Fruit", "yui", 200, 56, 3, 9.2, "iop", "xcv"));

            Console.Write("Components :"+Environment.NewLine +gift.ToString());

            Console.WriteLine("Total weight : " + gift.GetWeight().ToString());

            Console.WriteLine(Environment.NewLine + "Sorting......." + Environment.NewLine);

            gift.SortingByWeight();

            Console.Write("Components :"+Environment.NewLine + gift.ToString());

            Console.WriteLine("Candy find : "+Environment.NewLine + gift.FindCandy(45.9, 46.1).ToString());
            
        }
    }
}
