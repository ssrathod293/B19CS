using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101,"Shrikant","Engineer","Developer","Pune",37500);
            Console.WriteLine($"Eno:{emp[0]}");
            Console.WriteLine($"Ename:{emp[1]}");
            Console.WriteLine($"Job:{emp[2]}");
            Console.WriteLine($"Dname:{emp[3]}");
            Console.WriteLine($"Location:{emp[4]}");
            Console.WriteLine($"Salary:{emp[5]}");
            Console.WriteLine("-------------------------------------------------------------");
            emp[1]= "jayshri";
            emp[5] = 45000;
            Console.WriteLine($"Eno:{emp[0]}");
            Console.WriteLine($"Ename:{emp[1]}");
            Console.WriteLine($"Job:{emp[2]}");
            Console.WriteLine($"Dname:{emp[3]}");
            Console.WriteLine($"Location:{emp[4]}");
            Console.WriteLine($"Salary:{emp[5]}");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Eno:{emp["Eno"]}");
            Console.WriteLine($"Ename:{emp["Ename"]}");
            Console.WriteLine($"Job:{emp["job"]}");
            Console.WriteLine($"Dname:{emp["Dname"]}");
            Console.WriteLine($"Location:{emp["location"]}");
            Console.WriteLine($"Salary:{emp["salary"]}");
            Console.WriteLine("-----------------------------------------------------------------------------");
            emp["Ename"] = "Jayshri Rathod";
            emp["job"]= "QA Engineer";
            emp["Dname"]= "Testing Engg";
            emp["location"]= "Hyderabad";
            Console.WriteLine($"Eno:{emp["Eno"]}");
            Console.WriteLine($"Ename:{emp["Ename"]}");
            Console.WriteLine($"Job:{emp["job"]}");
            Console.WriteLine($"Dname:{emp["Dname"]}");
            Console.WriteLine($"Location:{emp["location"]}");
            Console.WriteLine($"Salary:{emp["salary"]}");
            Console.ReadLine();
        }
    }

   public class Employee
    {
        int Eno;
        string Ename, job, Dname, location;
        double salary;
        public Employee(int eno,string ename,string job,string dname,string location,double salary)
        {
            this.Eno = eno;
            this.Ename = ename;
            this.job = job;
            this.Dname = dname;
            this.location = location;
            this.salary = salary;
        }

       public object this [int index]
        {
            get
            { 
                if (index == 0) return Eno;

                else if (index == 1) return Ename;
                else if (index == 2) return job;
                else if (index == 3) return Dname;
                else if (index == 4) return location;
                else if (index == 5) return salary;
                return null;
            }
            set
            {
                if (index==0)  Eno=(int)value;

                else if (index == 1) Ename=(string)value;
                else if (index == 2)  job= (string)value;
                else if (index == 3) Dname= (string)value;
                else if (index == 4) location= (string)value;
                else if (index == 5) salary= (int)value;                
            }
        }
        public object this[string name]
        {
            get
            {
                if (name=="Eno") return Eno;

                else if (name=="Ename") return Ename;
                else if (name=="job") return job;
                else if (name=="Dname") return Dname;
                else if (name=="location") return location;
                else if (name=="salary") return salary;
                return null;
            }
            set
            {
                if (name == "Eno") Eno=(int)value;

                else if (name == "Ename") Ename=(string)value;
                else if (name == "job") job=(string)value;
                else if (name == "Dname") Dname=(string)value;
                else if (name == "location") location=(string)value;
                else if (name == "salary") salary=(int)value;
            }
        }
    }
}
