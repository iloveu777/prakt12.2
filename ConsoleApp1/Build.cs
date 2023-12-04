using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Build
    {
        public string Name { get; set; }
        public int Kvo { get; set; }
        public double Area { get; set; }
        public int Floor { get; set; }
        public Build() { }
        public Build(string name, int kvo, double area)
        {
            this.Name = name;
            this.Kvo = kvo;
            this.Area = area;
        }
        
        public Build(string name, int kvo, double area, int floor)
        {
            this.Name = name;
            this.Kvo = kvo;
            this.Area = area;
            Floor = floor;
        }
        public void ShowInfo()
        { if (Floor < 0)
            {
                WriteLine($"Средняя площадь на 1 жильца в {Name} - {Area / Kvo:f2} кв.м");
            }
            else
            {
                WriteLine($"Средняя площадь на 1 жильца в {Name} - {Area / Kvo:f2} кв.м, этажность - {Floor}");

            }
        }


    }
}
    

