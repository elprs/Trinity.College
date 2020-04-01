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
    public class TeacherRepository
    {

        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Teacher> GetAll()
        {
            return db.Teachers.ToList();
        }

        //GetByID
        public Teacher GetById(int? id)
        {

            return db.Teachers.Find(id);
        }

        //Insert
        public void Insert(Teacher t)
        {
            db.Entry(t).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Teacher t)
        {
            db.Entry(t).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Teacher t)
        {
            db.Entry(t).State = EntityState.Deleted;
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
