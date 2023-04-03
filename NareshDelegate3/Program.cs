using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshDelegate3
{
    public delegate string MessageDel(string s);
    class Program
    {
        static void Main(string[] args)
        {
            //using anonymous method
            //MessageDel del = delegate (string s)
            //{
            //    return "HI " + s + " Shrikant";
            //};

            MessageDel del = ( s)=>
            {
                return "HI " + s + " Shrikant";
            };


            string res = del("I'am");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
