using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//single form having multiple forms
//1.runtime polymorphism(dynamic)
/*
 method overiding..why rutimg
compiler not deciding which method is going to call while compiling its decides while run time
 */
//2.compile time polymorphism(static)
/*
 * method overloading and operator overloading
 */
namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() { Screen = "SCREEN1", ticketAmount = 200 };
            c1.printTicket();
            Customer c2 = new GoldCustomer() { Screen = "SCREEN2", ticketAmount = 400 };
            c2.printTicket();
            //in method hiding base class(parent class) referance variable pointing to instance of derived(child) class
            //will call(parent) base class method only
            Customer c3 = new SilverCustomer() { ticketAmount = 600, Screen = "SCREEN3" };
            c3.printTicket();
            //polmorphism one thing having many forms
            //customer class referance variable can points to its own object
            //as well as all its derived class objects

            //in method overriding
            //base class referance variable pointing to derived class object
            //will call derived class overriden method

            //virtual keyword
            //virtual keyword is just a identifier that indicate we can override that method
            //in derived class
            //it is not mandatory to override virtual method
            //virtual method has body just like normal method
            Customer[] customers = new Customer[3];
            customers[0] = new SilverCustomer() { ticketAmount = 100, Screen = "SREEN1" };
            customers[1] = new GoldCustomer() { ticketAmount = 250, Screen = "SREEN2" };
            customers[2] = new PlatinumCustomer() { ticketAmount = 400, Screen = "SREEN3" };
            for (int i = 0; i < customers.Length; i++)
            {
                customers[i].printTicket();
            }
            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int ticketAmount;
        public string Screen;
        public virtual void printTicket()
        {
            Console.WriteLine($"{Screen}Amount|{ticketAmount}");
        }
    }

    public class GoldCustomer : Customer
    {/*
        //method hiding
        //derived class method hides base class method
        
       
         public new void printTicket()
        {
            Console.WriteLine($"GOLD {Screen}Amount|{ticketAmount}");
        }*/

        //method overriding
        public override void printTicket()
        {
            Console.WriteLine($"GOLD {Screen}Amount|{ticketAmount}");
        }
    }
    public class SilverCustomer : Customer
    {
        //in derived class we can override a method using override keyword
        //to override a method the method has to be marked with either virtual or 
        //abstract or override keyword in base class
        public override void printTicket()
        {
            Console.WriteLine($"SILVER {Screen}Amount|{ticketAmount}");
        }
    }
    public class PlatinumCustomer : Customer
    {
        public override void printTicket()
        {
            Console.WriteLine($"VIP {Screen}Amount|{ticketAmount}");

        }
    }
    public class AdvaceSilverCustomer : SilverCustomer
    {
        //multilevel inheritance
        //override silver and again can override in Advancesilver
        //hence for overriding it should be marked with override to override
        //method which is previously overriden
        public override void printTicket()
        {
            Console.WriteLine($"ADVACED SILVER {Screen}Amount|{ticketAmount}");
        }
    }
}
