using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingScenario
{
    class Program
    {
        static void Main(string[] args)
        {
            //with override
            //A a1 = new A();a1.Print();//A
            //A a2 = new B();a2.Print();//B
            //A a3 = new C();a3.Print();//C

            A a1 = new A(); a1.Print();//A
            A a2 = new B(); a2.Print();//A
            A a3 = new C(); a3.Print();//A

            B b1 = new C();b1.Print();//
            //if not overriden referance variable type will called
            Console.ReadLine();
        }
    }
    public class A
    {    
        public virtual void Print() { Console.WriteLine("A"); }
    }
    public class B:A
    {
        public new void Print() { Console.WriteLine("B"); }
    }
    public class C : B
    {
        public  new void Print() { Console.WriteLine("C"); }
    }
}
