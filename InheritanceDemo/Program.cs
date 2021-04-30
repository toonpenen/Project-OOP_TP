using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

    public class Parent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual decimal GetSalary()
        {
            Console.WriteLine("this is in Parent class");
            return 1000.00m;
        }
    }

    public class Teacher : Parent
    {
        public string Subject { get; set; }
        public new  decimal GetSalary()
        {
            return 200;
        }
       
    }

    public class Administration : Parent
    {
        public string Function { get; set; }

        public override decimal GetSalary()
        {
            Console.WriteLine("this is in Administration class");
            return base.GetSalary() + 300.25m;
        }

    }

    public class Student : Administration
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Marks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent()
            {
                FirstName = "Kenan",
                LastName = "Kurda",
                Age = 50,
                //Function = "Book Keeping"
            };
            Parent t = new Teacher()
            {
                FirstName = "Kenan",
                LastName = "Kurda",
                Age = 50,
                //Function = "Book Keeping"
            };
            Parent a = new Administration()
            {
                FirstName = "Kenan",
                LastName = "Kurda",
                Age = 50,
                //Function = "Book Keeping"
            };

            Parent s = new Student()
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Obi",
                Marks = 7,
                Function = "Full Time Student"
            };



            List<Parent> parents = new List<Parent>();


            parents.Add(p);
            parents.Add(t);
            parents.Add(a);
            parents.Add(s);


            foreach (var item in parents)
            {
                Console.WriteLine(item.GetSalary());
            }

        }
    }
}
