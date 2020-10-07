using System.Collections.Generic;
using System.Linq;
using dotnetapp.data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace dotnetapp.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new() //kısıtlamalar yazmasakda olur
    {
        public void Create(TEntity entity)
        {
            using(var context=new TContext())
            {
                context.Set<TEntity>().Add(entity); //ekleme yapıldı
                context.SaveChanges(); //değişikler kaydedildi.
            }
        }

        public void Delete(TEntity entity)
        {
            using(var context=new TContext())
            {
                context.Set<TEntity>().Remove(entity); //silme yapıldı
                context.SaveChanges(); //değişikler kaydedildi.
            }
        }

        public List<TEntity> GetAll()
        {
            using(var context=new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using(var context=new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            using(var context=new TContext())
            {
                context.Entry(entity).State=EntityState.Modified; //güncelle yapıldı
                context.SaveChanges(); //değişikler kaydedildi.
            }
        }
    }
}