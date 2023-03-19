﻿//HintName: CachingStartupExtensions.g.cs
// <auto-generated>
// This code was generated by: 'Devantler.DataMesh.DataProduct.Generator.IncrementalGenerators.CachingStartupExtensionsGenerator'.
// Any changes made to this file will be overwritten.
using Devantler.DataMesh.DataProduct.Features.Caching.Services;
using Devantler.DataMesh.DataProduct.Configuration.Options;
using Devantler.DataMesh.DataProduct.Features.DataStore.Entities;
namespace Devantler.DataMesh.DataProduct.Features.Caching;
/// <summary>
/// A class that contains extension methods for service registrations and usages for caching.
/// </summary>
public static partial class CachingStartupExtensions
{
    /// <summary>
    /// Adds generated service registrations for caching.
    /// </summary>
    static partial void AddGeneratedServiceRegistrations(this IServiceCollection services, DataProductOptions options)
    {
        _ = services.AddScoped<ICacheStoreService<string, RecordSchemaPrimitiveTypesEntity>, InMemoryCacheStoreService<string, RecordSchemaPrimitiveTypesEntity>>();
    }
}