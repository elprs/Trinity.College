using PagedList;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Trinity.Entities;
using Trinity.Services;

namespace Trinity.Web.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult TeacherTables(string sortOrder, string searchFirstName, string searchLastName, string searchTelephone, string searchEmail, string searchSalary, int? page, int? pSize)
        {

            ViewBag.CurrentFirstName = searchFirstName;
            ViewBag.CurrentLastName = searchLastName;
            ViewBag.CurrentTelephone = searchTelephone;
            ViewBag.CurrentEmail = searchEmail;
            ViewBag.CurrentEmail = searchSalary;

            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentpSize = pSize;

            ViewBag.FirstNameSortParam = String.IsNullOrEmpty(sortOrder) ? "FirstNameDesc" : "";
            ViewBag.LastNameSortParam = sortOrder == "LastNameAsc" ? "LastNameDesc" : "LastNameAsc";
            ViewBag.TelephoneSortParam = sortOrder == "TelephoneAsc" ? "TelephoneDesc" : "TelephoneAsc";
            ViewBag.EmailSortParam = sortOrder == "EmailAsc" ? "EmailDesc" : "EmailAsc";
            ViewBag.SalarySortParam = sortOrder == "SalaryAsc" ? "SalaryDesc" : "SalaryAsc";


            ViewBag.FNPrimary = "btn-sm btn-primary";
            ViewBag.LNPrimary = "btn-sm btn-primary";
            ViewBag.TePrimary = "btn-sm btn-primary";
            ViewBag.EmPrimary = "btn-sm btn-primary";
            ViewBag.SaPrimary = "btn-sm btn-primary";



            TeacherRepository tr = new TeacherRepository();
            var teachers = tr.GetAll();



            //======================FILTERS===============================
            //Filtering  FirstName
            if (!string.IsNullOrWhiteSpace(searchFirstName))
            {
                teachers = teachers.Where(x => x.FirstName.ToUpper().Contains(searchFirstName.ToUpper()));
            }
            //Filtering  LastName
            if (!string.IsNullOrWhiteSpace(searchLastName))
            {
                teachers = teachers.Where(x => x.LastName.ToUpper().Contains(searchLastName.ToUpper()));
            }
            //Filtering  Telephone
            if (!(searchTelephone is null))
            {
                teachers = teachers.Where(x => x.Telephone.Contains(searchTelephone));
            }
            //Filtering Email
            if (!(searchEmail is null))
            {
                teachers = teachers.Where(x => x.Email.Contains(searchEmail));
            }
            //Filtering Salary
            if (!(searchSalary is null))
            {
                teachers = teachers.Where(x => x.Salary.ToString().Contains(searchSalary));
            }




            ////Sorting

            switch (sortOrder)
            {
                case "FirstNameDesc": teachers = teachers.OrderByDescending(x => x.FirstName); ViewBag.FNPrimary = "btn-sm btn-success"; break;
                case "LastNameAsc": teachers = teachers.OrderBy(x => x.LastName); ViewBag.LNPrimary = "btn-sm btn-primary"; break;
                case "LastNameDesc": teachers = teachers.OrderByDescending(x => x.LastName); ViewBag.LNPrimary = "btn-sm btn-success"; break;
                case "TelephoneAsc": teachers = teachers.OrderBy(x => x.Telephone); ViewBag.TePrimary = "btn-sm btn-primary"; break;
                case "TelephoneDesc": teachers = teachers.OrderByDescending(x => x.Telephone); ViewBag.TePrimary = "btn-sm btn-success"; break;
                case "EmailAsc": teachers = teachers.OrderBy(x => x.Email); ViewBag.EmPrimary = "btn-sm btn-primary"; break;
                case "EmailDesc": teachers = teachers.OrderByDescending(x => x.Email); ViewBag.EmPrimary = "btn-sm btn-success"; break;
                case "SalaryAsc": teachers = teachers.OrderBy(x => x.Salary); ViewBag.SaPrimary = "btn-sm btn-primary"; break;
                case "SalaryDesc": teachers = teachers.OrderByDescending(x => x.Salary); ViewBag.SaPrimary = "btn-sm btn-success"; break;




                default: teachers = teachers.OrderBy(x => x.FirstName); ViewBag.FNPrimary = "btn-sm btn-primary"; break;
            }

            tr.Dispose();

            int pageSize = pSize ?? 2;
            int pageNumber = page ?? 1;


            return View(teachers.ToPagedList(pageNumber, pageSize));
        }

        // GET: TestTeachers/Details/5
        public ActionResult SimpleDetails(int? id)
        {
            TeacherRepository cr = new TeacherRepository();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher Teacher = cr.GetById(id);
            if (Teacher == null)
            {
                return HttpNotFound();
            }
            cr.Dispose();
            return View(Teacher);
        }

    }
}