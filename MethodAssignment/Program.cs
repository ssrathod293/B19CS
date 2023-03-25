using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method which returns add, sub, division, reminder, multiplication. class -Calculator  method - Operations

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the first number");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Calculator c = new Calculator();
            c.x = n1;c.y = n2;
            int add, sub, mul, rem;
            double div;
            c.Operations(out add,out sub,out mul,out div,out rem);
         
        }
    }

   
    public class Calculator
    {
        public int x;
        public int y;
        public void Operations(out int add,out int sub,out int mul,out double div,out int rem)
        {
            Console.WriteLine($"addition :{ add = x + y} ");
            Console.WriteLine($"substraction:{ sub = x - y}");
            Console.WriteLine($"MUltipication:{mul = x * y}");
            Console.WriteLine($"Division:{div =x /y}");
            Console.WriteLine($"Reminder:{rem = x % y}");
           
        }
    }
}
