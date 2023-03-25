using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Programe
    {

        static void Main(string[] args)
        {
            #region base and derived class
            //SilverCustomer sc = new SilverCustomer() { TicketAmount = 100, Screen = "screen1" };
            //sc.ShowTimings();
            //int ta = sc.GetTicketAmount();
            //Console.WriteLine($"silver ticket amount:{ta}");
            //sc.PrintTicket();
            /////////////////////////////////////////////
            //GoldenCustomer gc = new GoldenCustomer() { Screen = "screen 2" };
            //gc.ShowTimings();
            //int ta1=gc.GetTicketAmount();
            //Console.WriteLine($"GOLD TICKET AMOUNT:{ta1}");
            //gc.PrintTicket();
            ////////////////////////////////////////////////////////
            //PlatinumCustomer pc = new PlatinumCustomer() { Screen="SCREEN3"};
            //pc.ShowTimings();
            //int ta2=pc.GetTicketAmount();
            //Console.WriteLine($"Gold ticket amount:{ta2}");
            //#endregion
            //pc.PrintTicket();
            #endregion
            #region possible objects
            //Customer c1 = new Customer();
            //Customer c2 = new SilverCustomer();
            //SilverCustomer sc = new SilverCustomer();
            ////SilverCustomer sc2 = new Customer();
            ////we can solve compiler error using type cast
            //SilverCustomer sc2 =(SilverCustomer) new Customer();
            #endregion
            Customer[] customers = new Customer[]
            {
                new SilverCustomer(),
              new GoldCustomer(),
                new PlatinumCustomer()
            };
            for (var i=0;i<customers.Length;i++)
            {
                customers[i].ShowTimings();
                Customer c= customers[i];
                //int t= ((SilverCustomer)c).GetTicketAmount();
                // Console.WriteLine($"ticket amount:{t}");
                int t=0;
                if (c is SilverCustomer)
                {
                     //t = ((SilverCustomer)c).GetTicketAmount();
                     t = ((SilverCustomer)c).GetTicketAmount();
                }
               else if (c is GoldCustomer)
                {
                   // t = ((GoldCustomer)c).GetTicketAmount();
                    t = (c as GoldCustomer).GetTicketAmount();
                }
               else if (c is PlatinumCustomer)
                {
                   // t = ((PlatinumCustomer)c).GetTicketAmount();
                    t = (c as PlatinumCustomer).GetTicketAmount();
                }
                Console.WriteLine($"ticket amount:{t}");
            }
            Console.ReadLine();
            /////////////////////////////////////////////////////////////

            
        }
    }
}


