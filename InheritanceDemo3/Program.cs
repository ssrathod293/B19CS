using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer();
            //GoldCustomer c2 = new GoldCustomer();
            //GoldCustomer c3 = new GoldCustomer("WELCOME");

            //base default ctor then self default ctor
            GoldCustomer c2 = new GoldCustomer();

            //base parameterized ctor then self default ctor
            //ctor chain using base keyword
            GoldCustomer c3 = new GoldCustomer("WELCOME");
            Console.ReadLine();
        }
    }

    public class Customer
    {//we need to explicitly write default ctor if have written parameterized ctor in
        //base class
         public Customer()
          {
              Console.WriteLine("CUSTOMER");
          }
        public Customer(string m)
        {
            Console.WriteLine("CUSTOMER "+m);
        }
    }
    //derived class ctor
    //always look for base class parameterless ctor
    public class  GoldCustomer:Customer
    {   
        //compiler error
        //before derived class ctor it calls base class default ctor
        //even if it is a parameterized ctor
        public GoldCustomer()
        {
            Console.WriteLine("GOLD CUSTOMER");
        }

        //constructor chain
        public GoldCustomer(string msg):base(msg)
        {
            Console.WriteLine("GOLD CUSTOMER "+msg);
        }
    }
}
