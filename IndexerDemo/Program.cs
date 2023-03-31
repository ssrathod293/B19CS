using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(10, "shrikant", "s@sgmail.com", "nanded");
            Student s2 = new Student(11, "baban", "b@bgmil.com", "mukhed");
            Student s3 = new Student(12, "balaji", "b@b.com", "junna");
            Student s4 = new Student(13, "jaypal", "j@j.com", "mukhed");
            Student s5 = new Student(14, "omkar", "o@om.com", "nanded");
            Student[] students = new Student[] { s1, s2, s3, s4, s5 };
            /*
            Student s = students[4];
            Console.WriteLine($"RollNumber:{s.RollNumber}" +
                $" Name:{s.Name}" + $" Email:{s.Email}" +
                $" City:{s.City}");*/
            Institute seed = new Institute(students);
            seed.PrintAllStudents();
            Console.WriteLine("------------------------------------------------");
            //return student object which has 10 as rollnumber
            Student ss = seed[13];//object item wants to access item index

            Console.WriteLine($"RollNumber:{ss?.RollNumber}" +
                $" Name:{ss?.Name}" + $" Email:{ss?.Email}" +
                $" City:{ss?.City}");

            Student s6 = new Student(14, "suraj panchal", "s@s.com", "latur");

            seed[13] = s6;//set
            Console.WriteLine("------------------------------------------------");
            //return student object which has 10 as rollnumber
            Student sss = seed[13];//object item wants to access item index

            Console.WriteLine($"RollNumber:{sss?.RollNumber}" +
                $" Name:{sss?.Name}" + $" Email:{sss?.Email}" +
                $" City:{sss?.City}");
            Console.WriteLine("-------------------------------------------------------");
            Student sc = seed["baban"];
            Console.WriteLine($"RollNumber:{sc?.RollNumber}" +
               $" Name:{sc?.Name}" + $" Email:{sc?.Email}" +
               $" City:{sc?.City}");
            Student s7 = new Student(10, "balu", "b@b.com.com", "barahli");
            seed["shrikant"] = s7;
            Console.WriteLine("-----------------------------------------");
            Student sc1 = seed["shrikant"];
            Console.WriteLine($"RollNumber:{sc1?.RollNumber}" +
              $" Name:{sc1?.Name}" + $" Email:{sc1?.Email}" +
              $" City:{sc1?.City}");

            Console.ReadLine();
        }
    }
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public Student(int rn, string name, string email, string city)
        {
            RollNumber = rn;
            Name = name;
            Email = email;
            City = city;

        }
    }
    public class Institute
    {
        public int InstituteName { get; set; }
        public int location { get; set; }
        public Student[] students;
        public Institute(Student[] studs)
        {
            students = studs;
        }

        public Student this[int rn]
        {
            get
            {
                if (students != null && students.Length > 0)
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        Student s = students[i];
                        if (s.RollNumber == rn)
                        {
                            return s;
                        }
                    }
                }
                return null;
            }
            set
            {
                if (students != null && students.Length > 0)
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        Student s = students[i];
                        if (s.RollNumber == rn)
                        {
                           
                            s.Name = value.Name;
                            s.Email = value.Email;
                            s.City = value.City;
                        }
                    }
                }
            }
        }
       public Student this[string name]
        {
            get
            {
                if (students != null && students.Length > 0)
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        Student s = students[i];
                        if (s.Name ==name)
                        {
                            return s;
                        }
                    }
                }
                return null;
            }
            set
            {
                if (students != null && students.Length > 0)
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        Student s = students[i];
                        if (s.Name == name)
                        {
                            s.RollNumber = value.RollNumber;
                            //s.Name = value.Name;
                            s.Email = value.Email;
                            s.City = value.City;
                        }
                    }
                }
            }
        }
        public void PrintAllStudents()
        {
            if (students != null && students.Length > 0)
            {
                for (int i = 0; i < students.Length; i++)
                {
                    Student s = students[i];
                    Console.WriteLine($"RollNumber:{s.RollNumber}" +
                        $" Name:{s.Name}" + $" Email:{s.Email}" +
                        $" City:{s.City}");
                }
            }
            else
            {
                Console.WriteLine("no students");
            }
        }

    }
}
