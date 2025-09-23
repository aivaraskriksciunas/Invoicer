using Invoicer.Api.Services;
using Microsoft.EntityFrameworkCore;

namespace Invoicer.Api.Common.EntityServices;

public abstract class BaseEntityService<TEntity, TKey> : IEntityService<TEntity, TKey> where TEntity : class
{
    protected readonly InvoicerContext db;

    public BaseEntityService( InvoicerContext context ) 
    {
        db = context;
    }

    public async Task<List<TEntity>> List()
    {
        return await db.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> Add( TEntity entity )
    {
        await db.Set<TEntity>().AddAsync( entity );
        await db.SaveChangesAsync();

        return entity;
    }

    public async Task Remove( TEntity entity )
    {
        db.Set<TEntity>().Remove( entity );
        await db.SaveChangesAsync();
    }

    public async Task<TEntity?> Find( TKey key )
    {
        return await db.Set<TEntity>().FindAsync( key );
    }
}
