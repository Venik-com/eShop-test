using Microsoft.eShopWeb.ApplicationCore.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Microsoft.eShopWeb.ApplicationCore.Entities.Customers
{
    public class Product : BaseEntity, IAggregateRoot
    {
        [Key]
        public int ProductId { get; private set; }
        public int ReturnMerchandiseAuthNumber { get; private set; }
        public string ProductName { get; private set; }
        public decimal ProductPrice { get; private set; }
        public string ProductColor { get; private set; }
        public string ProductSize { get; private set; }
        public string ProductDescription { get; private set; }
        public string OtherProductDetails { get; private set; }

        [ForeignKey("RefProductType")]
        public int ProductTypeCode { get; private set; }

        public virtual RefProductType RefProductType { get; private set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
