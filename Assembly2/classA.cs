using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//access specifiers
/*
 * controls accessiblity of type or type members
 * -type like class,struct,interface,delegate etc
 * -type member like feild, constructor,method,property ,indexer
 * 1.private-we can access private member only inside same class
 *          -within same type
 *          -by default member access specifier is private
 * 2.protected-accessible within same type as well as from derived type
 *            -that derived type can be from same assembly or from different assembly 
 * 3.public--any where from application
 *         --same assembly or from any assembly(of same project)
 *         big scope=public
 * 4.internal--type bydefault--internal
 *           -- accessible within same assembly(project)
 * 5.protected internal--it is combination of protected or internal
 *              --due to internal accessible within same assemlby
 *              --due to protected accessible within derived type it can be
 *              from different assembly
 * with type(inside namespace)--public or internal--defualt--internal
 * with type member(inside type)--all acess specifier ...defualt--private
 * */
namespace Assembly2
{
  public class A
    {
       public void printA() { Console.WriteLine("A"); }//by default private
    }
   public class B:A
    {
       
 
        void printB() {
            //A a = new A();
            printA();
            Console.WriteLine("B");
        
        }
    }
  public  class c
    {
        public c()
        {
            A a = new A();
            a.printA();
        }
    }
}
