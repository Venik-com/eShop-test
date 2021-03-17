using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Order : BaseEntity, IAggregateRoot
    {
        [Key]
        public int OrderId { get; private set; }
        public DateTime DateOrderPlaced { get; private set; }
        public string OrderDetails { get; private set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; private set; }

        [ForeignKey("RefOrderStatusCode")]
        public int OrderStatusCode { get; private set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual Customer Customer { get; private set; }
        public virtual RefOrderStatusCode RefOrderStatusCode { get; private set; }
    }
}
