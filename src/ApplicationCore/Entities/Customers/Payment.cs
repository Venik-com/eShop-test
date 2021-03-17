using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Payment : BaseEntity, IAggregateRoot
    {
        [Key]
        public int PaymentId { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public int PaymentAmount { get; private set; }

        [ForeignKey("Invoice")]
        public int InvoiceNumber { get; private set; }

        public virtual Invoice Invoice { get; private set; }
    }
}
