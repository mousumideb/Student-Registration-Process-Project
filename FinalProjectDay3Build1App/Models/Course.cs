using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectDay3Build1App.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Credit { get; set; }
        public string Description { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int SemesterId { get; set; }
        public virtual Semester Semester { get; set; }


    }
}