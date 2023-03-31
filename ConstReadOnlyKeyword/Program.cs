using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadOnlyKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            #region const field
            /*
            Student s1 = new Student();
           s1.Name = "shrikant";
            //s1.CompanyName = "Vhaash";
            //cant access const with class instance
            //Student.CompanyName="Vhassh";//cant change value
            s1.print();

            Student s2 = new Student();
            s2.Name = "shri"; 
            //s2.CompanyName = "Vhaash";
            s2.print();

            Student s3 = new Student();
            s3.Name = "baban"; 
            //s3.CompanyName = "CTS";
            s3.print();*/
            #endregion

            Student s1 = new Student();
            s1.Name = "Suraj";
            s1.print();
            //s1.CompanyName = "Vhaash";
            //we cant change value of readonly here
            Console.ReadLine();

        }
    }
    public class Student
    {
        public string Name;
        //public const string CompanyName="V#";
        //public readonly string CompanyName="V#";
        public static readonly string CompanyName="V#";
        //public Student()
        static Student()
        {
            CompanyName = "Vhaash";
        }
        public void print()
        {
            //CompanyName = "V#";//not possible
            Console.WriteLine($"Name:{Name} Company Name:{CompanyName}");
        }
    }
}
