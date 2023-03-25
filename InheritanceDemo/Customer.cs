using System;
namespace InheritanceDemo
{
    public class Customer
    {
        public int TicketAmount;
        public string Screen;
        public void ShowTimings()
        {
            Console.WriteLine("all shows timings for today" +
                "\n 9:AM hambirao" +
                "\n 12 PM kgf" + "\n3:PM bahubali");
        }
        //public int GetTicketAmount()
        //{
        //    return TicketAmount;
        //}

        public void PrintTicket()
        {
            Console.WriteLine("Ticket Printed");
        }

    }
}
   

