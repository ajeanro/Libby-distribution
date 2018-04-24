using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class WholesaleCustomer
    {
        public int Id { get; set; }
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int SalesAgentId { get; set; }
        public SalesAgent SalesAgent { get; set; }
        public List<RetailCustomer> RetailCustomers { get; set; }
        public List<WholesaleOrder> MyWholesaleOrders { get; set; }
        
    }
}
