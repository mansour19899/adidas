using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adidas.Models.Repositores
{
    public class PersonRepository : IDisposable
    {
        private Adidas.Models.DomainModels.AdidasTehranEntities db = null;

        public PersonRepository()
        {
            db = new DomainModels.AdidasTehranEntities();
        }

        public bool Add(Adidas.Models.DomainModels.Person entity, bool autoSave = true)
        {
            try
            {
                db.People.Add(entity);
                if (autoSave)
                    return Convert.ToBoolean(db.SaveChanges());
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Adidas.Models.DomainModels.Person entity, bool autoSave = true)
        {
            try
            {
                db.People.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                if (autoSave)
                    return Convert.ToBoolean(db.SaveChanges());
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Adidas.Models.DomainModels.Person entity, bool autoSave = true)
        {
            try
            {
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                if (autoSave)
                    return Convert.ToBoolean(db.SaveChanges());
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id, bool autoSave = true)
        {
            try
            {
                var entity = db.People.Find(id);
                db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                if (autoSave)
                    return Convert.ToBoolean(db.SaveChanges());
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public Adidas.Models.DomainModels.Person Find(int id)
        {
            try
            {
                return db.People.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<Adidas.Models.DomainModels.Person> Where(System.Linq.Expressions.Expression<Func<Adidas.Models.DomainModels.Person, bool>> predicate)
        {
            try
            {
                return db.People.Where(predicate);
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<Adidas.Models.DomainModels.Person> Select()
        {
            try
            {
                return db.People.AsQueryable();
            }
            catch
            {
                return null;
            }
        }

        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<Adidas.Models.DomainModels.Person, TResult>> selector)
        {
            try
            {
                return db.People.Select(selector);
            }
            catch
            {
                return null;
            }
        }

        public int GetLastIdentity()
        {
            try
            {
                if (db.People.Any())
                    return db.People.OrderByDescending(p => p.Id).First().Id;
                else
                    return 0;
            }
            catch
            {
                return -1;
            }
        }

        public int Save()
        {
            try
            {
                return db.SaveChanges();
            }
            catch
            {
                return -1;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }

        ~PersonRepository()
        {
            Dispose(false);
        }
    }
}