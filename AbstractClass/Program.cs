using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Parent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string SayHello()
        {
            return "Hello world";
        }
        public abstract  decimal GetSalary();
      
    }

    public class Child : Parent
    {
        public override decimal GetSalary()
        {
            return 3250.50m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child()
            {
                Age = 25,
                FirstName = "Tim",
                LastName = "Obi"
            };

            Console.WriteLine($"First Name {c.FirstName} Last Name {c.LastName} ");
            decimal salary = c.GetSalary();
            Console.WriteLine($"Salary : {salary}");
        }
    }
}
