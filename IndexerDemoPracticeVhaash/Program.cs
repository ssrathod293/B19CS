using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemoPracticeVhaash
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(10,"shrikant","shri@g.com","pune");
            Student s2 = new Student(11,"jayshree","jay@g.com","hyderabad");
            Student s3 = new Student(12,"bunty","bunty@g.com","rajasthan");
            Student s4 = new Student(13,"arati","arati@g.com","madnur");
            Student s5 = new Student(14,"akshita","aksita@g.com","mukhed");
            Student s6 = new Student(15,"balaji","balaji@g.com","junna");
            Student[] students = new Student[] { s1, s2, s3, s4, s5, s6 };

           /* Student s = students[1];
            Console.WriteLine($"Rollnumber:{s.Rollumber} Name:{s.Name} Email:{s.Email} City:{s.City}");*/

            Institute seed = new Institute(students);
            seed.printAllStudent();
            Console.WriteLine("------------------------------------------get value ---------------------------------------");
            Student ss = seed[12];//return object has roll number 12
            Console.WriteLine($"Rollnumber:{ss?.Rollumber} Name:{ss?.Name} Email:{ss?.Email} City:{ss?.City}");
            Console.WriteLine("-----------------------------------------set value------------------------------------------------");
            Student s7 = new Student(20, "jaypal", "jay@g.com", "junna");
            seed[14] = s7;
            Student sss = seed[14];
            Console.WriteLine($"Rollnumber:{sss?.Rollumber} Name:{sss?.Name} Email:{sss?.Email} City:{sss?.City}");
            Console.WriteLine("---------------------------------after setting value---------------------------------------------------------------");
            seed.printAllStudent();
            Console.WriteLine("--------------------------------------get and set value using name--------------------------------------------");
            Student sc = seed["jayshree"];
            Console.WriteLine($"Rollnumber:{sc?.Rollumber} Name:{sc?.Name} Email:{sc?.Email} City:{sc?.City}");
            Console.WriteLine("--------------------------------------set value-------------------------");
            Student s8 = new Student(30, "omkar", "oam@g.com", "umra");
            Student sc1 = s8;
            Console.WriteLine($"Rollnumber:{sc1?.Rollumber} Name:{sc1?.Name} Email:{sc1?.Email} City:{sc1?.City}");
            seed["balaji"] = s8;
            Console.WriteLine("-------------------------------------- after set value-------------------------");
            seed.printAllStudent();
            Console.ReadLine();
        }
    }
    public class Student
    {
        public int Rollumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public Student(int rn,string name,string email,string city)
        {
            this.Rollumber = rn;
            this.Name = name;
            this.Email = email;
            this.City = city;
        }
    }
    public class Institute
    {
        public string InstName { get; set; }
        public string location { get; set; }
        public Student[] students;
        public Institute(Student[] stud)
        {
            students = stud;
        }

        public Student this[int rn]
        {
            get
            {
                if (students!=null && students.Length>0)
                {
                    for (int i=0;i<students.Length;i++)
                    {
                        Student s = students[i];
                        if (s.Rollumber==rn)
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
                        if (s.Rollumber == rn)
                        {
                            s.Rollumber = value.Rollumber;
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
                        if (s.Name == name)
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
                        if (s.Name ==name)
                        {
                            s.Name = value.Name;
                            s.Rollumber = value.Rollumber;
                            s.Email = value.Email;
                            s.City = value.City;
                        }
                    }
                }

            }
        }


        public void printAllStudent()
        {
            if(students!=null&&students.Length>0)
            {
                for (int i=0;i<students.Length;i++)
                {
                    Student s = students[i];
                    Console.WriteLine($"Rollnumber:{s.Rollumber} Name:{s.Name} Email:{s.Email} City:{s.City}");
                }
            }
            else
            {
                Console.WriteLine("No student avialable to print");
            }
        }
    }

}
