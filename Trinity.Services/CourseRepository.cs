using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trinity.Database;
using System.Threading.Tasks;
using Trinity.Entities;
using System.Data.Entity;

namespace Trinity.Services
{
   public class CourseRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Course> GetAll()
        {
            return db.Courses.Include(x => x.Subjects).Include(x => x.CourseStudents).ToList();
        }

        //GetByID
        public Course GetById(int? id)
        {
            return db.Courses.Find(id);
        }

        //Insert
        public void Insert(Course c)
        {
            db.Entry(c).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Course c, IEnumerable<int> selectedSubjectsIds) //++++++++++++++++++++++++++++++++++++++++++++++++
        {
            //++++++++++++++++++++++++++++++++ apo edo eos...>>>>>>>>>>>>
            //Katharise ka8e subject apo to course
            //exomai kai diabazo kai tin exo mono gia anagnosi
            db.Courses.Attach(c); //anagnosi
            db.Entry(c).Collection("Subjects")  //elakai fortwse to course kai ti sullogi pou exo mazi toyu -->ta subjectsd
                       .Load(); ////fortwsi //
            c.Subjects.Clear(); //katharise // to course na min exei kanena subjects
            db.SaveChanges(); // sose allages

           //checking for null
            if (!(selectedSubjectsIds is null ))
                foreach (var id in selectedSubjectsIds)
                {
                    Subject subject = db.Subjects.Find(id);
                    if (subject != null)
                    {
                        c.Subjects.Add(subject);
                    }
                }
            db.SaveChanges();
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
            //++++++++++++++++++++++++++++++++++++++...>>>>EDO!!!
        }

        //Delete
        public void Delete(Course c)
        {
            db.Entry(c).State = EntityState.Deleted;
            db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
