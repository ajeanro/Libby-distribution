using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Unit { get; set; }
        public int RetailPrice { get; set; }
        public int WholesalePrice { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
