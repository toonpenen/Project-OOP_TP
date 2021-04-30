using System;

namespace OOP
{
    public class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Age = 15;
        }

        public Person(string fullName) : this()
        {
            this.FullName = fullName;
        }

        public Person(string fullName, int age) : this(fullName)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        public void GetDetails()
        {
            Console.WriteLine($"The Fullname is :{FullName} and the Age is {Age}");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Person p = new Person("Kenan Kurda", 50);

            Person p = new Person
            {
                FullName = "Toon Penen",
                Age = 42
            };

            p.GetDetails();
        }
    }
}