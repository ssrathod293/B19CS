using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodDemo
{
    class Program
    {
        public delegate string FullNameDel(string fn,string ln);
        public delegate void addDel(int x,int y);
        static void Main(string[] args)
        {
            FullNameDel d1 = delegate (string fn,string ln)
            {
                string fullName = string.Format($"FullName:{fn} {ln}");
                return fullName;
            };

           string result= d1("shrikant","jayshree");
            Console.WriteLine(result);

            addDel d2 = delegate (int x,int y) {
                Console.WriteLine($"Addition:{x}+{y}={x+y}");
            };
            d2(30,20);
            Console.ReadLine();
        }
    }
}
