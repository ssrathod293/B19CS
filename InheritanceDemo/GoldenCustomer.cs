using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class GoldenCustomer
    {
        public int TicketAmount;
        public string Screen;
        public GoldenCustomer()
        {
            TicketAmount = 500;
        }
        public void ShowTimings()
        {
            Console.WriteLine("all shows timings for today" +
                "\n 9:AM hambirao" +
                "\n 12 PM kgf" + "\n3:PM bahubali");
        }
        public int GetTicketAmount()
        {
            return TicketAmount;
        }

        public void PrintTicket()
        {
            Console.WriteLine("Ticket Printed");
        }
    }
}
