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
    public class MarkCRUDController : Controller
    {

        // GET: markCRUD

        public ActionResult MarkCrudIndex()
        {
            MarkRepository markRepository = new MarkRepository();

            var marks = markRepository.GetAll();

            return View(marks);
        }


        // GET: Testmarks/Details/5
        public ActionResult Details(int? id)
        {
            MarkRepository markRepository = new MarkRepository();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = markRepository.GetById(id);

            if (mark == null)
            {
                return HttpNotFound();
            }
            return View(mark);
        }


        // GET: Testmarks/Create
        public ActionResult Create()
        {
            MarkRepository markRepository = new MarkRepository();
            AssignmentRepository assignmentRepository = new AssignmentRepository();

            var assignments = assignmentRepository.GetAll();
            ViewBag.AssignmentId = new SelectList(assignments, "AssignmentId", "Title");


            return View();
        }


        // POST: Testmarks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarkId,UniqueCode,AssignmentMark,OralMark,StudentId")] Mark mark)
        {
            MarkRepository markRepository = new MarkRepository();


            if (ModelState.IsValid)
            {
                markRepository.Insert(mark);

                return RedirectToAction("MarkCrudIndex");
            }

            return View(mark);
        }





    }
}