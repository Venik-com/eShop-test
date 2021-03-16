using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class RefProductType : BaseEntity, IAggregateRoot
    {
        [Key]
        public int ProductTypeCode { get; private set; }
        public string ProductTypeDescription { get; private set; }

        [ForeignKey("Product")]
        public int ParentProductTypeCode { get; private set; }
    }
}
