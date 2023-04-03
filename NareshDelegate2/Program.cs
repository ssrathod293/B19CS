using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshDelegate2
{
    public delegate void AreaDel(double l,double w);
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            AreaDel del = r.RectArea;
            del += r.RectPerimeter;//bind the delegate and invoke it
            //del(12.56,15.67);
            del.Invoke(12.33,18.89);
            Console.ReadLine();

        }
        
    }
    public class Rectangle
    {
        public void RectArea(double l,double w)
        {
            Console.WriteLine($"Rectangle Area:{l*w}");
        }
        public void RectPerimeter(double l,double w)
        {
            Console.WriteLine($"rectangle perimeter:{2*(l+w)}");
        }
    }
}
