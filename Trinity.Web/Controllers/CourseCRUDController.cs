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
    public class CourseCRUDController : Controller
    {
        
        // GET: CourseCRUD

        public ActionResult CourseCrudIndex()
        {
            CourseRepository courseRepository = new CourseRepository();

            var courses = courseRepository.GetAll();

            return View(courses);
        }


        // GET: TestCourses/Details/5
        public ActionResult Details(int? id)
        {
            CourseRepository courseRepository = new CourseRepository();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Course course = courseRepository.GetById(id);

            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }











    }

}