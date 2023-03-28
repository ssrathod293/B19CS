using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c = new Customer();we cant create instance of abstract class
            Customer c1 = new SilverCustoer();
            c1.ShowTiming();
            c1.PrintTicket();
            Customer c2 = new GoldCustomer();
            c2.ShowTiming();
            c2.PrintTicket();
            Console.ReadLine();
        }
    }

    abstract class Customer
    {
        public void ShowTiming()
        {
            Console.WriteLine("print show timging");
        }
        public abstract void PrintTicket();
      
    }

    class SilverCustoer:Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("SILVER CUSTOMER");
        }
    }
    class GoldCustomer:Customer
    {
        public override void PrintTicket()
        {
            Console.WriteLine("GOLD CUSTOMER");
        }

    }
}
