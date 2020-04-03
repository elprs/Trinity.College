using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Trinity.Database;
using Trinity.Entities;

namespace Trinity.Services
{
    public class AssignmentRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Assignment> GetAll()
        {
            return db.Assignments.ToList();
        }

        //GetByID
        public Assignment GetById(int? id)
        {
            return db.Assignments.Find(id);
        }

        //Insert
        public void Insert(Assignment a)
        {
            db.Entry(a).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Assignment a)
        {
            db.Entry(a).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Assignment a)
        {
            db.Entry(a).State = EntityState.Deleted;
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
