using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Customer : BaseEntity, IAggregateRoot
    {
        [Key]
        public int CustomerId { get; private set; }
        public string OrganisationOrPerson { get; private set; }
        public string OrganisationName { get; private set; }
        public string Gender { get; private set; }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string EmailAddress { get; private set; }
        public string LoginName { get; private set; }
        public string LoginPassword { get; private set; }
        public string PhoneNumber { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string AddressLine3 { get; private set; }
        public string AddressLine4 { get; private set; }
        public string TownCity { get; private set; }
        public string CountyOrRegion { get; private set; }
        public string Country { get; private set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CustomerPaymentMethod> CustomerPaymentMethods { get; set; }
    }
}
