using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class OrderItem : BaseEntity, IAggregateRoot
    {
        [Key]
        public int OrderItemId { get; set; }
        public string OrderItemQuantity { get; set; }
        public decimal OrderItemPrice { get; set; }

        /// <summary>
        /// RMA = Return Merchandise Authorization.
        /// </summary>
        public int RMANumber { get; set; }
        public string RMAIssuedBy { get; set; }
        public DateTime RMAIssuedDate { get; set; }
        public string OtherOrderItemDetails { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("RefOrderItemStatusCode")]
        public int OrderItemStatusCode { get; set; }

        public virtual Product Products { get; set; }
        public virtual Order Order { get; set; }
        public virtual RefOrderItemStatusCode RefOrderItemStatusCode { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
    }
}
