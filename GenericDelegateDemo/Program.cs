using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateDemo
{
    //generic delegates
    //Action<>--is a generic delgate which has T as input parameter and void as 
    //as retrun type
    //Func<>
    //Predicate<>
    class Program
    {
        //public delegate void PrintDel(string s);
        //public delegate void PrintDel1(int i);
        //we can create our own generic delegates
        public delegate void PrintDel<T>(T a);
        static void Main(string[] args)
        {
            #region custom generic delegate
            /* PrintDel<string> del1 = PrintA;
             del1("welcome to session of generic delegate");
             PrintDel<int> del2 = PrintB;
             del2(20);*/
            #endregion
            #region action delegate
            /* Action<string> a1 = PrintA;
             a1("ACTION MESSAGE");
             Action<int> a2 = PrintB;
             a2(20);
             Action<string,string> s3 = delegate (string s1,string s2)
             {
                 Console.WriteLine($"{s1} {s2}");
             };
             s3("shrikant","rathod");*/
            #endregion
            #region Predicate
            /*
            Predicate<string> p1 = delegate (string s)
            {
                return string.IsNullOrEmpty(s);
            };
           bool b1= p1("shrikant");
            Console.WriteLine(b1);
            b1=p1(null);
            Console.WriteLine(b1);

            Predicate<int> p2 = delegate (int x)
            {
                return x % 2  == 0;
            };
            Console.WriteLine(p2(13));
            Console.WriteLine(p2(10)); */
            #endregion
            #region func
          /*  Func<string> f1 = delegate ()
            {
                return "shrikant";
            };
            Console.WriteLine(f1());
            Func<string, string, string> f2 = delegate (string s1,string s2) 
            {
                return string.Format($"{s1} {s2}");
            };
            Console.WriteLine(f2("shrikant","rathod"));*/
            #endregion
            Func<int, int, int> f1 = delegate (int a,int b)
            {
                return a + b;
            };
            Console.WriteLine(f1(10,20));
            Console.ReadLine();
        }
        static void PrintA(string msg)
        {
            Console.WriteLine(msg);
        }
        static void PrintB(int msg)
        {
            Console.WriteLine(msg);
        }
    }
}
