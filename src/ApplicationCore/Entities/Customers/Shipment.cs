using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Shipment : BaseEntity, IAggregateRoot
    {
        [Key]
        public int ShipmentId { get; private set; }
        public int ShipmentTrackingNumber { get; private set; }
        public DateTime ShipmentDate { get; private set; }

        // Shipment description.
        public string OtherShipmentDetails { get; private set; }

        [ForeignKey("Order")]
        public int OrderId { get; private set; }

        [ForeignKey("Invoice")]
        public int InvoiceNumber { get; private set; }
    }
}
