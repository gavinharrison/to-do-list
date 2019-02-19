﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ToDo.Buisness.Tasks
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entiry);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
