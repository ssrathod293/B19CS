using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaresItPolymorpism
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string s1 = "Hello";
             string s2 = "World";
             Console.WriteLine(s1+s2);*/
            Matrix m1 = new Matrix(20,18,16,14);
            Matrix m2 = new Matrix(10,15,24,18);
            Matrix m3 = m1 + m2;
            Matrix m4 = m1 - m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.ReadLine();
      
        }
   
    }
}
