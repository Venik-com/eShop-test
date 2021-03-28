using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class ShipmentItem : BaseEntity, IAggregateRoot
    {
        [Key, Column(Order = 0)]
        public int ShipmentId { get; set; }

        [Key, Column(Order = 1)]
        public int OrderItemId { get; set; }

        public virtual Shipment Shipment { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}
