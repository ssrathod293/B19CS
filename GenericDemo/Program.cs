using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region calclator
            /* Calculator c = new Calculator();
             bool b=c.AreEqual(10, 20);
             Console.WriteLine(b);
             b = c.AreEqual("Shrikant","rathod");
             Console.WriteLine(b);
             b = c.AreEqual(10.5f, 20.3);
             Console.WriteLine(b);
             //b = c.AreEqual(10.5f, "shrikant");
             //Console.WriteLine(b);
             b = c.AreEqual<char>('A','A');
             Console.WriteLine(b);
             c.AreEqualA(10,10,out b);
             Console.WriteLine(b);*/
            #endregion

            AdvanceCal<int, int, int> acal = new AdvanceCal<int, int, int>();
            Console.WriteLine(acal.add(10,20));

            AdvanceCal<string, string, string> acal3 = new AdvanceCal<string, string, string>();
            Console.WriteLine(acal3.add("A", "B"));

            AdvanceCal<double, double, double> acal1 = new AdvanceCal<double, double, double>();
            Console.WriteLine(acal1.add(10.22, 20.34));

            AdvanceCal<double, double, double> acal2 = new AdvanceCal<double, double, double>();
            Console.WriteLine(acal1.sub(10.22, 20));

            Console.ReadLine();
        }
    }
}
