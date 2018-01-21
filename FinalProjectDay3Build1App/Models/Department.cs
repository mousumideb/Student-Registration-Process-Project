using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectDay3Build1App.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

    }

}