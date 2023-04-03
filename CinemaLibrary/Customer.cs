using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaLibrary
{
   public abstract class Customer
    {
        public delegate void TicketChoice();
        public int TicketAmount { get; set; }
        public void Shows()
        {
            Console.WriteLine("ALL SHOWS TIMEING");
        }
        public abstract void GetTicketAmount();
        public abstract void PrintTicket(TicketChoice choice);
        //what if there is an another requirement from client
        //1 way==write extra method for qr code generate
        //1 way==write extra method for qr code email/text
        //1 way==write extra method for qr code whatsapp

    }
}
