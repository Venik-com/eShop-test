using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Payment : BaseEntity, IAggregateRoot
    {
        [Key]
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentAmount { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceNumber { get; set; }

        public virtual Invoice Invoice { get; set; }
    }
}
