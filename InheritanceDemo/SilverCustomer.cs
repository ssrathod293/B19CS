using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class SilverCustomer:Customer
    {
        //public int TicketAmount ;
        //public string Screen;
        public SilverCustomer()
        {
            TicketAmount = 250;
        }
        //public void ShowTimings()
        //{
        //    Console.WriteLine("all shows timings for today"+
        //        "\n 9:AM hambirao"+
        //        "\n 12 PM kgf"+ "\n3:PM bahubali"); 
        //}
        public int GetTicketAmount()
        {
            return TicketAmount ;
        }

        //public void PrintTicket()
        //{
        //    Console.WriteLine("Ticket Printed");
        //}
    }
}
