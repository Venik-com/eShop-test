using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Shipment : BaseEntity, IAggregateRoot
    {
        [Key]
        public int ShipmentId { get; set; }
        public int ShipmentTrackingNumber { get; set; }
        public DateTime ShipmentDate { get; set; }

        // Shipment description.
        public string OtherShipmentDetails { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceNumber { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Order Order { get; set; }
        public virtual ICollection<ShipmentItem> ShipmentItems { get; set; }
    }
}
