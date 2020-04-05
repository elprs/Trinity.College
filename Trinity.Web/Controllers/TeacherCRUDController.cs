using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trinity.Services;
using Trinity.Entities;
using System.Net;

namespace Trinity.Web.Controllers
{
    public class TeacherCRUDController : Controller
    {
        // GET: TeacherCRUD
        public ActionResult TeacherCrudIndex()
        {
             TeacherRepository teacherRepository = new TeacherRepository();

                var teachers = teacherRepository.GetAll();

                return View(teachers);
            }


            // GET: Testteachers/Details/5
            public ActionResult Details(int? id)
            {
                TeacherRepository teacherRepository = new TeacherRepository();

                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Teacher teacher = teacherRepository.GetById(id);

                if (teacher == null)
                {
                    return HttpNotFound();
                }
                return View(teacher);
            }


            // GET: Testteachers/Create
            public ActionResult Create()
            {
                return View();
            }


        // POST: Testteachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TeacherId,FirstName,LastName,Telephone,Email,Salary,VideoURL")] Teacher teacher)
        {
            TeacherRepository teacherRepository = new TeacherRepository();


            if (ModelState.IsValid)
            {
                teacherRepository.Insert(teacher);

                return RedirectToAction("TeacherCrudIndex");
            }

            return View(teacher);
        }


    }
}