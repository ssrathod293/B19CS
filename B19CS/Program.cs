using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace B19CS
{
    partial class Program
    {

        static void Main(string[] args)
        {
            #region value type and referance type
            /*
            int i = 10;
            //string s = "Vishal";//referance type

            char[] arr= new char[] { 'A', 'B', 'C', 'D' };

            string s = new string(arr);//referance type

            //value type to referance type=boxing
            object o = new object();
            o = i;//int->object
            Console.WriteLine(o);

            //referance type--value type==unboxing
            //boxing and unboxing are not good for performance
            //it is good to keep our code type safe
            //type--use proper and valid types for values
            //string s1 = "true";
            float f = i;//int--float
            int j =(int) o;
            DateTime current = DateTime.Now;
            Console.WriteLine(j);*/
            #endregion value type and referance type
            //string s1 = "Main";
            /*  string s1 ;

              PrintA(out s1);
              Console.WriteLine(s1);
            */
            #region operation method
            /*
            string choice = " ";
            do
            {
                Console.WriteLine("Please enter the first number:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number:");
                int b = int.Parse(Console.ReadLine());
                int add, sub, mul, div;
                Operation(a, b, out add, out sub, out mul, out div);
                Console.WriteLine($"\n{a}+{b}={add}" +
                    $" \n{a}-{b}={sub}" +
                    $" \n{a}*{b}={mul}" +
                    $"\n{a}/{b}={div}"
                    );
                Console.WriteLine("do you want to continue ");
                choice = Console.ReadLine().ToUpper();
            } while (choice == "Y");
            Console.WriteLine("thank you");
            */
            #endregion operation method
            /*
            int[] n1 = null;
            PrintSum(n1);
            PrintSum(null);
            int[] n2 = new int[] { 10,10,10};
            PrintSum(n2);
            PrintSum(new int[] { 10, 10, 10 });

            PrintSum();//without passing argument

            PrintSum(10,10,10);//comma seperated values

            Sample("jayshree","shrikant","rathod");

            Console.WriteLine("please enter the sentance");
            string sentance = Console.ReadLine();
            Console.WriteLine("Please enter the seperator:");
            char sep=char.Parse(Console.ReadLine());
            //Console.WriteLine(ReverseWord(sentance,sep));
            Console.WriteLine(ReverseWord(sentance));//calling method using optional attribute
            Add(20,30,40);
            // Add(20,40);
            Add(b:20,c:30) ;
            */
            //Console.WriteLine("subhash");
            // PrintX(30);
              
          
            Console.ReadLine();

        }
       

        static void PrintA(out string msg)
        {
            msg = "PrintA";//out parameter should be assigned 
        }

        //write a method which returns addition,substraction,division,multi
        
       static void Operation(int a,int b,out int add,out int sub,out int mul,out int div)
        {
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;
        }
 
        //method to print sum of array
       static void PrintSum( params int[] numbers)
        {
            if (numbers!=null && numbers.Length>0)
            {
                int Sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    Sum += numbers[i];
                }
                Console.WriteLine($"sum of numbers:{Sum}");
            }
            else
            {
                Console.WriteLine("NO ITEMS TO ADD");
            }
        }

        static void Sample(params string[] names)
        {
            for (int i=0;i<names.Length;i++)
            {
                Console.WriteLine($"{names[i]}");
            }
        }

        //static string ReverseWord(string sentance,char seperator=' ')
        static string ReverseWord(string sentance,[OptionalAttribute]char seperator)
        {
           string[] words= sentance.Split(seperator);
            string result = string.Empty;

            for (int i=words.Length-1;i>=0;i--)
            {
                result += words[i] + seperator;
            }
            return result;
        }
    
        static void Add([OptionalAttribute]int a,int b,int c)
        {
            Console.WriteLine($"{a+b+c}");
        }

        static void PrintX(int x)
        {
            if (x==10)
            {
                return;
            }
            else
            {
                Console.WriteLine("Print X Method");
            }
        }
    }
}
