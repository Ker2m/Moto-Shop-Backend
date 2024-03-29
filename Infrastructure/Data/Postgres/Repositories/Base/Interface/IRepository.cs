﻿using Core.Utilities.Pagination;
using System.Linq.Expressions;


namespace Infrastructure.Data.Postgres.Repositories.Base.Interface;

public interface IRepository<TEntity, in TId> where TEntity : class
{
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(IEnumerable<TEntity> entities);
    Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter);
    Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);
    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filter);
	Task<TEntity> GetByIdAsync<TId>(TId? id);
	Task<int> GetCountAsync(Expression<Func<TEntity, bool>>? filter = null);
    void Remove(TEntity entity);
    void RemoveById(TId id);
	Task RemoveByIdAsync<TId>(TId? id);
	void RemoveRange(IEnumerable<TEntity> entities);
    void UntrackEntity(TEntity entity);
    void Update(TEntity entity);
    void UpdateRange(IEnumerable<TEntity> entities);
}