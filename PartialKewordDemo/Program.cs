using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialKewordDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student c = new Student() { RollNumber=101,Name="srikat"};
            c.PrintDetails();
            Console.ReadLine();
        }
    }
}
