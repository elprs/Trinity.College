using System.Linq;
using System.Web.Mvc;
using Trinity.Services;
using Trinity.Web.Models;

namespace Trinity.Web.Controllers
{
    public class StatsController : Controller
    {
        // GET: Stats
        public ActionResult Index()
        {
            StatsViewModel vm = new StatsViewModel();

            CourseRepository cr = new CourseRepository();
            StudentRepository sr = new StudentRepository();
            CourseStudentRepository csr = new CourseStudentRepository();
            SubjectRepository sur = new SubjectRepository();
            TeacherRepository tr = new TeacherRepository();
            AssignmentRepository ar = new AssignmentRepository();
            MarkRepository mr = new MarkRepository();



            var courses = cr.GetAll();
            var students = sr.GetAll();
            var subjects = sur.GetAll();
            var teachers = tr.GetAll();
            var assignments = ar.GetAll();
            var marks = mr.GetAll();
            var courseStudents = csr.GetAll();
           

            vm.CoursesCount = courses.Count();
            vm.StudentsCount = students.Count();
            vm.SubjectsCount = subjects.Count();
            vm.TeachersCount = teachers.Count();
            vm.AssignmentsCount = assignments.Count();
            vm.MarksCount = marks.Count();

           

            return View(vm);
        }

        public  ActionResult InterConnectedModelStats()
        {
            AllEntities vm = new AllEntities();

            //Has the logic in the View

            return View(vm);
        }
        //public  ActionResult ThreeTableModelStatsTable()
        //{
        //    AllEntities vm = new AllEntities();



        //    return View(vm);
        //}
    }
}