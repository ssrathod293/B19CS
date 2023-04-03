using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicateNaresh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int, int, float> f1 = delegate (int x, int y, int z)
            // {
            //     return x + y + z;
            // };
            Func<int, int, int, float> f1 = (x,y,z)=> x +y + z;
           
            float res = f1(10, 12, 13);
            Console.WriteLine(res);
            //Action<int, int, int> a1 = delegate (int x, int y, int z)
            //{
            //    Console.WriteLine(x + y + z);
            //};
            Action<int, int, int> a1 = (x, y, z) => Console.WriteLine(x+y+z);
        
            a1(12, 23, 24);
            //Predicate<string> p1 = delegate (string s)
            //{
            //    if (s.Length > 5) return true;
            //    else return false;
            //};
            Predicate<string> p1 = (s)=>
            {
                if (s.Length > 5) return true;
                else return false;
            };
            bool b1= p1("shrikant");
            Console.WriteLine(b1);

            Console.ReadLine();
        }
    }
}
