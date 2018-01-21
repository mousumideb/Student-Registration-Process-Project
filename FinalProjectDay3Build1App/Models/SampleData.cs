using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProjectDay3Build1App.Models
{
    public class SampleData: DropCreateDatabaseIfModelChanges<UniversityDbContext>
    {
        protected override void Seed(UniversityDbContext context)
        {
            var semesters = new List<Semester>
                {
                    new Semester {SemesterId = 1, Name = "Semester-1"},
                    new Semester {SemesterId = 2, Name = "Semester-2"},
                    new Semester {SemesterId = 3, Name = "Semester-3"},
                    new Semester {SemesterId = 4, Name = "Semester-4"},
                    new Semester {SemesterId = 5, Name = "Semester-5"},
                    new Semester {SemesterId = 6, Name = "Semester-6"},
                    new Semester {SemesterId = 7, Name = "Semester-7"},
                    new Semester {SemesterId = 8, Name = "Semester-8"},
                };
            semesters.ForEach(s => context.Semesters.Add(s));
            context.SaveChanges();

            var designations = new List<Designation>
                {
                    new Designation {DesignationId = 1, Name = "Professor"},
                    new Designation {DesignationId = 2,Name = "Associate Professor"},
                    new Designation {DesignationId = 3,Name = "Assistant Professor"},
                    new Designation {DesignationId = 4,Name = "Senior Lecturer"},
                    new Designation {DesignationId = 5,Name = "Lecturer"},
                    new Designation {DesignationId = 6,Name = "Teacher Assistant"}
                };
            designations.ForEach(d => context.Designations.Add(d));
            context.SaveChanges();

            var departments = new List<Department>
                {
                    new Department {DepartmentId = 1,Code = "CSE", Name = "Computer Science & Engineering" },
                    new Department {DepartmentId = 2,Code = "ETE", Name = "Electronics and Telecommunication Engineering"},
                    new Department {DepartmentId = 3,Code = "EEE", Name = "Electrical and Electronics Engineering"}
                };
            departments.ForEach(d => context.Departments.Add(d));
            context.SaveChanges();


        }
    }
}