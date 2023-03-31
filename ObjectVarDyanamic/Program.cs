using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectVarDyanamic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region with type name
            /*  int i = 10;
              string s = "abc";
              char c = '$';
              bool b = true;
              Student s1 = new Student();
              Student[] students = new Student[2];*/
            #endregion
            #region object type
            /*object i = 10;
            object s = "abc";
            object c = '$';
            object b = true;
            object s1 = new Student();
            //s1.print();//object type doesnt have print method
            ((Student)s1).print();
            object[] students = new Student[2];*/
            #endregion
            #region var keword
            /* int i = 10;
             string s = "abc";
              char c = '$';
              bool b = true;
              Student s1 = new Student();
             Student[] students = new Student[2];
             //anonymous type..type without name
             //for ex..new{Id=10,Name="Vishal"};
            //object v7 = new { Id=10,name="vishal"};
             // Console.WriteLine($"{v7.Id}-{v7.name}");

             //var keyword..implicit type local varible
             //it is introduced for any anonymous method
             var v7 = new { Id = 10, name = "vishal" };
             Console.WriteLine($"{v7.Id}-{v7.name}");*/
            #endregion
            #region var scenario
            /* //check type at compile time depending on value it is pointing
             //it is mandatory assign or intialize var keyword
             //var j;//not possible
             //var j=null;//cant assign null value because it cant decide which type of value var is pointing
             var i = 10;
             Console.WriteLine($"{i.GetType().Name}");
             //i = "Nikita";//not possible
             var s = "abc";
             var c = '$';
             var b = true;
             var s1 = new Student();s1.print();
             var students = new Student[2];*/
            #endregion
            #region dynamic keyword
            /*
             * it check type at runtime
             * it used in generic
             * it wont give error at compile time but at runtime exception can occured
             * it is used when we dont know which type value will come
             * dont give intellisense
             * */
            /* dynamic i = 10;
             Console.WriteLine($"{i.GetType().Name}");
             Console.WriteLine($"{i}");
             i = "VHAASH";
             Console.WriteLine($"{i.GetType().Name}");
             Console.WriteLine($"{i}");
             dynamic s = "abc";
             dynamic c = '$';
             dynamic b = true;
             dynamic s1 = new Student(); 
             s1.print();
             //s1.shubam(); run time exception will occure
             dynamic students = new Student[2];
             dynamic d = new { RollNUmber=101,Name="Vinay"};
             Console.WriteLine($"{d.RollNUmber}--{d.Name}");*/
            #endregion

            //object o1 = 10;
            //Console.WriteLine(o1);//10
            //o1 = "ABC";
            //Console.WriteLine(o1);//ABC

            //below code compile time error
            //var o2 = 10;
            //Console.WriteLine(o2);
            //o2 = "XYZ";
            //Console.WriteLine(o2);

            //dynamic o3 = 10;
            //Console.WriteLine(o3);//10
            //o3 = "PQR";
            //Console.WriteLine(o3);//PQR
            //Console.ReadLine();
        }
    }
    public class Student
    {
        //int rollnumber;
        //var rollnumber;//not possible
        //var cant be used within class
        
        
        public void print()
        {
            Console.WriteLine("PRINT");
        }
        //cant use var with parameter
        //main purpose--to use with anonymous type, use with a local variable only
       /* public void printA(var i)
        {
            Console.WriteLine("PrintA");
        }*/
    }
}
