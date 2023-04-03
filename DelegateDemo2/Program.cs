using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
    class Program
    {
        public delegate void PrintDel();
        static void Main(string[] args)
        {
            PrintDel d1 = PrintA;
            PrintB(d1);
            d1 = PrintC;
            PrintB(d1);
           // printB();
            Console.ReadLine();
        }
        #region normal method call
        //static void printA()
        //{
        //    Console.WriteLine("printA");
        //}
        //static void printB()
        //{
        //    printA();
        //}
        #endregion
        static void PrintA()
        {
            Console.WriteLine("PRINTA");
        }
        static void PrintB( PrintDel del)
        {
              del();
        }
        static void PrintC()
        {
            Console.WriteLine("PRINTC");
        }

    }
}
