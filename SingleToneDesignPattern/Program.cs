using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name1;//we have imported or included Name1 namespace
using Name2;
using VhaashTypes;
using N111= Name1.Name11.Name111;
namespace SingleToneDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Office o = new Office();
            o.Welcome();

            //Name1.A a1 = new Name1.A();//fully qualified name
            //Name1.A a2 = new Name1.A();//fully qualified name
            //Name1.A a3 = new Name1.A();//fully qualified name
            //name clashes
            // Name1. A a1 = new Name1. A();
            //N111. A a1 = new N111. A();
            // Name1.Name11.Name111. A a1 = new Name1.Name11.Name111.A();
            //B b1 = new B();

            Console.ReadLine();
        }
    }
}
namespace Name1
{
    //this namespace will contains its own type
    public class A1 { }
    namespace Name11
    {
        //this namespace will contains its own type
        public class A2 { }
        namespace Name111
        {
            //this namespace will contains its own type

            public class A { }
        }
    }       
}

namespace Name2
{
    public class A { }
    
    public class B { }
}
//nested namespaces
namespace NameA.NameB
    {

    }
//without using namespace
