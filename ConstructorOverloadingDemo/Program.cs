using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//operator overloading is compile time polymphorphism
//why need overloading...operator works with built in types as expected but they
//wont work with custom type operands for this reason we need to overload operator
namespace OperatorOverloadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            //int j = i;
            int j = 10;
            if (i==j)
            {
                Console.WriteLine("i and j are equal");
            }
            else
            {
                Console.WriteLine("i and j are not equal");
            }
            string s1 = "shrikant";
            //string s2 = s1;
            string s2 = "shrikant";
            if(s1==s2)
            {
                Console.WriteLine("s1 and s2 are equal");
            }
            else
            {
                Console.WriteLine("s1 and s2 are not equal");
            }
            string s3 = s1 + s2;
            Console.WriteLine($"{s3}={s1}+{s2}");

            Student std1 = new Student("shrikant","rathod");
            //Console.WriteLine($"full Name:{std1.firstName} {std1.lastName}");
            //Student std2 = std1;//both reference variable points to same object in heap
            /*
             * in case of complex type == operator checks for reference equality and not
             * for value equalit
             */
            Student std2 = new Student("shrikant","rathod");
            if (std1==std2)
            {
                Console.WriteLine("std1 and std2 are equals");
            }
            else
            {
                Console.WriteLine("std1 and std2 are not equal");
            }

            Student std3 = std1 + std2;
            Console.WriteLine($"{std1.firstName}+{std2.firstName}={std3.firstName}");
            Console.WriteLine($"{std1.lastName}+{std2.lastName}={std3.lastName}");
            Console.ReadLine();

        }
    }

   public class Student
    {
        public string firstName;
        public string lastName;
        public Student( string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Student()
        {

        }
        //to check value equality == operator should be overloaded
     public static bool operator==(Student s1,Student s2)
        {
           return s1.firstName == s2.firstName && 
                s1.lastName == s2.lastName;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            return s1.firstName != s2.firstName &&
                 s1.lastName != s2.lastName;
        }

        public static Student operator +(Student s1,Student s2)
        {
            //Student s = new Student();
            //s.firstName = s1.firstName + s2.firstName;
            //s.lastName = s1.lastName + s2.lastName;
            return new Student(s1.firstName+s2.lastName,s1.lastName+s2.lastName);
        }
    }

}
