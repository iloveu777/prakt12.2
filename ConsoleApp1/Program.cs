using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        { 
           /* Build dom1 = new Build();
            dom1.Name = "dom1";
            dom1.Area = 1000;
            dom1.Kvo = 15;
            dom1.ShowInfo();
            Build dom2 = new Build("dom2",20, 1300);
            dom2.ShowInfo();
            Write("Сколько этажей хотите в доме ? ");
            int a = int.Parse(ReadLine());
            Build dom3 = new Build("dom3", 40, 2400, a);
            dom3.ShowInfo();*/
           //2
           /*
           Computer IBM = new Computer("IBM", 0.256, 8);
            Computer Asus = new Computer("Asus", 16, 512);
            Computer MSI = new Computer("MSI", 128, 2048);
            IBM.Info();
            MSI.Info();
            Asus.Info();*/
           //3
           /*
           Transport auto = new Transport("Авто", "Красный", 100.4, 2);
            Transport bicycle = new Transport("Велосипед", "Графитовый", 25, 0.01);
            auto.Info();
            bicycle.Info();*/
           //4
           Figura f1 = new Figura(3,3);
            f1.S();
            Figura f2 = new Figura(2,5);
            f2.S();
            ReadKey();
        }
    }
}
