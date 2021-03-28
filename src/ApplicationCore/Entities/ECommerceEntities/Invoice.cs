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
        public int InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string InvoiceDetails { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        [ForeignKey("RefInvoiceStatusCode")]
        public int InvoiceStatusCode { get; set; }

        public virtual Order Order { get; set; }
        public virtual RefInvoiceStatusCode RefInvoiceStatusCode { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
