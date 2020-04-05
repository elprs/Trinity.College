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
    public class studentCRUDController : Controller
    {

        // GET: studentCRUD

        public ActionResult StudentCrudIndex()
        {
            StudentRepository studentRepository = new StudentRepository();

            var students = studentRepository.GetAll();

            return View(students);
        }


        // GET: Teststudents/Details/5
        public ActionResult Details(int? id)
        {
            StudentRepository studentRepository = new StudentRepository();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = studentRepository.GetById(id);

            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }


        // GET: Teststudents/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: Teststudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,Title,StartDate,EndDate,Type,Description,PhotoURL,Fee")] Student student)
        {
            StudentRepository studentRepository = new StudentRepository();


            if (ModelState.IsValid)
            {
                studentRepository.Insert(student);

                return RedirectToAction("StudentCrudIndex");
            }

            return View(student);
        }





    }

}
