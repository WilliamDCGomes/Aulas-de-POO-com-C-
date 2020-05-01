using Exercicio_11.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Exercicio_11.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() {
        }
        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Item.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            Item.Remove(item);
        }
        public double TotalPrice() {
            double sum = 0;
            foreach (OrderItem o in Item) {
                sum += o.SubTotal();
            }
            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            foreach(OrderItem p in Item) {
                sb.Append(p.Product.Name);
                sb.Append(", $");
                sb.Append(p.Price.ToString("F2",CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(p.Quantity);
                sb.Append(", Subtotal: $");
                sb.Append(p.SubTotal().ToString("F2",CultureInfo.InvariantCulture));
                sb.AppendLine();
            }
            sb.Append("Total price: $");
            sb.Append(TotalPrice().ToString("F2",CultureInfo.InvariantCulture));
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
