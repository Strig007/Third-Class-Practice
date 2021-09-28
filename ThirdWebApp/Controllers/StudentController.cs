using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThirdWebApp.Models;

namespace ThirdWebApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            string[] name = new string[5];
            name[0] = "Strig";
            name[1] = "Hans";
            name[2] = "Akash";

            ViewBag.Names = name;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult List()
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 10; i++)
            {
                Student s = new Student()
                {
                    Id = "100" + i,
                    Name = "Strig",
                    Dob = "24/08/199" + i
                };
                students.Add(s);
            }

            return View(students);
        }

        public ActionResult Submission(Student s)
        {
            /*ViewBag.Name = Request["Name"];
            ViewBag.Id = Request["Id"];
            ViewBag.Dob = Request["Dob"];*/

            /*ViewBag.Name = fc["Name"];
            ViewBag.Id = fc["Id"];
            ViewBag.Dob = fc["Dob"];*/

            /*ViewBag.Name = Name;
            ViewBag.Id = Id;
            ViewBag.Dob = Dob*/;

            return View(s);
        }
    }
}