using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic_System.Models
{
    /// <summary>
    /// Represents a bill record from the Bills table.
    /// Used to pass bill data between BillRepository and forms.
    /// </summary>
    public class Bill
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Date { get; set; }
        public decimal Total { get; set; }
    }
}
