using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class CustomerPaymentMethod : BaseEntity, IAggregateRoot
    {
        [Key]
        public int CustomerPaymentId { get; set; }
        public string CrediCardNumber { get; set; }
        public string PaymentMethodDetails { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("RefPaymentMethod")]
        public int PaymentMethodCode { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual RefPaymentMethod RefPaymentMethod { get; set; }
    }
}
