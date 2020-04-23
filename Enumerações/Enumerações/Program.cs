using Enumerações.Entities;
using Enumerações.Entities.Enums;
using System;

namespace Enumerações {
    class Program {
        static void Main(string[] args) {
            Order order = new Order(1080, DateTime.Now, OrderStatus.PendingPayment);
            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
