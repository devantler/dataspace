﻿//HintName: Query.g.cs
// <auto-generated>
// This code was generated by: 'Devantler.DataMesh.DataProduct.Generator.IncrementalGenerators.GraphQLQueryGenerator'.
// Any changes made to this file will be overwritten.
using Devantler.DataMesh.DataProduct.Features.DataStore.Services;
using Devantler.DataMesh.DataProduct.Features.Schemas;
namespace Devantler.DataMesh.DataProduct.Features.Apis.GraphQL;
public partial class Query
{
    /// <summary>
    /// Queries RecordSchemaPrimitiveTypes from the data store.
    /// </summary>
    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<IEnumerable<RecordSchemaPrimitiveTypes>> GetRecordSchemaPrimitiveTypes([Service] IDataStoreService<Guid, RecordSchemaPrimitiveTypes> dataStoreService, CancellationToken cancellationToken)
        => await dataStoreService.GetAllAsync(cancellationToken);

}
