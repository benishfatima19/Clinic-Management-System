using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic_System.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Contact { get; set; }
        public string Disease { get; set; }
    }
}
