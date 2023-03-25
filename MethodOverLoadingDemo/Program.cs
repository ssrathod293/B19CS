using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//same method name with different names or different signiture
//it is compile time polymporism
//if method signiture not available complier gives error
//we can overload a method ..single method having multiple form or behaviour depends 
//upon the input provided
/*
 overload based on types of parameters,number of parameters,order of 
parameters and kinds of parameters
--we cannot overload method basis of return type
return type is excluded from method signature while method overloading
--to avoide developer confusion because while calling method developer may get confused
that which method will get call and what return we will get after call
--based on ref and out on the same method
--based on basis of params keyword
 * */
namespace MethodOverLoadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator c1 = new calculator();
            //c1.add(10,10);
           
            //c1.add();
            //c1.add(10);
            //c1.add(10,10);
            //c1.add(10,10);
            c1.add(10, 10);//which method will called //default int hence int

            short x = 10, y = 20;
            c1.add(x,y);
            Console.ReadLine();
        }
    }
    public class calculator
    {
        public void add(int a,int b)
        {
            Console.WriteLine("add(int a,int b)");
        }

        public void add(short a, short b)
        {
            Console.WriteLine("add(short a,short b)");
        }
        #region void add(int a,int b)
        /*
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void add()
        {
            Console.WriteLine("add()");
        }
        public void add(int a)
        {
            Console.WriteLine("add(a)");
        }*/
        #endregion
        //overloaded based on number of parameter
        //public void Print() { }
        //public void Print(int a) { }

        //overloaded based on types of parameters
        //public void Print(int a) { }
        //public void Print(float b) { }

        //overloaded based on number of  of parameters
        //public void Print(int a) { }
        //public void Print(int a,int b) { }

        //overloaded based on kinds(ref or out) of  of parameters
        //public void Print(int a) { }
        //public void Print(ref int a) { }
        //in ref mandtory to assign before calling
        //public void Print(out int a) { a = 10; }
        //mandatory to assign in called method

        //overloaded based on order of  of parameters
        //public void Print(int a,float b) { }
        //public void Print(float a, int b) { }

        // cant overloaded based on return type
        //public void Print() { }
        //public int Print() { }

        //overloaded methods
        //public void Print(int a) { }
        //public int Print() { return 10; }

        //overloaded based on kind of  of parameters
        //ref and out parameter..not below method
        //because compiler treats ref and out keyword same at compile time
        //public void Print(ref int a) { }
        //public void Print(out int a) { a = 10; }

        //overloaded based on kind of  of parameters
        //overloaded becuse number of parameter in 1st method
        //public void Print(ref int a,int b) { }
        //public void Print(out int a) { a = 10; }


        //not overloaded just on basis of params
        //public void Print(int[] numbers) { }
        //public void Print(params int[] numbers) { }

    }
}
