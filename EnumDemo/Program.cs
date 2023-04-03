using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Candidate c1 = new Candidate() { Name = "shrikant", University = "suk", Specialization = 1 };
            Console.WriteLine($"Name:{c1.Name} University:{c1.University} Specializatio:{GetSpecialization(c1.Specialization)}");
            Candidate c2 = new Candidate() { Name = "balaji", University = "srtm", Specialization = 2 };
            Console.WriteLine($"Name:{c2.Name} University:{c2.University} Specializatio:{GetSpecialization(c2.Specialization)}");
            */

            /*
            Candidate c1 = new Candidate()
            { Name = "shri", University = "srtm", Specialization = Specialization.BTECH };
            Console.WriteLine($"Name:{c1.Name} University:{c1.University} Specializatio:{c1.Specialization}");

            Candidate c2 = new Candidate()
            { Name = "jayshri", University = "mit", Specialization = Specialization.BE };
            Console.WriteLine($"Name:{c2.Name} University:{c2.University} Specializatio:{c2.Specialization}");

            Candidate c3 = new Candidate()
            { Name = "baban", University = "suk", Specialization = Specialization.BSC };
            Console.WriteLine($"Name:{c3.Name} University:{c3.University} Specializatio:{c3.Specialization}");
            */
            //to get uderline type
            Type t=   Enum.GetUnderlyingType(typeof(Specialization));
            Console.WriteLine($"Namespace:{t.Namespace}"+$"Name:{t.Name}");
            //to get all text all names from enum
            string[] names=Enum.GetNames(typeof(Specialization));
            foreach (var item in names)
            {
                Console.Write(item+" ");

            }
            Console.WriteLine();
            //to get all values
            int[] values= (int[])Enum.GetValues(typeof(Specialization));
            for (int i = 0; i <values.Length; i++)
            {
                Console.Write($"{values[i]}  ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
         static string GetSpecialization(int s)
        {
            switch (s)
            {
                case 1:

                    return "B.E";
                    
                case 2:
                    return "BTECH";
                    
                case 3:
                    return "B.A";

                default:
                    return "NOT QUALIFIED";

            }
        }
    }
    //public class Candidate
    //{
    //    public string Name { get; set; }
    //    public string University { get; set; }
    //    public int Specialization { get; set; }
    //}
    public class Candidate
    {
        public string Name { get; set; }
        public string University { get; set; }
        public Specialization Specialization { get; set; }
    }

    //public enum Specialization:byte..we can customize it
    public enum Specialization
    {
        //BE,BTECH,BA,BCA,BSC
        //BE=10,BTECH,BA,BCA,BSC
       // BE=10,BTECH=20,BA=30,BCA=40,BSC=50
        BE=10,BTECH=20,BA=30,BCA,BSC
    }
}
