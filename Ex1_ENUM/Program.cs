using System;
using Ex1_ENUM.Entities;
using Ex1_ENUM.Entities.Enums;

namespace Ex1_ENUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1502,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment            
            };

            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}
