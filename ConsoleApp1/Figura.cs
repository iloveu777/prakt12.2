using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Figura
    {
        public double height { get; set; }
        public double width { get; set; }
        public Figura() { }
        public Figura(double height, double width)
        {
            this.height = height;
            this.width = width; 
        }
        public void S()
        {
            if (height == width)
            {
                Write($"Площадь квадрата = {Math.Pow(width, 2)}");
            }
            else 
            {
                Write($"Площадь прямоугольника = {height * width}");
            }
        }
    }
}
