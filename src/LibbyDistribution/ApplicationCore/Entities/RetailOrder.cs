using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class RetailOrder
    {
        public int Id { get; set; }
        public int RetailCustomerId { get; set; }
        public RetailCustomer RetailCustomer { get; set; }
        public int SalesAgentId { get; set; }
        public SalesAgent SalesAgent { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public List<RetailOrderDetail> RetailOrderDetails { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
