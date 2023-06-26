﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll( bool trackChanges, Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
