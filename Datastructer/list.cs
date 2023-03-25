using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructer
{
    class list
    {
        static void Main(string[] args)
        {
            //list
            List<int> numbers = new List<int>() { 1, 3, 5, 4, 2 };
            /* Console.WriteLine(numbers.Capacity);
             numbers.Capacity = 10;
             numbers.Add(6);
             List<int> sublist = new List<int>() {7,8 };
             numbers.AddRange(sublist);
             foreach (var item in numbers)
             {
                 Console.Write(item+" ");
             }
             numbers.Sort();
             foreach (var item in numbers)
             {
                 Console.Write(item + " ");
             }
             Console.WriteLine($"number at element 5:{numbers.BinarySearch(5)}");
             Console.WriteLine($"number at element 5:{numbers.Contains(3)}");
             Console.WriteLine($"number at element 5:{numbers.Contains(15)}");
             */
            ///insert
            ///
            /*
            numbers.Insert(0, 9);
            List<int> sublist = new List<int>() { 0, 1, 2 };
            numbers.InsertRange(1, sublist);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }*/
            //remove
            /*
            numbers.Remove(3);
            numbers.RemoveAt(0);
            numbers.RemoveRange(0, 3);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }*/
            ////////capacity
            /*
            numbers.Capacity = 10;
            Console.WriteLine(numbers.Capacity);
            numbers.TrimExcess();
            Console.WriteLine(numbers.Capacity);*/
            ////true for all
            /*
            bool numberlessthan6 = numbers.TrueForAll(x=>x<6);
            Console.WriteLine(numberlessthan6);
            */
            //reverse
            /*
            numbers.Reverse();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }*/
            //for each
            // numbers.ForEach(PrintOutputWindow);

            //Console.WriteLine(numbers.IndexOf(3));
            //int[] arrayofnumers = numbers.ToArray();

            //to store multiple type in list
            /*
            List<object> Multipletype = new List<object>() { 1,"shri",true};
            foreach (var item in Multipletype)
            {
                Console.WriteLine(item);
            }*/

            /* Stack<string> s = new Stack<string>();
             s.Push("a");
             s.Push("b");
             Console.WriteLine(s.Count);*/
            /*
            Stack stack = new Stack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());*/
            //enum weekdays={Monday,Tuesday,Wensday,Thursday,Friday,Saturday,Sunday }
    
   
    Console.ReadLine();

        }


static void PrintOutputWindow(int i)
{
    Console.WriteLine(i);
}

    }
    public class Stack
{
    const int Max = 1000;
    int top;
    object[] stack = new object[Max];

    public Stack()
    {
        top = -1;
    }
    public void push(object obj)
    {
        if (top < Max)
        {
            stack[++top] = obj;
        }
    }
    public object pop()
    {
        if (top >= 0)
        {
            object o = stack[top];
            top--;
            return o;
        }
        else
        {
            return -1;
        }
    }

    public object Peek()
    {
        return stack[top];
    }
}
}

