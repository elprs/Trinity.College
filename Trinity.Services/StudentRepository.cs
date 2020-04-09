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
    public class StudentRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Student> GetAll()
        {
            return db.Students.ToList();
        }

        //GetByID
        public Student GetById(int? id)
        {
            return db.Students.Find(id);
        }

        //Insert
        public void Insert(Student s)
        {
            db.Entry(s).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Student s, IEnumerable<int> selectedMarkIds)
        {
            db.Students.Attach(s);
            db.Entry(s).Collection("Marks").Load();
            s.Marks.Clear();
            db.SaveChanges();

            //checking for null
            if (!(selectedMarkIds is null))
            {
                foreach (var id in selectedMarkIds)
                {
                    Mark mark = db.Marks.Find(id);
                    if (mark != null)
                    {
                        s.Marks.Add(mark);
                    }
                }
            }
            db.SaveChanges();
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Student s)
        {
            db.Entry(s).State = EntityState.Deleted;
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
