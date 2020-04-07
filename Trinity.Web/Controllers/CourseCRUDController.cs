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


        // GET: TestCourses/Edit/5
        public ActionResult Edit(int? id)
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

            SubjectRepository subjectRepository = new SubjectRepository();
            //var subjects = subjectRepository.GetAll()
            //                                .Select(x => new
            //                                {
            //                                    SubjectId = x.SubjectId,
            //                                    SubjectTitle = x.Title
            //                                });


            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            ViewBag.SelectedSubjectsIds = subjectRepository.GetAll()
                                                        .Select(x => new SelectListItem()
                                                        {
                                                            Value = x.SubjectId.ToString(),
                                                            Text = string.Format("{0}", x.Title)
                                                        });

            //ViewBag.SubjectSelectedIds = SelectedSubjectsIds; //ton enan
            //ViewBag.SelectedSubjects = new SelectList(subjects, "SubjectId", "SubjectTitle"); // OLA 






            return View(course);
        }
        // POST: TestCourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseId,Title,StartDate,EndDate,Type,Description,PhotoURL,Fee")] Course course, IEnumerable<int> SelectedSubjectsIds) //+++++++++++++++++++++++ 
            //den mpainei int?/giati o,ti epilekso sto view exei ari8mo sigoura
        {
            if (ModelState.IsValid)
            {
                CourseRepository courseRepository = new CourseRepository();
                courseRepository.Update(course, SelectedSubjectsIds); //++++++++++++++++++++++++++++++
                return RedirectToAction("CourseCrudIndex");
            }
            return View(course);
        }



    }

}

#region ================== Experiment - learning=======================

//CourseStudentRepository courseStudentRepository = new CourseStudentRepository();

//var courseStudents = courseStudentRepository.GetAll()
//                             .Select(x => new
//                             {
//                                 courseID = x.CourseId,
//                                 studentID = x.StudentId
//                             });




//    //Grouping Course Student
//            svm.StudentsPerCourse = students
//                         .SelectMany(x => x.Courses.Select(y => new
//                         {
//                             Key = y,
//                             Value = x
//                         }))
//                         .GroupBy(y => y.Key, x => x.Value);
//​[15:16]
//Xenofontas Vlachogiannis
//    svm ειναι το ονομα του modelou για τα στατσ.
//​[15:16]
//Xenofontas Vlachogiannis
//    Students ειναι το student.GetAll()


#endregion