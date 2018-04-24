using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class WholesaleOrder
    {
        public int Id { get; set; }
        public int WholesaleCustomerId { get; set; }
        public WholesaleCustomer WholesaleCustomer { get; set; }
        public List<WholesaleOrderDetail> WholesaleOrderDetails { get; set; }
        public int SalesAgentId { get; set; }
        public SalesAgent SalesAgent { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
