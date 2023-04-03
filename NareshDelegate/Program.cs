using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshDelegate
{
    public delegate void AddDel(int x,int y);
    public delegate string SayHello(string s);
    class Program
    {
        static void Main(string[] args)
        {
            shrikant shri = new shrikant();
            AddDel d1 = shri.AddNum;
            d1(20,30);
            SayHello d2 = shri.SayHello;
           string res= d2("shrikant ");
            Console.WriteLine(res);
            Console.ReadLine();
        }

        public class shrikant
        {
            public void AddNum(int x, int y)
            {
                Console.WriteLine($"Addition:{x + y}");
            }
            public string SayHello(string s)
            {
                return "Hello " + s;
            }
        }
       
    }
}
