using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NorthWind.DataAccess.Abstract;

namespace NorthWind.DataAccess.Concrete.EntityFrameWork
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                var list = filter != null ?
                    context.Set<TEntity>().Where(filter).ToList() :
                    context.Set<TEntity>().ToList();

                return list;
            }
        }

        public void Add(TEntity entry)
        {
            using (TContext context = new TContext())
            {
                var ent = context.Entry(entry);
                ent.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entry)
        {
            using (TContext context = new TContext())
            {
                var ent = context.Entry(entry);
                ent.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Delete(TEntity entry)
        {
            using (TContext context = new TContext())
            {
                var ent = context.Entry(entry);
                ent.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
