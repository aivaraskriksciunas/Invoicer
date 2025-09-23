namespace Invoicer.Api.Common.EntityServices;

public interface IEntityService<TEntity, TKey>
{
    public Task<TEntity?> Find( TKey key );

    public Task<TEntity> Add( TEntity entity );

    public Task Remove( TEntity entity );
}
