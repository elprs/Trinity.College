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





    }

}