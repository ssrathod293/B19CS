using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*
 * object type --it is base type for all types in dot net
 * we get below methods from object type
 * getType(),ToString(),Equals(),getHashCode()
 * to retrive type information we can use GetType() method or typeof() operator
 * gettype() method we can call over variable where as typeof() we can use with type name
 * */
namespace ObjectTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 10;
            Type t1 = i.GetType();
            Console.WriteLine($"int:{t1.Name}{t1.Namespace}");

            Student s1 = new Student();
            Type t2 = s1.GetType();
            Console.WriteLine($"s1:{t2.Name}{t2.Namespace}");

            Customer c1 = new Customer();
            Type t3 = c1.GetType();
            Console.WriteLine($"c1:{t3.Name}{t3.Namespace}");

          MethodInfo[] methods =t2.GetMethods();
            for (i=0;i<methods.Length;i++)
            {
                Console.WriteLine($"{methods[i].Name}");
            }
            ///////////////////////////
          Type t4 = typeof(Customer);*/

            //any value we can represent in string format
            //10.."10"
            //true.."true"
            //12/12/2022..."12/12/2022"
            //10.456..."10.456"
            ///////////////////////////////////////////
            /*
            double d = 10.456;
            string d1 = d.ToString();
            Console.WriteLine(d1);

            bool b = true;
            string b1 = b.ToString();
            Console.WriteLine(b1);

            Student s = new Student() { name = "shrikant" };
            string s1 = s.ToString();
            Console.WriteLine(s1);

            //in case of complex type tostring() method returns fully
            //qualified name
            //we can override tostring() method
            //to get meaning full representation of complex type of object

            Student s2 = new Student() { name = "shashikant" };
            string s3 = s2.ToString();
            Console.WriteLine(s3);

            Customer c1 = new Customer("Neha","Patil");
            Console.WriteLine($"{c1.ToString()}");
            */
            ///////////////////////////////////////////////////
            /*
            //equals() is method used to compare and return true and false
            //equals() method check for reference equality not value equality
            //we can override to check value equality

            Customer c1 = new Customer("sandip","jadhav");
            // Customer c2 = c1;
            //Customer c2 = new Customer("sandip","rathod");
            Customer c2 = new Customer("sandip", "jadhav");

            if (c1.Equals(c2))
            {
                Console.WriteLine("c1 and c2 are equal");
            }
            else
            {
                Console.WriteLine("c1 and c2 are not equal");
            }
            */
            ///////////////////////////////////////////////////////
            
            //gethashcode()
            
            //we can override this method ot maintian unique hashcode for object
           
            int i = 10;
            int j = 20;
            Console.WriteLine($"{i.GetHashCode()}");
            Console.WriteLine($"{j.GetHashCode()}");

            string s1 = "vishal";
            string s2 = "chavan";
            Console.WriteLine($"{s1.GetHashCode()}");
            Console.WriteLine($"{s2.GetHashCode()}");
            string s3 = "vishal";

            Console.WriteLine($"{s3.GetHashCode()}");
            Customer c1 = new Customer("sandip","jadhav");
            Customer c2 = new Customer("sandip", "jadhav");
            Console.WriteLine($"{c1.GetHashCode()}");
            Console.WriteLine($"{c2.GetHashCode()}");
            // if (c1.Equals(c2))
            if (c1.GetHashCode()==c2.GetHashCode())
            {
                Console.WriteLine("c1 and c2 are equal");
            }
            else
            {
                Console.WriteLine("c1 and c2 are not equal");
            }

            Console.ReadLine();
        }
    }
    public class Student
    {
        public string name;
        public void print()
        {
            Console.WriteLine("PRINT");
        }
        public override string ToString()
        {
            return this.name;

        }
    }

    public class Customer
    {
        public string firstName;
        public string lastName;
        public Customer(string fn,string ln)
        {
            this.firstName = fn;
            this.lastName = ln;
        }
        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        public override bool Equals(object obj)
        {
            Customer c = obj as Customer;
            return this.firstName.Equals(c.firstName) &&
                this.lastName.Equals(c.lastName);
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^
                this.lastName.GetHashCode();
        }
    }
}
