using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class RefInvoiceStatusCode : BaseEntity, IAggregateRoot
    {
        [Key]
        public int InvoiceStatusCode { get; set; }

        // Issued, Paid, etc.
        public string InvoiceStatusDescription { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
