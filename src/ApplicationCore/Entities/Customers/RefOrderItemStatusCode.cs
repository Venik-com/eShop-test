using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class RefOrderItemStatusCode : BaseEntity, IAggregateRoot
    {
        [Key]
        public int OrderItemStatusCode { get; private set; }

        // Delivered, Out of Stock, etc.
        public string OrderItemStatusDescription { get; private set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
