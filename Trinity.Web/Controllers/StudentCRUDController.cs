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


        // GET: TestStudents/Edit/5
        public ActionResult Edit(int? id)
        {
            StudentRepository studentRepository = new StudentRepository();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = studentRepository.GetById(id);
            MarkRepository markRepository = new MarkRepository();
            if (student == null)
            {
                return HttpNotFound();
            }

            ViewBag.selectedMarkIds = markRepository.GetAll()
                                                    .Select(x => new SelectListItem
                                                    {
                                                        Value = x.MarkId.ToString(),
                                                        Text = x.TotalMark.ToString()
                                                    });
            return View(student);
        }

        // POST: TestStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,Telephone,Email,PhotoURL")] Student student, IEnumerable<int> selectedMarkIds)
        {
            if (ModelState.IsValid)
            {
                StudentRepository studentRepository = new StudentRepository();
                studentRepository.Update(student, selectedMarkIds);
                
                return RedirectToAction("StudentCrudIndex");
            }
            return View(student);
        }

        //// GET: TestStudents/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Student student = db.Students.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}

        //// POST: TestStudents/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Student student = db.Students.Find(id);
        //    db.Students.Remove(student);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}


    }

}
