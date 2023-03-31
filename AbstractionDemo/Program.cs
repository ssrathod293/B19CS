using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student(101,"Mahesh");
            s1.print();//abstraction
            //how and what will be output of print() method is hidden
            //incapsulation--defination and how it is working is hidden

        }
    }
    public class student
    {
        int rollnumber;
        string name;
        public student(int rn,string n)
        {
            this.rollnumber = rn;
            this.name = n;
        }
        public void print()
        {
            Console.WriteLine($"Details:{rollnumber}{name}");
        }
    }
}
