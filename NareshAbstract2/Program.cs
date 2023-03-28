using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshAbstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            rectagle r = new rectagle(12.3,26.2);
            circle c = new circle(12);
            triangle t = new triangle(20,30);
            cone cn = new cone(10,15);
            Console.WriteLine($"area of rectangle:{r.area()}");
            Console.WriteLine($"area of circle:{c.area()}");
            Console.WriteLine($"area of triangle:{t.area()}");
            Console.WriteLine($"area of cone:{cn.area()}");

            figure fr = c;//base class reference varible pointing to derived class object can access the method of derived class
            Console.WriteLine(fr.area());
            Console.ReadLine();
        }
    }
   public abstract class figure
    {
        public double radius, height, width;
       public  const float pi = 3.14f;
        public abstract double area();
    }
    public class rectagle:figure
    {
        public rectagle(double height,double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double area()
        {
            return height * width;
        }
    }
   public class circle:figure
    {
        public circle(double radius)
        {
            this.radius = radius;
        }
        public override double area()
        {
            return pi * radius * radius;
        }
    }
    public class triangle:figure
    {
        public triangle(double height,double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double area()
        {
            return 0.5 * height * width;
        }
    }
   public class cone:figure
    {
        public cone(double radius,double width)
        {
            this.width = width;
            this.radius = radius;
        }
        public override double area()
        {
            return pi * (radius*radius+width*radius);
        }
    }
}
