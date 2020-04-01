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
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult CourseTables(string sortOrder, string searchTitle, string searchType, string searchStartDate, string searchEndDate, double? searchFee, int? page, int? pSize)
        {

            ViewBag.CurrentTitle = searchTitle;
            ViewBag.CurrentType = searchType;
            ViewBag.CurrentStartDate = searchStartDate;
            ViewBag.CurrentEndDate = searchEndDate;
            ViewBag.CurrentFee = searchFee;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";
            ViewBag.TypeSortParam = sortOrder == "TypeAsc" ? "TypeDesc" : "TypeAsc";
            ViewBag.StartDateSortParam = sortOrder == "StartDateAsc" ? "StartDateDesc" : "StartDateAsc";
            ViewBag.EndDateSortParam = sortOrder == "EndDateAsc" ? "EndDateDesc" : "EndDateAsc";
            ViewBag.FeeSortParam = sortOrder == "FeeAsc" ? "FeeDesc" : "FeeAsc";
            ViewBag.DetailsSortParam = sortOrder == "DetailsAsc" ? "DetailsDesc" : "DetailsAsc";


            ViewBag.TiPrimary = "btn-sm btn-primary";
            ViewBag.TyPrimary = "btn-sm btn-primary";
            ViewBag.SdPrimary = "btn-sm btn-primary";
            ViewBag.EdPrimary = "btn-sm btn-primary";
            ViewBag.FePrimary = "btn-sm btn-primary";
            
           

            CourseRepository cr = new CourseRepository();
            var courses = cr.GetAll();
            cr.Dispose();


            ////======================FILTERS===============================
            ////Filtering  FirstName
            //if (!string.IsNullOrWhiteSpace(searchfirstname))
            //{
            //    Directors = Directors.Where(x => x.FirstName.ToUpper().Contains(searchfirstname.ToUpper()));
            //}
            ////Filtering  LastName
            //if (!string.IsNullOrWhiteSpace(searchlastname))
            //{
            //    Directors = Directors.Where(x => x.LastName.ToUpper().Contains(searchlastname.ToUpper()));
            //}
            ////Filtering  Minimum Age
            //if (!(searchminage is null)) //40
            //{
            //    Directors = Directors.Where(x => x.Age >= searchminage);
            //}
            ////Filtering  Maximum Age
            //if (!(searchmaxage is null)) //50
            //{
            //    Directors = Directors.Where(x => x.Age <= searchmaxage);
            //}

            ////Sorting



            switch (sortOrder)
            {
                case "TitleDesc": courses = courses.OrderByDescending(x => x.Title); ViewBag.TiPrimary = "btn-sm btn-success"; break; 
                case "TypeAsc": courses = courses.OrderBy(x => x.Type); ViewBag.TyPrimary = "btn-sm btn-primary"; break;
                case "TypeDesc": courses = courses.OrderByDescending(x => x.Type); ViewBag.TyPrimary = "btn-sm btn-success"; break;
                case "StartDateAsc": courses = courses.OrderBy(x => x.StartDate); ViewBag.SdPrimary = "btn-sm btn-primary"; break;
                case "StartDateDesc": courses = courses.OrderByDescending(x => x.StartDate); ViewBag.SdPrimary = "btn-sm btn-success"; break;
                case "EndDateAsc": courses = courses.OrderBy(x => x.EndDate); ViewBag.EdPrimary = "btn-sm btn-primary"; break;
                case "EndDateDesc": courses = courses.OrderByDescending(x => x.EndDate); ViewBag.EdPrimary = "btn-sm btn-success"; break;
                case "FeeAsc": courses = courses.OrderBy(x => x.Fee); ViewBag.FePrimary = "btn-sm btn-primary"; break;
                case "FeeDesc": courses = courses.OrderByDescending(x => x.Fee); ViewBag.FePrimary = "btn-sm btn-success"; break;




                default: courses = courses.OrderBy(x => x.Title); ViewBag.TiPrimary = "btn-sm btn-primary"; break;
            }

            //int pageSize = pSize ?? 3;
            //int pageNumber = page ?? 1;  //nullable coehelesing operator
            //return View(Directors.ToPagedList(pageNumber, pageSize));

            return View(courses);
        }

    // GET: TestCourses/Details/5
    public ActionResult SoloDetails(int? id)//       public ActionResult SimpleDetails(int? id)
        {
            CourseRepository cr = new CourseRepository();
            if (id == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
            Course course = cr.GetById(id);
        if (course == null)
        {
            return HttpNotFound();
        }
            cr.Dispose();
            return View(course);
    }

    }
}