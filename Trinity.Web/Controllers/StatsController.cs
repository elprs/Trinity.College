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
        public ActionResult ThreeTableModelStatsTable()
        {
            AllEntities vm = new AllEntities();


            //var person = (from p in PersonBooks
            //              join b in Book on p.BookId equals b.BookId
            //              where b.BookId  IN(2, 3, 4)
            //      select new { p.PersonId });


            //var query = (from s in vm.Students
            //             join m in vm.Marks on s.StudentId equals m.StudentId
            //             join cs in vm.CourseStudents on s.StudentId equals cs.StudentId
            //            select 

            //from p in Context.Book
            //where (Context.PersonBooks.Where(x => personIds.Contains(x.PersonId))
            //            .GroupBy(x => x.BookId)
            //            .Where(x => x.Count() == personIds.Count)
            //            .OrderByDescending(x => x.Count())
            //            .Select(x => x.Key).ToList()).Contains(p.BookId)
            //select p;



            //var query = from student in vm.Students
            //                where (  vm.CourseStudents.Where(x=> x.StudentId == student.StudentId)
            //                .GroupBy (x=>vm.Assignments.)

            //            select p;

            return View(vm);
        }
    }
}