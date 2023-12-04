using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp1
{
    public class Computer
    {
        public string Name { get; set; }
        public double RAM { get; set; }
        public int ROM { get; set; }
        public Computer() { }
        public Computer(string name, double rAM, int rOM)
        {
            this.Name = name;
            this.RAM = rAM;
            this.ROM = rOM;
        }
        public void Info()
        {
            WriteLine($"Модель - {Name}, кол-во ОЗУ - {RAM} ГБ, кол-во ПЗУ - {ROM} ГБ");
        }
    }
}
