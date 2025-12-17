using Core.Interfaces;
using Core.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.EntityFramework
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()   //Parametre olarak verilebilecek generic yapılı Entity'nin koşulları
        where TContext : DbContext, new()   //Parametre olarak verilebilecek generic yapılı Context'in koşulları
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);    //Entity'in referansını tabloda yakalama
                addedEntity.State = EntityState.Added;  //Bu nesnenin durumunu eklendi olarak set et
                context.SaveChanges();  //Yapılan işlemleri tabloya yansıt.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity? Get(Expression<Func<TEntity, bool>>? filter)
        {
            using (TContext context = new TContext())
            {
                Expression<Func<TEntity, bool>> notDeleted = e => !e.IsDeleted;

                var finalFilter = filter == null
                    ? notDeleted
                    : filter.And(notDeleted);

                return context.Set<TEntity>().SingleOrDefault(finalFilter);
            }
        }


        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                IQueryable<TEntity> query = context.Set<TEntity>();

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                return query.Where(e => e.IsDeleted == false)   //Aktif kayıtları getirmesi için ekledim.
                    .Take(100)   //.Take(100) 100 kayıt sınırı koydum.
                    .ToList();   
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
