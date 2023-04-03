using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            for (int i = 0; i <c.Orders.Value.Length; i++)
            {
                var o = c.Orders.Value[i];
                Console.WriteLine($"{o.OrderId} {o.OrderDescription}");
            }
            Console.ReadLine();
        }
    }
        public class Order
        {
            public int OrderId { get; set; }
            public string OrderDescription { get; set; }
        }
        public class Customer
        {
            public string Name { get; set; }
            public Lazy< Order[]> Orders;

            public Customer()
            {
                Name = "Shrikant";
            Orders = new Lazy<Order[]>(delegate() {
                return GetOrders();
            });
            }
            public Order[] GetOrders()
            {
                return new Order[]
                {
                new Order(){OrderId=1,OrderDescription="order 1"},
                new Order(){OrderId=2,OrderDescription="order 2"}

                };
            }
        }
    }

