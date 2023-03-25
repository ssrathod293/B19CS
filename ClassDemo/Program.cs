using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region student object
            /* Student s1 = new Student();
             s1.RollNumber = 13;
             s1.FirstName = "shrikant";
             s1.LastName = "Rathod";

             s1.PrintFullName();
             s1.PrintDetails();

             Student s2 = new Student();
             s2.RollNumber = 12;s2.FirstName = "suraj";
             s2.LastName = "panchal";
             s2.PrintFullName();
             s2.PrintDetails();

             Student s3 = new Student() { RollNumber = 12, FirstName = "shrikant", LastName = "rathod" };
             s3.PrintDetails();
             s3.PrintFullName();

             Student s4 = s3;
             s4.PrintFullName();
             s4.PrintDetails();

             Student s5 = new Student();
             s5.Intialization(s1);
             s5.PrintDetails();
           /////////////////////////////////////////////////
             Student s6 = new Student();
             s6.Intialize(20,"balaji","rathod");
             s6.PrintDetails();*/
            #endregion student object
            #region calculator
            /* Calculator c = new Calculator() { Number1 = 30, number2 = 15 };
             c.add();
             c.sub();
             c.mul();
             c.div();

             Console.WriteLine("please enter the first Number:");
             int n1=int.Parse(Console.ReadLine());
             Console.WriteLine("please enter the second Number:");
             int n2 = int.Parse(Console.ReadLine());

             Calculator c2 = new Calculator() { Number1 = n1, number2 = n2 };
             c2.add();
             c2.sub();
             c2.mul();
             c2.div();*/
            #endregion
            #region circle
            //////////////////////////////////////////////////
          /*  Circle.pi = 3.14f;//we can access static member using class name
            Circle c3 = new Circle();
            c3.radius = 5;
            //c3.pi = 3.14f;//we cannot access static members using instance
            c3.Area();
            //Circle c4 = new Circle() { radius = 24, pi = 3.14f };
            Circle c4 = new Circle() { radius = 10 };
            c4.Area();
            //Circle.Shape();*/
            #endregion

            // Sample s1 = new Sample();
            Sample.Print();
            Console.ReadLine();
        }
    }

    public class Student
    {
        //class fields/data members
        public int RollNumber;
        public string FirstName;
        public string LastName;

        //method/member function
        public void PrintFullName()
        {
            Console.WriteLine($"fullname:{FirstName} {LastName}");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{RollNumber}-{FirstName} {LastName}");
        }

        public void Intialization(Student s)
        {
            this.RollNumber = s.RollNumber;
            this.FirstName = s.FirstName;
            this.LastName = s.LastName;
        }

        public void Intialize(int rn, string fn, string ln)
        {
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
        }
    }
    public class Calculator
    {
        public int Number1;
        public int number2;

        public void add()
        {
            Console.WriteLine($"Number1+Number2:{Number1 + number2}");
        }
        public void sub()
        {
            Console.WriteLine($"Number1-Number2:{Number1 - number2}");
        }
        public void mul()
        {
            Console.WriteLine($"Number1*Number2:{Number1 * number2}");
        }
        public void div()
        {
            Console.WriteLine($"Number1/Number2:{Number1 / number2}");
        }
    }

    public class Circle
    {
        public int radius;//instance member
        public static float pi;//static member

// non static member can access static as well as non static member
//non static--instance member
//member-field/method/property/constructor
        public void Area()
        {
            Shape();
            Console.WriteLine($"Area of Circle:{pi * radius * radius}");
        }

        public static void Shape()
        {
            //Area();
            //static member can only access static member 
            Console.WriteLine("CIRCLE");
        }
    }

  public static class Sample
    {
      public static void Print()
        {
            Console.WriteLine("Print");
        }
    }
}
