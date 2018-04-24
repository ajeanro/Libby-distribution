using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Driver
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public List<RetailCustomer> DriverRetailCustomers { get; set; }
        public List<RetailOrder> DriverRetailOrders { get; set; }
    }
}
