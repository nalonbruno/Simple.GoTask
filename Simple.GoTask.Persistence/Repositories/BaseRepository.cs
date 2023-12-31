﻿using Microsoft.EntityFrameworkCore;
using Simple.GoTask.Domain.Entities;
using Simple.GoTask.Domain.Interfaces;
using Simple.GoTask.Persistence.Context;

namespace Simple.GoTask.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly AppDbContext Context;

    public BaseRepository(AppDbContext context)
    {
        Context = context;
    }

    public void Create(T entity)
    {
        entity.CreatedAt = DateTime.Now;
        Context.Add(entity);
    }

    public void Delete(T entity)
    {
        Context.Remove(entity);
    }

    public async Task<T> Get(Guid id, CancellationToken cancellationToken)
    {
        return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return await Context.Set<T>().ToListAsync(cancellationToken);
    }

    public void Update(T entity)
    {
        entity.UpdatedAt = DateTime.Now;
        Context.Update(entity);
    }
}
