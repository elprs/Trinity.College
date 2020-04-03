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
    public class SubjectRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Subject> GetAll()
        {
            return db.Subjects.ToList();
        }

        //GetByID
        public Subject GetById(int? id)
        {
            return db.Subjects.Find(id);
        }

        //Insert
        public void Insert(Subject su)
        {
            db.Entry(su).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Subject su)
        {
            db.Entry(su).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Subject su)
        {
            db.Entry(su).State = EntityState.Deleted;
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
