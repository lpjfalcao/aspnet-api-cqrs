﻿using Ambev.DeveloperEvaluation.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DefaultContext context;

        public RepositoryBase(DefaultContext context)
        {
            this.context = context;
        }

        public void Create(T entity)
        {
            this.context.Set<T>().Add(entity);
        }

        public async Task<IEnumerable<T>> GetListByCondition(Expression<Func<T, bool>> expression)
        {
            return await this.context.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges = false)
        {
            return trackChanges ? await this.context.Set<T>().Where(expression).FirstOrDefaultAsync()
                                : await this.context.Set<T>().Where(expression).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.context.Set<T>().AsNoTracking().ToListAsync();
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }

        public void Remove(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public async Task Commit()
        {
            await this.context.SaveChangesAsync();
        }
    }
}