using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NareshProperty1
{
    public enum City
    {
        Delhi, Mumbai, Chennai, Kolkatta, Bengulur, Hyderabad
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Customer c = new Customer(101,true,"shrikant",9000,"Maharastra","africa",City.Delhi );
            /* Console.WriteLine(c.customerId );
             Console.WriteLine(c.customerId=201 );
             Console.WriteLine(c.customerId);


             Console.WriteLine(c.status);
             Console.WriteLine(c.status=false);

             Console.WriteLine(c.customerName);
             Console.WriteLine(c.customerName="shrikant Rathod");

             Console.WriteLine(c.balance);
             Console.WriteLine(c.balance=20000);*/
            Console.WriteLine(c.customerName="shri");
            if (c.status==true)
            {
                Console.WriteLine("ACTIVE");
            }
            else
            {
                Console.WriteLine("IN-ACTIVE");
            }
            Console.WriteLine(c.customerName);
            c.customerName += "shri";
            Console.WriteLine("Modified name:"+c.customerName);
            Console.WriteLine("Customer balance:"+c.balance);
            c.balance -= 5000;
            Console.WriteLine("Modified Customer balance:"+c.balance);
            c.balance -= 3000;
            Console.WriteLine("Modified Customer balance:" + c.balance);
            Console.WriteLine(c.state);
            Console.WriteLine($"Modified state: { c.state = "karnataka"}");
            Console.WriteLine(c.country);
            Console.WriteLine(c.cities);//accessig cities
            
            Console.WriteLine(c.cities = City.Chennai);
           
            //Console.WriteLine($"Modified state: { c.country = "USA"}");
            Console.ReadLine(); 
        }
    }
    public class Customer
    {
        int _customerId;
        bool _status;
        string _cname;
        double _balance;
        string _state;
        City _cities;
        public Customer(  int customerid,bool status,string cname,double balance,string state,string country,City cities)
        {
            _customerId = customerid;
            _status = status;
            _cname = cname;
            _balance = balance;
            _state = state;
            _cities = cities;
            
        }

        public int customerId
        {
            get
            {
                return _customerId;
            }
            set
            {
                _customerId= value;
            }
        }
        public bool status 
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        public string customerName
        {
            get
            {
                return _cname;
            }
            set
            {
                if (status==true)
                {
                    _cname = value;
                }
                else
                {
                    _cname = null;
                }
            } 
        
        }
        public double balance
        {
            get
            {
                
                return _balance;
            }

            set
            {
                if (status==true) {
                 
                    if (value>=500)
                    {
                        _balance = value;
                    }
                }
            }
        }
        public string state
        {
            get
            {
                return _state;
            }
            set
            {
                if (status==true) {
                    _state = value;
                }
            }
        }
        public string country
        {
            get; set;
        } = "India";
        public City cities
        {
            get
            {
                return _cities;
            }
            set
            {
                if (status==true) {
                    _cities = value;
                }
            }
        }
    }
}
