using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class ShipmentItem : BaseEntity, IAggregateRoot
    {
        [Key]
        public int ShipmentId { get; set; }

        [Key]
        public int OrderItemId { get; set; }

        public virtual Shipment Shipment { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}
