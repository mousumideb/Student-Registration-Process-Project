using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectDay3Build1App.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public double CreditToTake { get; set; }

        public int DesignationId { get; set; }
        public Designation Designation { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}