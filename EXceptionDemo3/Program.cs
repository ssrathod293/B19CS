using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXceptionDemo3
{
    class Program
    {
        static void Main(string[] args)
        {

            string choice = string.Empty;
            do
            {
                Console.WriteLine("please enter numurator:");
                //int x = Convert.ToInt32(Console.ReadLine());
                int x;
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("please enter denominator:");
                    int y;
                    if (int.TryParse(Console.ReadLine(), out y))
                    {
                        calculator c = new calculator();
                        c.Division(x, y);
                    }
                    else
                    {
                        Console.WriteLine("plz enter valid denominator");
                    }

                }
                else
                {
                    Console.WriteLine("plz enter valid numerator");
                }
                Console.WriteLine("Do You want to continue:");
                choice=Console.ReadLine().ToUpper();
            } while (choice=="Y");
                

            Console.ReadLine();

        }
    }
    
    public class calculator
    {
        public void Division(int x, int y)
        {
            try
            {
                if (y != 0)
                {
                    var div = x / y;
                    Console.WriteLine($"Division:{x}/{y}={div}");
                }
                else
                {
                    // Console.WriteLine($"Division:{x}/{y}=infinity");
                    Console.WriteLine("denominator cant be zero");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("division operation completed");
            }
        }
    }
}

