using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaLibrary
{
   public class GoldCustomer:Customer
    {
        public override void GetTicketAmount()
        {
            Console.WriteLine("GOLD CUSTOMER AMOUNT:300");
        }
        public override void PrintTicket(TicketChoice choice)
        {
            if (choice==null)
            {
                Console.WriteLine("GOLD CUSTOMER");
            }
            else
            {
                choice();
            }
            
        }
    }
}
