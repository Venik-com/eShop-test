using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class RefPaymentMethod : BaseEntity, IAggregateRoot
    {
        [Key]
        public int PaymentMethodCode { get; set; }
        // CC=Credit card, etc.
        public string PaymentMethodDescription { get; set; }

        public virtual ICollection<CustomerPaymentMethod> CustomerPaymentMethods { get; set; }
    }
}
