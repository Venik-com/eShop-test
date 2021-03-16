using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
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
    }
}
