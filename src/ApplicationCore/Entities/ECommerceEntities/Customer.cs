using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Customer : BaseEntity, IAggregateRoot
    {
        [Key]
        public int CustomerId { get; set; }
        public string OrganisationOrPerson { get; set; }
        public string OrganisationName { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string TownCity { get; set; }
        public string CountyOrRegion { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CustomerPaymentMethod> CustomerPaymentMethods { get; set; }
    }
}
