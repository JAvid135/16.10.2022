using System;
using System.Collections.Generic;
using System.Text;

namespace _15._10._2022_Inheritance
{
    internal class Employee: Person
    {
        public Employee(string phoneNumber) : base(phoneNumber)
        {
            Console.WriteLine(phoneNumber);
        }
    }
}
