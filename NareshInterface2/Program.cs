using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshInterface2
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleInheritance s1 = new MultipleInheritance();
            s1.test();
            IInerface1 s2 = s1;
            s2.test();
            IInerface1 s3 = s1;
            s3.show();
            IInterface2 s4 = s1;
            s4.show();
            
            Console.ReadLine();
        }
    }
    interface IInerface1
    {
        void test();
        void show();
    }
    interface IInterface2
    {
        void test();
        void show();
    }

    class MultipleInheritance : IInerface1, IInterface2
    {
        public void test()
        {
            Console.WriteLine("tset() implemented");
        }

        void IInerface1.show()
        {
            Console.WriteLine("interface1 called");
        }

        void IInterface2.show()
        {
            Console.WriteLine("interface2 called");
        }

      
    }
}
