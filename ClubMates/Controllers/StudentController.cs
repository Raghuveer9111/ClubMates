using ClubMates.Db;
using ClubMates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ClubMates.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //public static List<Student> students = new List<Student>()
        //    {
        //        new Student() {StudentId=1,StudentName="Veer",Email="test1@gmail.com",DateOfBirth= new DateTime(2003,06,04),Height=5.7M,Weight=50,PhoneNumber=34534356},
        //        new Student() {StudentId=1,StudentName="Raghu",Email="test1@gmail.com",DateOfBirth= new DateTime(2003,06,05),Height=5.7M,Weight=51,PhoneNumber=7456233},
        //        new Student() {StudentId=1,StudentName="Mewada",Email="test1@gmail.com",DateOfBirth= new DateTime(2003,06,06),Height=5.7M,Weight=52,PhoneNumber=7564534}
        //    };

        private readonly ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }



        // GET: Student
        public ActionResult ShowData()
        {
            var students = _context.Students;
            return View(students);
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            if(ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return Redirect("ShowData");
            }
            return View();
        }

        [HttpPost]
        public ActionResult DeleteStudent(int id)
        {
            var student = _context.Students.SingleOrDefault(s => s.StudentId==id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();

                return Redirect("ShowData");
            }

            return Content("Student not found");
        }
    }
}