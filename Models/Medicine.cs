using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic_System.Models
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ExpiryDate { get; set; }
    }
}
