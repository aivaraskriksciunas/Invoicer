using Invoicer.Api.Services;
using Microsoft.EntityFrameworkCore;

namespace Invoicer.Api.Common.Repositories;

public abstract class BaseEntityService<TEntity, TKey> : IEntityService<TEntity, TKey> where TEntity : class
{
    private readonly InvoicerContext _db;

    public BaseEntityService( InvoicerContext context ) 
    {
        _db = context;
    }

    public async Task<List<TEntity>> List()
    {
        return await _db.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> Create( TEntity entity )
    {
        await _db.Set<TEntity>().AddAsync( entity );
        await _db.SaveChangesAsync();

        return entity;
    }

    public async Task Delete( TEntity entity )
    {
        _db.Set<TEntity>().Remove( entity );
        await _db.SaveChangesAsync();
    }

    public async Task<TEntity?> Find( TKey key )
    {
        return await _db.Set<TEntity>().FindAsync( key );
    }
}
