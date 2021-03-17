using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Invoice : BaseEntity, IAggregateRoot
    {
        [Key]
        public int InvoiceNumber { get; private set; }
        public DateTime InvoiceDate { get; private set; }
        public string InvoiceDetails { get; private set; }

        [ForeignKey("Order")]
        public int OrderId { get; private set; }

        [ForeignKey("RefInvoiceStatusCode")]
        public int InvoiceStatusCode { get; private set; }

        public virtual Order Order { get; private set; }
        public virtual RefInvoiceStatusCode RefInvoiceStatusCode { get; private set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
