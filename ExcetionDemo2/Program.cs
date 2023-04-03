using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcetionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("please enter numurator:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter denominator:");
                int y = Convert.ToInt32(Console.ReadLine());
                calculator c = new calculator();
                c.Division(x, y);
            }
         
            catch (FormatException fex)
            {

                Console.WriteLine($"{fex.Message}"); 
            }
            catch (OverflowException fex)
            {

                Console.WriteLine($"{fex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
    public class calculator
    {
        public void Division(int x, int y)
        {
            try
            {
                if (y!=0) {
                    var div = x / y;
                    Console.WriteLine($"Division:{x}/{y}={div}");
                }
                else
                {
                    Console.WriteLine($"Division:{x}/{y}=infinity");
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
