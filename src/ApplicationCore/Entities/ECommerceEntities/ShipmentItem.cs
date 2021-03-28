using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class ShipmentItem : BaseEntity, IAggregateRoot
    {
        [Key]
        public int ShipmentId { get; private set; }

        [Key]
        public int OrderItemId { get; private set; }

        public virtual Shipment Shipment { get; private set; }
        public virtual OrderItem OrderItem { get; private set; }
    }
}
