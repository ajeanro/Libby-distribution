using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class RetailCustomer
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BusinessName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<RetailOrder> MyRetailOrders { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public int SalesAgentId { get; set; }
        public SalesAgent SalesAgent { get; set; }
        public List<EquipmentIssue> EquipmentIssue { get; set; }
        public List<Equipment> Equipment { get; set; }
    }
}
