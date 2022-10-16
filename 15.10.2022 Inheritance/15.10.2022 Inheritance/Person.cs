using System;
using System.Collections.Generic;
using System.Text;

namespace _15._10._2022_Inheritance
{
    internal class Person
    {
        public string name;
        private string surname;
        public int age = 15;
        public string adress = "Insaatcilar";
        public Person(string phone)
        {
            //Console.WriteLine(phone);
            surname = "Eliyev";
        }
        public void ShowSurname()
        {
            Console.WriteLine(surname);
        }
    }
}
