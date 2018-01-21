using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProjectDay3Build1App.Models;

namespace FinalProjectDay3Build1App.Controllers
{ 
    public class TeacherController : Controller
    {
        private UniversityDbContext db = new UniversityDbContext();

        //
        // GET: /Teacher/

        public ViewResult Index()
        {
            var teachers = db.Teachers.Include(t => t.Designation).Include(t => t.Department);
            return View(teachers.ToList());
        }

        //
        // GET: /Teacher/Details/5

        public ViewResult Details(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            return View(teacher);
        }

        //
        // GET: /Teacher/Create

        public ActionResult Create()
        {
            ViewBag.DesignationId = new SelectList(db.Designations, "DesignationId", "Name");
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code");
            return View();
        } 

        //
        // POST: /Teacher/Create

        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.DesignationId = new SelectList(db.Designations, "DesignationId", "Name", teacher.DesignationId);
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code", teacher.DepartmentId);
            return View(teacher);
        }
        
       
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}