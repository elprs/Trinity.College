using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Trinity.Database;
using Trinity.Entities;

namespace Trinity.Services
{
    public class MarkRepository
    {
        MyDatabase db = new MyDatabase();

        //GetAll()
        public IEnumerable<Mark> GetAll()
        {
            return db.Marks.ToList();
        }

        //GetByID
        public Mark GetById(int? id)
        {
            return db.Marks.Find(id);
        }

        //Insert
        public void Insert(Mark m)
        {
            db.Entry(m).State = EntityState.Added;
            db.SaveChanges();
        }

        //Update
        public void Update(Mark m)
        {
            db.Entry(m).State = EntityState.Modified;
            db.SaveChanges();
        }

        //Delete
        public void Delete(Mark m)
        {
            db.Entry(m).State = EntityState.Deleted;
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
