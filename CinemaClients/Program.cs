using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaLibrary;
using static CinemaLibrary.Customer;

namespace CinemaClients
{
    class Program
    {
        static void Main(string[] args)
        {
            //abhiruchi
            Customer c1 = new SilverCustomer();
            c1.Shows();c1.GetTicketAmount();c1.PrintTicket(null);

            //Mangala
            Customer c2 = new GoldCustomer();
            c2.Shows(); c2.GetTicketAmount(); c2.PrintTicket(null);

            //seasons
            Customer c3 = new GoldCustomer();
            c3.Shows();c3.GetTicketAmount();

            //delegate usig anonymous method 
            TicketChoice del = delegate()
            {
                Console.WriteLine("QR CODE DOWNLOAD");
            };
            c3.PrintTicket(del);

            Customer c4 = new GoldCustomer();
            c4.Shows(); c4.GetTicketAmount();
           // TicketChoice del1 = ChoiceB;
           //delgate with anonymous method without creating instance of delgate
                c4.PrintTicket(delegate ()
                {
                    Console.WriteLine("QR CODE SENT ON WHATSAPP");
                });
            Console.ReadLine();
        }
        //static void ChoiceA()
        //{
        //    Console.WriteLine("QR CODE DOWNLOAD");
        //}
        //static void ChoiceB()
        //{
        //    Console.WriteLine("QR CODE SENT ON WHATSAPP");
        //}
    }
}
