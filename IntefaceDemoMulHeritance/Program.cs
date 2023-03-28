using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntefaceDemoMulHeritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IA ia = new AB();
            ia.print();
            IB ib = new AB();
            ib.print();
            AB ab = new AB();
            ((IA)ab).print();
            ((IB)ab).print();
            Console.ReadLine();
        }
    }
   public interface IA
    {
        void print();
    }
   public interface IB
    {
        void print();
    }
    class AB:IA,IB
    {
       void IA.print()
        {
            Console.WriteLine("printA");
        }
        void IB.print()
        {
            Console.WriteLine("printB");
        }
    }
}
