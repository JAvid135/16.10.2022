using System;
using System.Collections.Generic;
using System.Text;

namespace _15._10._2022_Inheritance
{
    internal class Cat : Animal
    {
        public Cat(string color)
        {
            name = "Mestan";
            this.color = color;
            Console.WriteLine(color);
        }
    }
}
