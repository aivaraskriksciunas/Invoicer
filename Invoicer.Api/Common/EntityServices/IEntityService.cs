namespace Invoicer.Api.Common.Repositories;

public interface IEntityService<TEntity, TKey>
{
    public Task<TEntity?> Find( TKey key );

    public Task<TEntity> Create( TEntity entity );

    public Task Delete( TEntity entity );
}
