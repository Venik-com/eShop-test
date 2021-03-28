using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class CustomerPaymentMethod : BaseEntity, IAggregateRoot
    {
        [Key]
        public int CustomerPaymentId { get; private set; }
        public string CrediCardNumber { get; private set; }
        public string PaymentMethodDetails { get; private set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; private set; }

        [ForeignKey("RefPaymentMethod")]
        public int PaymentMethodCode { get; private set; }

        public virtual Customer Customer { get; private set; }
        public virtual RefPaymentMethod RefPaymentMethod { get; private set; }
    }
}
