using System;
using System.Collections.Generic;
using System.Text;

namespace _15._10._2022_Inheritance
{
    internal class Animal
    {
        internal string name;
        private int age;
        public string color;
        public string breed;

        public int MyProperty { get; set; }
        public int Age 
        {
            get
            {
                if (age > 18)
                {
                    Console.WriteLine("Giris ugurlu");
                    return 1;
                }
                else
                {
                    Console.WriteLine("Ugursuz giris");
                    return -1;
                }
                    
            }
            set
            {
                age = value;   
            }
        }
    }
}
