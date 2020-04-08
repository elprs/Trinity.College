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
    public class AssignmentCRUDController : Controller
    {

        // GET: assignmentCRUD

        public ActionResult AssignmentCrudIndex()
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();

            var assignments = assignmentRepository.GetAll();

            return View(assignments);
        }


        // GET: Testassignments/Details/5
        public ActionResult Details(int? id)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = assignmentRepository.GetById(id);

            if (assignment == null)
            {
                return HttpNotFound();
            }
            return View(assignment);
        }


        // GET: Testassignments/Create
        public ActionResult Create()
        {
           

            return View();
        }


        // POST: Testassignments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignmentId,Title,SubDate")] Assignment assignment)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();


            if (ModelState.IsValid)
            {
                assignmentRepository.Insert(assignment);

                return RedirectToAction("AssignmentCrudIndex");
            }

            return View(assignment);
        }




        // GET: TestAssignments/Edit/5
        public ActionResult Edit(int? id)
        {
            AssignmentRepository assignmentRepository = new AssignmentRepository();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment assignment = assignmentRepository.GetById(id);
           

            if (assignment == null)
            {
                return HttpNotFound();
            }

            MarkRepository markRepository = new MarkRepository();

            ViewBag.selectedMarkIDs = markRepository.GetAll()
                                                          .Select(x => new SelectListItem
                                                          {
                                                              Value = string.Format("{0}", x.MarkId.ToString()),
                                                              Text = string.Format("{0}", x.AssignmentMark)
                                                          });

            return View(assignment);
        }

        // POST: TestAssignments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignmentId,Title,SubDate")] Assignment assignment, IEnumerable<int> selectedMarkIDs)
        {
            if (ModelState.IsValid)
            {
                AssignmentRepository assignmentRepository = new AssignmentRepository();
                assignmentRepository.Update(assignment, selectedMarkIDs);
               
                return RedirectToAction("AssignmentCrudIndex");
            }
            return View(assignment);
        }


        //// GET: TestAssignments/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Assignment assignment = db.Assignments.Find(id);
        //    if (assignment == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(assignment);
        //}

        //// POST: TestAssignments/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Assignment assignment = db.Assignments.Find(id);
        //    db.Assignments.Remove(assignment);
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