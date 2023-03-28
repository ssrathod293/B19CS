using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {/*
            ICustomer ic = new SilverCustomer();
            ic.PrintTicket();

            ICustomer ic1 = new GoldCustomer();
            ic1.PrintTicket();

            enquiry e = new enquiry();
            e.ShowTiming();

            SilverCustomer sc1 = new SilverCustomer();
            sc1.ShowTiming();//abstract class member implementation
            sc1.PrintTicket();//interface member implementation*/

            AB ab = new AB();
            ab.printA();
            ab.printB();
            //ab.print();

            //2 ways 
            IA a = new AB();
           // a.printA();
            a.print();

            IB b = new AB();
            b.print();

            //using type cast operator
            AB ab1 = new AB();
            ((IA)ab1).print();//IA implementation
            ((IB)ab1).print();//IB implementation
            Console.ReadLine();


        }
    }

     interface ICustomer
    {
        void PrintTicket();
    }
     abstract public class Customer
    {
        public  void ShowTiming()
        {
            Console.WriteLine("****ALL SHOWS******");
        }
        
    }
    public class SilverCustomer :Customer, ICustomer
    {
        public void PrintTicket()
        {
            Console.WriteLine("SILVER CUSTOMER");
        }
    }
    public class GoldCustomer :Customer, ICustomer
    {
        public void PrintTicket()
        {
            Console.WriteLine("GOLD CUSTOMER");
        }
    }

    public class enquiry:Customer
    {

    }

    interface IA
    {
        void printA();
        void print();
    }
    interface IB
    {
        void printB();
        void print();
    }
    class AB : IA, IB
    {
        //public void print()
        //{
        //    Console.WriteLine("print");
        //}


        public void printA()
        {
            Console.WriteLine("printA");
        }

        public void printB()
        {
            Console.WriteLine("printB");
        }

        void IA.print()
        {
            Console.WriteLine("IA.print()");
        }

        void IB.print()
        {
            Console.WriteLine("IB.print()");
        }

      
    }
}
