using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Product : BaseEntity, IAggregateRoot
    {
        [Key]
        public int ProductId { get; set; }
        public int ReturnMerchandiseAuthNumber { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductColor { get; set; }
        public string ProductSize { get; set; }
        public string ProductDescription { get; set; }
        public string OtherProductDetails { get; set; }

        [ForeignKey("RefProductType")]
        public int ProductTypeCode { get; set; }

        public virtual RefProductType RefProductType { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
