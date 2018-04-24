using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SerialNumber { get; set; }
        public RetailCustomer RetailCustomer{ get; set; }
        public int RetailCustomerId { get; set; }
        public bool IsInService { get; set; }
        public bool IsMalfunctioning { get; set; }
        public List<EquipmentIssue> EquipmentIssues { get; set; }
        public int SelectedEquipmentIssueId { get; set; }
        public DateTime InstallDate { get; set; }
        public DateTime RemovalDate { get; set; }
        public DateTime ServiceRequestDate { get; set; }
        public DateTime OutOfServiceDate { get; set; }
    }
}
