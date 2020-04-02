﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Trinity.Entities;
using Trinity.Services;
using PagedList.Mvc;
using PagedList;

namespace Trinity.Web.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult CourseTables(string sortOrder, string searchTitle, string searchType, string searchStartDate, string searchEndDate, double? searchMinFee, double? searchMaxFee, int? page, int? pSize)
        {

            ViewBag.CurrentTitle = searchTitle;
            ViewBag.CurrentType = searchType;
            ViewBag.CurrentStartDate = searchStartDate;
            ViewBag.CurrentEndDate = searchEndDate;
            ViewBag.CurrentMinFee = searchMinFee;
            ViewBag.CurrentMaxFee = searchMaxFee;

            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;


            ViewBag.TitleSortParam = String.IsNullOrEmpty(sortOrder) ? "TitleDesc" : "";
            ViewBag.TypeSortParam = sortOrder == "TypeAsc" ? "TypeDesc" : "TypeAsc";
            ViewBag.StartDateSortParam = sortOrder == "StartDateAsc" ? "StartDateDesc" : "StartDateAsc";
            ViewBag.EndDateSortParam = sortOrder == "EndDateAsc" ? "EndDateDesc" : "EndDateAsc";
            ViewBag.FeeSortParam = sortOrder == "FeeAsc" ? "FeeDesc" : "FeeAsc";



            ViewBag.TiView = "btn-sm btn-primary";
            ViewBag.TyView = "btn-sm btn-primary";
            ViewBag.SdView = "btn-sm btn-primary";
            ViewBag.EdView = "btn-sm btn-primary";
            ViewBag.FeView = "btn-sm btn-primary";



            CourseRepository cr = new CourseRepository();
            var courses = cr.GetAll();


            //======================FILTERS===============================
            //Filtering  Title
            if (!string.IsNullOrWhiteSpace(searchTitle))
            {
                courses = courses.Where(x => x.Title.ToUpper().Contains(searchTitle.ToUpper()));
            }
            //Filtering Type
            if (!string.IsNullOrWhiteSpace(searchType))
            {
                courses = courses.Where(x => x.Type.ToString().ToUpper().Contains(searchType.ToUpper()));
            }
            //Filtering  StartDate
            if (!(searchStartDate == null))
            {
                courses = courses.Where(x => x.StartDate.ToString().ToUpper().Contains( searchStartDate.ToString().ToUpper()));
            }
            //Filtering  EndDate
            if (!(searchEndDate == null))
            {
                courses = courses.Where(x => x.EndDate.ToString().ToUpper().Contains(searchEndDate.ToString().ToUpper()));
            }
                //Filtering  Minimum Fee
                if (!(searchMinFee is null))
            {
                courses = courses.Where(x => x.Fee >= searchMinFee);
            }
            //Filtering  Maximum Fee
            if (!(searchMaxFee is null)) //50
            {
                courses = courses.Where(x => x.Fee <= searchMaxFee);
            }


            //Sorting
            switch (sortOrder)
            {
                case "TitleDesc": courses = courses.OrderByDescending(x => x.Title).ThenBy(x => x.Fee); ViewBag.TiView = "btn-sm btn-success"; break;
                case "TypeAsc": courses = courses.OrderBy(x => x.Type).ThenBy(x => x.Fee); ViewBag.TyView = "btn-sm btn-primary"; break;
                case "TypeDesc": courses = courses.OrderByDescending(x => x.Type).ThenBy(x => x.Fee); ViewBag.TyView = "btn-sm btn-success"; break;
                case "StartDateAsc": courses = courses.OrderBy(x => x.StartDate).ThenBy(x => x.Fee); ViewBag.SdView = "btn-sm btn-primary"; break;
                case "StartDateDesc": courses = courses.OrderByDescending(x => x.StartDate).ThenBy(x => x.Fee); ViewBag.SdView = "btn-sm btn-success"; break;
                case "EndDateAsc": courses = courses.OrderBy(x => x.EndDate).ThenBy(x => x.Fee); ViewBag.EdView = "btn-sm btn-primary"; break;
                case "EndDateDesc": courses = courses.OrderByDescending(x => x.EndDate).ThenBy(x => x.Fee); ViewBag.EdView = "btn-sm btn-success"; break;
                case "FeeAsc": courses = courses.OrderBy(x => x.Fee).ThenBy(x => x.Title); ViewBag.FeView = "btn-sm btn-primary"; break;
                case "FeeDesc": courses = courses.OrderByDescending(x => x.Fee).ThenBy(x => x.Title); ViewBag.FeView = "btn-sm btn-success"; break;


                default: courses = courses.OrderBy(x => x.Title); ViewBag.TiView = "btn-sm btn-primary"; break;
            }
            cr.Dispose();

            //Pagination
            int pageSize = pSize ?? 2;
            int pageNumber = page ?? 1;
            

            return View(courses.ToPagedList(pageNumber, pageSize));
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