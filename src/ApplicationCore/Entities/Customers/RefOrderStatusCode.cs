using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class RefOrderStatusCode : BaseEntity, IAggregateRoot
    {
        [Key]
        public int OrderStatusCode { get; private set; }

        // Cancelled, Completed, etc.
        // TO DO: Сделать для таких значений enum (везде).
        public string OrderStatusDescription { get; private set; }
    }
}
