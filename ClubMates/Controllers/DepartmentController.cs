using ClubMates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubMates.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public static List<Department> departments = new List<Department>()
            {
                new Department{DepartmentId=1,DepartmentName="Science"},
                new Department {DepartmentId=2,DepartmentName="Bio"}

            };
        // GET: Department
        public ActionResult ShowData()
        {
            return View(departments);
        }

        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View(new Department());
        }
        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                departments.Add(department);
                return Redirect("ShowData");
            }
            return Redirect("ShowData");
        }
    }
}