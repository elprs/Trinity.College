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
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentTableAdmin(string sortOrder, string searchFirstName, string searchLastName, string searchTelephone, string searchEmail,  int? page, int? pSize)
        {

            ViewBag.CurrentFirstName = searchFirstName;
            ViewBag.CurrentLastName = searchLastName;
            ViewBag.CurrentTelephone = searchTelephone;
            ViewBag.CurrentEmail = searchEmail;
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.FirstNameSortParam = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LastNameSortParam = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.TelephoneSortParam = sortOrder == "TelephoneAsc" ? "TelephoneDesc" : "TelephoneAsc";
            ViewBag.EmailSortParam = sortOrder == "EmailAsc" ? "EmailDesc" : "EmailAsc";
            ViewBag.DetailsSortParam = sortOrder == "DetailsAsc" ? "DetailsDesc" : "DetailsAsc";


            ViewBag.FNPrimary = "btn-sm btn-primary";
            ViewBag.LNPrimary = "btn-sm btn-primary";
            ViewBag.TePrimary = "btn-sm btn-primary";
            ViewBag.EmPrimary = "btn-sm btn-primary";



            StudentRepository cr = new StudentRepository();
            var students = cr.GetAll();
            cr.Dispose();


            ////======================FILTERS===============================
            ////Filtering  FirstName
            //if (!string.IsNullOrWhiteSpace(searchfirstname))
            //{
            //    Students = Students.Where(x => x.FirstName.ToUpper().Contains(searchfirstname.ToUpper()));
            //}
            ////Filtering  LastName
            //if (!string.IsNullOrWhiteSpace(searchlastname))
            //{
            //    Students = Students.Where(x => x.LastName.ToUpper().Contains(searchlastname.ToUpper()));
            //}
            ////Filtering  Minimum Age
            //if (!(searchminage is null)) //40
            //{
            //    Students = Students.Where(x => x.Age >= searchminage);
            //}
            ////Filtering  Maximum Age
            //if (!(searchmaxage is null)) //50
            //{
            //    Students = Students.Where(x => x.Age <= searchmaxage);
            //}

            ////Sorting



            switch (sortOrder)
            {
                case "FirstNameDesc": students = students.OrderByDescending(x => x.FirstName); ViewBag.FNPrimary = "btn-sm btn-success"; break;
                case "LastNameAsc": students = students.OrderBy(x => x.LastName); ViewBag.LNPrimary = "btn-sm btn-primary"; break;
                case "LastNameDesc": students = students.OrderByDescending(x => x.LastName); ViewBag.LNPrimary = "btn-sm btn-success"; break;
                case "TelephoneAsc": students = students.OrderBy(x => x.Telephone); ViewBag.TePrimary = "btn-sm btn-primary"; break;
                case "TelephoneDesc": students = students.OrderByDescending(x => x.Telephone); ViewBag.TePrimary = "btn-sm btn-success"; break;
                case "EmailAsc": students = students.OrderBy(x => x.Email); ViewBag.EmPrimary = "btn-sm btn-primary"; break;
                case "EmailDesc": students = students.OrderByDescending(x => x.Email); ViewBag.EmPrimary = "btn-sm btn-success"; break;




                default: students = students.OrderBy(x => x.FirstName); ViewBag.FNPrimary = "btn-sm btn-primary"; break;
            }

            //int pageSize = pSize ?? 3;
            //int pageNumber = page ?? 1;  //nullable coehelesing operator
            //return View(students.ToPagedList(pageNumber, pageSize));

            return View(students);
        }

        // GET: TestStudents/Details/5
        public ActionResult SimpleDetails(int? id)//       public ActionResult SimpleDetails(int? id)
        {
            StudentRepository cr = new StudentRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = cr.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            cr.Dispose();
            return View(student);
        }

    }
}