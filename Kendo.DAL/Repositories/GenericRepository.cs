using Kendo.DAL.Abstract;
using Kendo.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kendo.DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        ProjeKendoContext db = new ProjeKendoContext();
        DbSet<T> obj;
        public GenericRepository()
        {
            obj=db.Set<T>();
        }
        public void Delete(T d)
        {
            var deleteEntity=db.Entry(d);
            deleteEntity.State = EntityState.Deleted;
            db.SaveChanges();
        }

        public T get(Expression<Func<T, bool>> filiter)
        {
            return obj.SingleOrDefault(filiter);
        }

        public List<T> GetAll()
        {
            return obj.ToList();
        }

        public void Insert(T d)
        {
           var insertEntity=db.Entry(d);
            insertEntity.State = EntityState.Added;
            db.SaveChanges();
        }

        public void Update(T d)
        {
            var updateEntity=db.Entry(d);
            updateEntity.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
