using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trinity.Entities;
using Trinity.Services;

namespace Trinity.Web.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult CourseTables()
        {
            CourseRepository cr = new CourseRepository();
            var courses = cr.GetAll();
            cr.Dispose();

            return View(courses);
        }

    // GET: TestCourses/Details/5
    public ActionResult SoloDetails(int? id)
    {
            CourseRepository cr = new CourseRepository();
            if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
            Course course = cr.GetById(id);
        if (course == null)
        {
            return HttpNotFound();
        }
            cr.Dispose();
            return View(course);
    }

    }
}