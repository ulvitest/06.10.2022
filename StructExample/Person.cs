using System;
using System.Collections.Generic;
using System.Text;

namespace StructExample
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static bool operator >( Person p1,Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Name.Length < p2.Name.Length;
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Age == p2.Age;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Age != p2.Age;
        }



    }
}
