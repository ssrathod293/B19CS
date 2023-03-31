using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritaceSenario
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.printA();
            
            A a1 = new B();
            a.printA();

            B b = new B();
            b.printA();
            b.printB();

            //B b1 = (B)new A();
            //b1.printB();
            //b1.printA();
        }
    }
    class A
    {
        public void printA()
        {
            Console.WriteLine("PrintA");
        }
    }
    class B : A
    {
        public void printB()
        {
            Console.WriteLine("PrintB");
        }
    }
}
