using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class RetailOrderDetail
    {
        public int Id { get; set; }
        public RetailOrder RetailOrder { get; set; }
        public int RetailOrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductRetailPrice { get; set; }

    }
}
