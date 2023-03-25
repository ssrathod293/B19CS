using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer() ;
            c1.PrintA();

            GoldCustomer c2 = new GoldCustomer();
            c2.PrintB();
            Customer c3 = new Customer();c3.Print();
            GoldCustomer c4 = new GoldCustomer();c4.Print();

            Customer c5 = new GoldCustomer();c5.Print();
            //in methodhiding
            //base class referance variable pointing to derived class object
            //will call base class method
            Customer c6 = new Customer();
            c6.Print();c6.PrintA();

            GoldCustomer c7 = new GoldCustomer();
            c7.Print();
            c7.PrintA();//method from base class
            c7.PrintB();

            Customer c8 = new GoldCustomer();
            c8.Print();c8.PrintA();
            //c8.Print();//this method is in customer 
            //present in object of gold customer but not present in referance variable of customer
            ((GoldCustomer)c8).PrintB();//type conversion
            Console.ReadLine();
        }
    }

    //base keword
    public class Customer
    {
        public int Id=10;
        public void PrintA()
        {
            //this keyword points to current instance of class
            Console.WriteLine($"Customer class:{this.Id}");
        }
        public void Print()
        {
            //this keyword points to current instance of class
            Console.WriteLine($"Customer print()");
        }
    }
    public class GoldCustomer:Customer
    {
        public int Id=20;
        public void PrintB()
        {
            //this keyword points to current instance of class
            Console.WriteLine($" Gold Customer class:{this.Id}");

            //if we want to use id value from base class
            Console.WriteLine($" Gold Customer class:{base.Id}");
        }
       //we need to use new keyword to avoid compiler warning
        //method hiding--we are writing same method with diferrent logic in child class
        public new void Print()
        {
            //this keyword points to current instance of class
            //Console.WriteLine($"GoldCustomer print()");
            base.Print();
        }
    }
}
