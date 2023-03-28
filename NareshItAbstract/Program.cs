using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshItAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //absParent ab = new absParent();we cant create instance of abstract class
            //abstract method and non abstract method can be accessed by using instance of derived class
            absChild ch = new absChild();
            ch.add(10,20);ch.sub(30,10);ch.mul(6,8);ch.div(50,10);
            absParent ab = ch;
            ab.add(23,14);
            //referece variable of parent class pointing to base instance can access base class methods
            Console.ReadLine();
        }
  
  }
   abstract class absParent
    {
    public void add(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public void sub(int x,int y)
        {
            Console.WriteLine(x-y);
        }
        abstract public void mul(int x, int y);
        abstract public void div(int x, int y);
       
    }

    class absChild:absParent
    {
        public override void mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
         public override void div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
    }
}
