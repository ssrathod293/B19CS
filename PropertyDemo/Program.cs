using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//property are used to encapsulate and protect the private fields
//before property we used to write getter and setter method
//it is difficult to maintian get and set
//naming convention is important in get and set
//for each feild there will be two method get and set
//property has get and set access modifiers
//when we assign a value to property set logic will get execute
//when we read a value from property get logic will get execute
//property does not have parameter
//property we write like method but we access it like a public field
//property with get and set...read and write property
//property with get..read only property
//property with set...write only property
namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region student object
            /*
            student s1 = new student();
            s1.rollNumber = 51;//set values/assigning values
            s1.Name = "shrikant";//se/assigning values
            s1.Passmark = 40;//set/assigning values
            //get values/reading values
            Console.WriteLine($"RollNumber:{s1.rollNumber}Name:{s1.Name}Passmark{s1.Passmark}");
            */
            #endregion
            #region object problem
            //student s1 = new student();
            //s1.rollNumber = -1;//set values/assigning values
            //s1.Name = null;//se/assigning values
            //s1.Passmark = 18;//set/assigning values
            ////get values/reading values
            //Console.WriteLine($"RollNumber:{s1.rollNumber}Name:{s1.Name}Passmark{s1.Passmark}");
            #endregion
            #region object with get and set method
            //student s1 = new student();
            //s1.rollNumber = -1;//set values/assigning values
            //s1.Name = null;//se/assigning values
            //s1.Passmark = 18;//set/assigning values
            //get values/reading values
            //s1.SetRollNumber(25);
            // s1.SetName("Shrikant");
            //Console.WriteLine($"RollNumber: {s1.GetRollNumber()} Name{s1.GetName()}:Passmark:{s1.GetPassmark()}");
            #endregion

            student s1 = new student();
            s1.RollNumber = 51;//set values/assigning values
            s1.Name = "shrikant";//se/assigning values
            //s1.Passmark = 40;//set/assigning values
            //get values/reading values
            Console.WriteLine($"RollNumber:{s1.RollNumber}Name:{s1.Name}Passmark{s1.Passmark}");
            

            Console.ReadLine();



        }
    }
    #region student version1
    //public class student
    //{
    //    //feilds//class feilds//data members
    //    //rollnumber cannot be negative
    //    public int rollNumber;
    //    //if name is null, show no name to user if null
    //    public string Name;
    //    //pass mark should not be changed,it should be readonly
    //    //public const int passmark=40;
    //    public int Passmark;
    //}
    #endregion
    #region student version 2
    //public class student
    //{
    //    //feilds//class feilds//data members
    //    //rollnumber cannot be negative
    //    private int rollNumber;
    //    //if name is null, show no name to user if null
    //    private string Name;
    //    //pass mark should not be changed,it should be readonly
    //    //public const int passmark=40;
    //    private readonly int Passmark=40;

    //    public void SetRollNumber(int rn)
    //    {
    //        if (rn>0) {
    //            this.rollNumber = rn;
    //        }
    //        else
    //        {
    //            rollNumber = 0;
    //            Console.WriteLine("Roll number is invalid");
    //        }
    //    }
    //    public int GetRollNumber()
    //    {
    //        return rollNumber;
    //    }

    //    public void SetName(string n)
    //    {
    //        Name = n;
    //    }
    //    public string GetName()
    //    {
    //        return !(Name == null) ? Name : "NO NAME";
    //    }

    //    public int GetPassmark()
    //    {
    //        return Passmark;
    //    }
    //}
    ////no one should change passmark..no need setpassmark passmark
    #endregion
    public class student
    {
        //feilds//class feilds//data members
        //rollnumber cannot be negative
        private int _rollNumber;

        //if name is null, show no name to user if null
        private string _name;
        //pass mark should not be changed,it should be readonly
        //public const int passmark=40;
        private readonly int _passmark = 40;

        public int RollNumber
        {
            get
            {
                return _rollNumber;
            }
            set
            {
                if (value > 0)
                {
                    this._rollNumber = value;
                }
                else
                {
                    _rollNumber = 0;
                    Console.WriteLine("Roll number is invalid");
                }
               
            }
        }
      public string Name
        {
            get
            {
                return !(_name == null) ? _name : "NO NAME";
            }
            set
            {
                _name = value;
            }
        }

     public int Passmark
        {
            get { return _passmark; }
        }

       
    }
    //no one should change passmark..no need setpassmark passmark


}
