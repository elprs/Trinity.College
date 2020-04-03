using PagedList;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Trinity.Entities;
using Trinity.Services;

namespace Trinity.Web.Controllers
{
    public class AssignmentController : Controller
    {
        // GET: Assignment
        public ActionResult AssignmentTables(string sortOrder, string searchTitle, string searchSubDate,  int? page, int? pSize)
        {
            //==============Viewbags====================================
            ViewBag.CurrentTitle = searchTitle;
            ViewBag.CurrentSubDate = searchSubDate;
          
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";
            ViewBag.SubDateSortParam = sortOrder == "SubDateAsc" ? "SubDateDesc" : "SubDateAsc";
           
            ViewBag.TiView = "btn-sm btn-primary";
            ViewBag.SubdView = "btn-sm btn-primary";
            
            AssignmentRepository cr = new AssignmentRepository();
            var assignments = cr.GetAll();


            //======================FILTERS===============================
            //Filtering  Title
            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                assignments = assignments.Where(x => x.Title.ToUpper().Contains(searchTitle.ToUpper()));
            }
            //Filtering  SubDate
            if (!(searchSubDate == null))
            {
                assignments = assignments.Where(x => x.SubDate.ToString().ToUpper().Contains(searchSubDate.ToString().ToUpper()));
            }
            
            //=======================Sorting====================================
            switch (sortOrder)
            {
                case "TitleDesc": assignments = assignments.OrderByDescending(x => x.Title).ThenBy(x => x.SubDate); ViewBag.TiView = "btn-sm btn-success"; break;
                case "SubDateAsc": assignments = assignments.OrderBy(x => x.SubDate); 
                    ViewBag.SubdView = "btn-sm btn-primary"; break;
                case "SubDateDesc": assignments = assignments.OrderByDescending(x => x.SubDate); 
                    ViewBag.SubdView = "btn-sm btn-success"; break;
                
                default: assignments = assignments.OrderBy(x => x.Title); 
                    ViewBag.TiView = "btn-sm btn-primary"; break;
            }
            cr.Dispose();

            //==========================Pagination=====================================
            int pageSize = pSize ?? 5;
            int pageNumber = page ?? 1;

            return View(assignments.ToPagedList(pageNumber, pageSize));
        }

        // GET: TestAssignments/Details/5
        public ActionResult SimpleDetails(int? id)
        {
            AssignmentRepository cr = new AssignmentRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assignment Assignment = cr.GetById(id);
            if (Assignment == null)
            {
                return HttpNotFound();
            }
            cr.Dispose();
            return View(Assignment);
        }

    }
}