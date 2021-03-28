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
        public int OrderId { get; set; }
        public DateTime DateOrderPlaced { get; set; }
        public string OrderDetails { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("RefOrderStatusCode")]
        public int OrderStatusCode { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual RefOrderStatusCode RefOrderStatusCode { get; set; }
    }
}
