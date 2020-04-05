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


        // GET: TestCourses/Create
        public ActionResult Create()
        {


            return View();
        }


        // POST: TestCourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseId,Title,StartDate,EndDate,Type,Description,PhotoURL,Fee")] Course course)
        {
            CourseRepository courseRepository = new CourseRepository();
           

            if (ModelState.IsValid)
            {
                courseRepository.Insert(course);
               
                return RedirectToAction("CourseCrudIndex");
            }

            return View(course);
        }





    }

}

#region ================== Experiment - learing=======================

//CourseStudentRepository courseStudentRepository = new CourseStudentRepository();

//var courseStudents = courseStudentRepository.GetAll()
//                             .Select(x => new
//                             {
//                                 courseID = x.CourseId,
//                                 studentID = x.StudentId
//                             });
#endregion