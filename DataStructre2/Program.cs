using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructre2
{
    class Program
    {
        //enum Weekday { Monday=5, Tuesday, Wensday, Thursday, Friday, Saturday, Sunday };

        static void Main(string[] args)
        { /*
            foreach (var i in Enum.GetValues(typeof(Weekday)))
            {
                Console.WriteLine(i);
            }*/
            //////////////////////////////////////////////
            /*
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("key1","value1");
            dictionary.Add("key2","value2");
            dictionary.Add("key3","value3");
            dictionary.Add("key4","value4");
            /*
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine(key);
                
            }
            foreach (var value in dictionary.Values)
            {
                Console.WriteLine(value);

            }

            dictionary.Remove("key1");
            if (dictionary.ContainsKey("key4"))
            {
                Console.WriteLine(dictionary["key4"]);
            }
            // Console.WriteLine(dictionary.Count);
            */
            ////////////////////////////////////////////////////////////
            ///dictionary
            /*
            HashSet<string> string1 = new HashSet<string>() {"a","b","c","d" };
            HashSet<string> string2 = new HashSet<string>() {"e","f","g","h","a","b" };

            //string1.UnionWith(string2);
            //string1.IntersectWith(string2);
            //string1.ExceptWith(string2);
            string1.SymmetricExceptWith(string2);

            foreach (var item in string1)
            {
                Console.WriteLine(item);
            }*/
            //////////////////////////////////////////////////////////////
            ///sorted list
            /*SortedList<string, int> sortedlist = new SortedList<string, int>()
            { {"key1", 1},{"key2",2 },{"key3", 3} };
            sortedlist.Capacity = 6;
            Console.WriteLine(sortedlist.Count);
            foreach (var item in sortedlist.Values)
            {
                Console.WriteLine(item);
            }
            sortedlist.Add("key4",4);
            sortedlist.RemoveAt(0);*/
            /////////////////////////////////////////////
            /*
            SortedSet<int> sortedset = new SortedSet<int>();
            sortedset.Add(3);
            sortedset.Add(1);
            sortedset.Add(5);
            sortedset.Add(6);
           /* foreach (var item in sortedset)
            {
                Console.WriteLine(item);
            }
            sortedset.RemoveWhere(x=>x>3);*/
            /////////////////////////////////////////////////////
            ///tuples
            //Tuple<int> tuple = Tuple.Create(1);
            /*
            Tuple<int> tuple = new Tuple<int>(1);
            Tuple<int,int> tuple2 = new Tuple<int,int>(1,2);
            Tuple<int,int,int> tuple3 = new Tuple<int,int,int>(1,2,3);
            Tuple<int,int,int,int> tuple4 = new Tuple<int,int,int,int>(1,2,3,4);
            */

            ////////////////////////////////////////////////////////
            ///link list
            

            Console.ReadLine(); 
        }

    }
}
