using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton s1 = new Singleton();
            //Singleton s2 = new Singleton();
            //Singleton s3 = new Singleton();
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            Singleton s3 = Singleton.Instance();

            if (s1==s2)
            {
                Console.WriteLine("s1 and s2 are equal");
            }
            else
            {
                Console.WriteLine("s1 and s2 are not equal");
            }
            if (s2 == s3)
            {
                Console.WriteLine("s2 and s3 are equal");
            }
            else
            {
                Console.WriteLine("s2 and s3 are equal");
            }
            Singleton s4 = Singleton.Instance();
            if (s4==null)
            {
                Console.WriteLine("4th object creation not allowed");
            }
            Console.ReadLine();
        }

        //public class Singleton
        //{
        //    static Singleton _obj = null;
        //    private Singleton()
        //    {

        //    }

        //   public static Singleton Instance()
        //    {
        //        if (_obj==null)
        //        {
        //            _obj = new Singleton();
        //         }
        //        return _obj;
        //    }


        //}

        public class Singleton
        {
            static Singleton _obj = null;
            static public int counter=1;
            private Singleton()
            {

            }

            public static Singleton Instance()
            {
                if (counter>=3)
                {
                    _obj = new Singleton();
                    counter++;
                    return _obj;
                }
                else
                {
                    _obj = null;
                    return _obj;
                }
                
            }


            }
        }
}
