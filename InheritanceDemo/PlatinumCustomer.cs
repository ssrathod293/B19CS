namespace InheritanceDemo
{
    public class PlatinumCustomer:Customer
    {
        public PlatinumCustomer()
        {
            TicketAmount = 700;
        }

        public int GetTicketAmount()
        {
            return TicketAmount;
        }
    }
}
   

