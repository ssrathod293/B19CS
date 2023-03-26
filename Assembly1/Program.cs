using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembly2;

namespace Assembly1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class X:A
    {
        void printX()
        {
            //A a = new A();
            //a.printA();
            printA();
            Console.WriteLine("X");
        }
    }
    class Y
    {
        public Y()
        {
            A a = new A();
            a.printA();
        }
    }
}
