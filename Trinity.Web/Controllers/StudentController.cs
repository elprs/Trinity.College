using System;
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


            ViewBag.FNPrimary = "btn-sm btn-primary";
            ViewBag.LNPrimary = "btn-sm btn-primary";
            ViewBag.TePrimary = "btn-sm btn-primary";
            ViewBag.EmPrimary = "btn-sm btn-primary";



            StudentRepository cr = new StudentRepository();
            var students = cr.GetAll();



            //======================FILTERS===============================
            //Filtering  FirstName
            if (!string.IsNullOrWhiteSpace(searchFirstName))
            {
                students = students.Where(x => x.FirstName.ToUpper().Contains(searchFirstName.ToUpper()));
            }
            //Filtering  LastName
            if (!string.IsNullOrWhiteSpace(searchLastName))
            {
                students = students.Where(x => x.LastName.ToUpper().Contains(searchLastName.ToUpper()));
            }
            //Filtering  Telephone
            if (!(searchTelephone is null))
            {
                students = students.Where(x => x.Telephone.Contains(searchTelephone));
            }
            //Filtering Email
            if (!(searchEmail is null))
            {
                students = students.Where(x => x.Email.Contains(searchEmail));
            }




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
            cr.Dispose();

            int pageSize = pSize ?? 3;
            int pageNumber = page ?? 1; 


            return View(students.ToPagedList(pageNumber, pageSize));
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