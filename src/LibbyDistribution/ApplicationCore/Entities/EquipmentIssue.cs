using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class EquipmentIssue
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public bool IsSelected { get; set; }
    }
}
