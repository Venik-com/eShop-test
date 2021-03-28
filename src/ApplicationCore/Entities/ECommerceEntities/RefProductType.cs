using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class RefProductType : BaseEntity, IAggregateRoot
    {
        [Key]
        public int ProductTypeCode { get; set; }
        public string ProductTypeDescription { get; set; }

        [ForeignKey("Product")]
        public int ParentProductTypeCode { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
