using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class WholesaleOrderDetail
    {
        public int Id { get; set; }
        public int WholesaleOrderId { get; set; }
        public WholesaleOrder WholesaleOrder { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductWholesalePrice { get; set; }
    }
}
