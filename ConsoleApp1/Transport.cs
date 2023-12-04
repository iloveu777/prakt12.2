using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Transport
    {
        public string Type {get;set;}
        public string Color { get;set;}
        public double Speed { get; set; }
        public double Weight{ get;set;}
        public Transport() { }
        public Transport(string type, string color, double speed, double weight)
        {
            this.Type = type;
            this.Color = color;
            this.Speed = speed;
            this.Weight = weight;
        }
        public void Info()
        {
            WriteLine($"Тип - {Type}, цвет - {Color}, скорость - {Speed} км/ч, вес - {Weight} т");
        }
    }
}
