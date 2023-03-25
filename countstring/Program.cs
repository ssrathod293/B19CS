using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countstring
{
    class Program
    {


        static void Main(string[] args)

        {

            Console.WriteLine("Enter x and y");
            int x=Convert.ToInt32( Console.ReadLine());
            int y=Convert.ToInt32( Console.ReadLine());
           string res= x > y ? "x greter than y" :
                x < y ? "y greater than x" :
                x == y ? "x is equal to y" : "No result";
            Console.WriteLine(res);

            ///////////////////////////////////////////////////////////////////////
            /*
             string input = "Hello World!";
            Dictionary<char, int> letterCounts = CountRepeatedLetters(input);
            foreach (var kvp in letterCounts)
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }  
         
            */
            /*
                        Console.WriteLine("Enter the string:");
                        string str=Console.ReadLine();
                        Console.WriteLine(str);
                        Console.WriteLine("letters count with repeated:" + "=");


                        //Countstring(str);


                        while (str.Length > 0)
                        {
                            Console.Write(str[0] + "=");
                            int cal = 0;
                            for (int j = 0; j < str.Length; j++)
                            {
                                if (str[0] == str[j])
                                {
                                    cal++;
                                }
                            }
                            Console.WriteLine(cal);
                            str = str.Replace(str[0].ToString(), string.Empty);
                        }
                     */
            Console.ReadLine();

        }
   
        //using dictionary
        public static Dictionary<char, int> CountRepeatedLetters(string input)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                {
                    continue; // skip non-letter characters
                }
                char lowerC = Char.ToLower(c); // case-insensitive comparison
                if (letterCounts.ContainsKey(lowerC))
                {
                    letterCounts[lowerC]++;
                }
                else
                {
                    letterCounts[lowerC] = 1;
                }
            }
            return letterCounts;
        }

    }
}

