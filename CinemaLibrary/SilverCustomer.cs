using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaLibrary
{
    public class SilverCustomer:Customer
    {
        public override void GetTicketAmount()
        {
            Console.WriteLine("SILVER CUSTOMER AMOUNT:150");
        }
        public override void PrintTicket(TicketChoice choice)
        {
            if (choice == null)
            {
                Console.WriteLine("SILVER CUSTOMER");
            }
            else
            {
                choice();
            }
        }
    }
}
