namespace Devantler.DataMesh.DataProduct.Features.DataStore.Services;

/// <summary>
/// Generic interface for services that interact with datastores.
/// </summary>
/// <typeparam name="TSchema"></typeparam>
public interface IDataStoreService<TSchema> where TSchema : class
{
    /// <summary>
    /// Creates a single <typeparamref name="TSchema"/> in a data store.
    /// </summary>
    /// <param name="schema"></param>
    /// <param name="cancellationToken"></param>
    Task<TSchema> CreateSingleAsync(TSchema schema, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates multiple <typeparamref name="TSchema"/>'s in a data store.
    /// </summary>
    /// <param name="models"></param>
    /// <param name="cancellationToken"></param>
    Task<int> CreateMultipleAsync(IEnumerable<TSchema> models, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads a single <typeparamref name="TSchema"/> from a data store.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    Task<TSchema> GetSingleAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all <typeparamref name="TSchema"/>'s from a data store.
    /// </summary>
    /// <param name="cancellationToken"></param>
    Task<IEnumerable<TSchema>> GetAllAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets all <typeparamref name="TSchema"/>'s from a data store as queryable objects.
    /// </summary>
    /// <param name="cancellationToken"></param>
    Task<IQueryable<TSchema>> GetAllAsQueryableAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Read multiple <typeparamref name="TSchema"/>'s from a data store.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="cancellationToken"></param>
    Task<IEnumerable<TSchema>> GetMultipleAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads paged <typeparamref name="TSchema"/>'s from a data store.
    /// </summary>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <param name="cancellationToken"></param>
    Task<IEnumerable<TSchema>> GetMultipleWithPaginationAsync(int page, int pageSize,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Reads <typeparamref name="TSchema"/>'s from a data store with a limit and an offset.
    /// </summary>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="cancellationToken"></param>
    Task<IEnumerable<TSchema>> GetMultipleWithLimitAsync(int limit, int offset,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates a single <typeparamref name="TSchema"/> in a data store.
    /// </summary>
    /// <param name="schema"></param>
    /// <param name="cancellationToken"></param>
    Task<TSchema> UpdateSingleAsync(TSchema schema, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates multiple <typeparamref name="TSchema"/>'s in a data store.
    /// </summary>
    /// <param name="models"></param>
    /// <param name="cancellationToken"></param>
    Task<int> UpdateMultipleAsync(IEnumerable<TSchema> models, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a single <typeparamref name="TSchema"/> from a data store.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    Task<TSchema> DeleteSingleAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes multiple <typeparamref name="TSchema"/>'s from a data store.
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="cancellationToken"></param>
    Task<int> DeleteMultipleAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default);
}