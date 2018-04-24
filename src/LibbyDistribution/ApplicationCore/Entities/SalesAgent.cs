using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class SalesAgent
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<RetailCustomer> AgentRetailCustomers { get; set; }
        public List<WholesaleCustomer> AgentWholesaleCustomers { get; set; }
        public List<RetailOrder> AgentRetailOrders { get; set; }
        public List<WholesaleOrder> AgentWholesaleOrders { get; set; }
    }
}
