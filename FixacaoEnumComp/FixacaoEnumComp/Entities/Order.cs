using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using FixacaoEnumComp.Entities.Enums;

namespace FixacaoEnumComp.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() {

        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Itens.Remove(item);
        }

        public double Total() {
            double total = 0.0;
            foreach(OrderItem i in Itens) {
                total += (i.SubTotal());
            }

            return total;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order itens: ");
            foreach(OrderItem oi in Itens) {
                sb.Append(oi.Product.Name);
                sb.Append(", $");
                sb.Append(oi.Product.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(oi.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(oi.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.Append("Total Price: $");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
