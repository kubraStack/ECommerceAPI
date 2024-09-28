using Core.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>, IAsyncRepository<TEntity>
        where TContext : DbContext
        where TEntity : Entity

    {
        private readonly TContext Context;
        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }
        public void Add(TEntity entity)
        {
           Context.Add(entity);
           Context.SaveChanges();
        }

        public async Task AddAsync(TEntity entity)
        {
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();

        }

        public void Delete(TEntity entity)
        {
            Context.Remove(entity); 
            Context.SaveChanges();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            Context.Remove(entity);
            await Context.SaveChangesAsync();
        }

        //Filter - OrderBy
        public TEntity? Get(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
           IQueryable<TEntity> data = Context.Set<TEntity>();
            if (include != null)
            {
                data = include(data);
            }
            return data.FirstOrDefault(predicate);
        }

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> data = Context.Set<TEntity>();
            if (include != null)
            {
                data = include(data);
            }
            return await data.FirstOrDefaultAsync(predicate);
        }

        public TEntity? GetById(int id, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();
            if (include != null)
            {
                query = include(query);
            }

            return query.FirstOrDefault(i => EF.Property<int>(i, "Id") == id);
        }

        public Task<TEntity?> GetByIdAsync(int id, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();
            if (include != null)
            {
                query = include(query);
            }
            return query.FirstOrDefaultAsync(i => EF.Property<int>(i,"Id") == id);
        }

        //Filter - OrderBy
        public List<TEntity> GetList(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> data = Context.Set<TEntity>();
            if (predicate != null)
                data = data.Where(predicate);

            if (include != null)
                data = include(data);

            return data.ToList();
            
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> data = Context.Set<TEntity>();

            if (predicate != null)
                data = data.Where(predicate);
            if (include != null)
                data = include(data);

            return await data.ToListAsync();
  
        }

        public async Task SoftDeleteAsync(TEntity entity)
        {
            var datas = Context.ChangeTracker.Entries<TEntity>();
            //ChangeTracker => Bağlam tarafından izlenen tüm TEntity türündeki nesneleri alır. Bu, veritabanında yapılan değişikliklerin izlenmesi ve yönetilmesi için kullanılır.

            foreach (var item in datas)
            {
                if (item.Entity is ISoftDeletable e) //ISoftDeletable arayüzünün implemente edilmesini kontrol eder
                {
                   
                    item.State = EntityState.Modified;
                    e.IsDeleted = true;
                }
            }
            await Context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            Context.Update(entity);
            Context.SaveChanges();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            Context.Update(entity);
            await Context.SaveChangesAsync();   
        }
    }
}
