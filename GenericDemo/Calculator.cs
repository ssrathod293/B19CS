using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Calculator
    {
        #region method Overloading
        /* public bool AreEqual(int a, int b)
         {
             return a.Equals(b);
         }
         public bool AreEqual(string a, string b)
         {
             return a.Equals(b);
         }*/
        #endregion
        #region Object as Parameter
        //1--no type safe
        //2--there are chances of boxing and unboxing
        //generic..allows us to desing classes methods interfaces etc decoupled from datatypes
        //decouple m
        //public bool AreEqual(object a,object b)
        //{
        //    return a.Equals(b);
        //}
        #endregion
        #region generic
        public bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
        public void AreEqualA<Tin,Tout>(Tin a, Tin b,out Tout result)
        {
            //return a.Equals(b);
            //1 way --error
            //object o = a.Equals(b);
            //result = (bool)o;

            //2 way--error
            // var o = a.Equals(b);
            //result = o;

            //1 way --error
            dynamic o = a.Equals(b);
            result = o;

        }
        #endregion
    }
    public class AdvanceCal<T1in,T2in,Tout>
    {
        public Tout add(T1in a,T2in b)
        {
            dynamic n1 = a, n2 = b;
            dynamic result = n1+n2;//runtime
            return result;
        }
        public Tout sub(T1in a, int b)
        {
            dynamic n1 = a, n2 = b;
            dynamic result = n1 - n2;//runtime
            return result;
        }
    }
}
