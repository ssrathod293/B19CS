using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void PrintDelagate();//1--declaring delegate
    public delegate void Print1Delagate(string s);
    public delegate string PrintxDelagate(string s);
    class Program
    {
        static void Main(string[] args)
        {
            #region multicast delegate
            // PrintA();
            //PrintDelagate pd = new PrintDelagate(PrintA);
            PrintDelagate pd1 = PrintA;
            PrintDelagate pd2 = PrintB;
            PrintDelagate pd3 = PrintC;
            //PrintDelagate pd = pd1 + pd2 + pd3;
            //PrintDelagate pd = pd3 + pd2 + pd1;
           // PrintDelagate pd = pd3 + pd2 + pd1-pd3;//pd3 will deregister
           // pd();
            //+..to assign to register method with delegate
            //-..to de assign to de register method from delgate

            PrintDelagate pd = PrintA;
            pd += PrintB;
            pd += PrintC;
            pd();
            //2--instance of delegate
            //pd();//3--calling delegate
            #endregion
            #region delegate with parameter
            // Print1Delagate p = print1;
            //p("shrikant");
            Print1Delagate p = print1;
            p += print2;
            p += print3;
            // p("rathod");
            string[] values = new string[] { "HI", "HELLO", "GOOD MOORNING" };
           Delegate[] delegates= p.GetInvocationList();
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i].DynamicInvoke(values[i]);
            }
            #endregion
            PrintxDelagate px= printx;
            px += printy;
            px += printz;
            
            string[] val = new string[] { "shrikant", "shripat", "Rathod" };
           Delegate[] delegates1= px.GetInvocationList();
            for (int i = 0; i < delegates1.Length; i++)
            {
                try
                {
                    var res = delegates1[i].DynamicInvoke(val[i]);
                    Console.WriteLine(res);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
               
            }
            Console.ReadLine();
        }

        static void PrintA()
        {
            Console.WriteLine("PrintA");
        }
        static void PrintB()
        {
            Console.WriteLine("PrintB");
        }
        static void PrintC()
        {
            Console.WriteLine("PrintC");
        }
        static void print1(string s)
        {
            Console.WriteLine(s);
        }
        static void print2(string s)
        {
            Console.WriteLine(s);
        }
        static void print3(string s)
        {
            Console.WriteLine(s);
        }
        static string printx(string s)
        {
            return s.ToUpper();
        }
       static string printy(string s)
        {
            //
           // s = null;
            return s.ToUpper();
        }
        static string printz(string s)
        {
            return s.ToUpper();
        }
    }
}
