using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.EmployeeEntities
{
    public class Employee : BaseEntity, IAggregateRoot
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Admin - 1, 
        /// Moderator - 2,
        /// Viewer - 3
        /// </summary>
        public string Role { get; set; }
    }
}
