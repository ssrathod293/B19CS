using System;

namespace InheritanceDemo
{
  
        public class GoldCustomer:Customer
        {
            public GoldCustomer()
            {
                TicketAmount = 500;
            }
            public int GetTicketAmount()
            {
                return TicketAmount;
            }

           
         
        }
   
}
