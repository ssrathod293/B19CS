using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("welcome to calculator program");
            string choice = string.Empty;
            do
            {
                Calculator c = new Calculator();
                Console.WriteLine("please enter numurator:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter denominator:");
                int y = Convert.ToInt32(Console.ReadLine());
                try
                {
                    c.Division(x, y);
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"outer try :{ex}");
                    Console.WriteLine($"outer try :{ex.GetType().Name}");
                    Console.WriteLine($"outer try :{ex.InnerException.GetType().Name}");
                    Console.WriteLine($"outer try :{ex.Message}");

                }


                Console.WriteLine("Do you want to continue again:");
               choice= Console.ReadLine().ToUpper();
            } while (choice=="Y");

            Console.WriteLine("calculator program completed");
        }
    }
   public class Calculator
    {
        
        public void Division(int x,int y)
        {
            #region try
            //try
            //{
            //    var div = x / y;
            //    Console.WriteLine($"Division:{x}/{y}={div}");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message); ;
            //}
            #endregion
            #region  outer try catch block
            //try
            //{
            //    try
            //    {
            //        var div = x / y;
            //        Console.WriteLine($"Division:{x}/{y}={div}");
            //    }
            //    catch (Exception ex)
            //    {
            //        NullReferenceException exp = (NullReferenceException)ex;
            //        Console.WriteLine($"inner catch{ ex.Message}");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"outer catch{ ex.Message}"); 

            //}

            #endregion

            try
            {
                var div = x / y;
                Console.WriteLine($"Division:{x}/{y}={div}");
            }
            catch (Exception ex)
            {

                //NullReferenceException exp = (NullReferenceException)ex;
                //throw ex;
                throw new Exception("PROBLEM", ex);
                Console.WriteLine($"inner catch: { ex.Message}");
            }
            //lines of code after try catch block
            //finally block--it gives guarantee that code will get executed even if there is an error or not
            //it is very important to close connection with sql,or with server or with any file
            finally
            {
                Console.WriteLine("division operation completed");
            }
        }
    }
}
