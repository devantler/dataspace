﻿//HintName: RecordSchemaPrimitiveTypesController.g.cs
// <auto-generated>
// This code was generated by: 'Devantler.DataMesh.DataProduct.Generator.IncrementalGenerators.RestApiControllerGenerator'.
// Any changes made to this file will be overwritten.
using AutoMapper;
using Devantler.DataMesh.DataProduct.Features.Schemas;
using Devantler.DataMesh.DataProduct.Features.DataStore.Entities;
using Devantler.DataMesh.DataProduct.Features.DataStore.Services;
namespace Devantler.DataMesh.DataProduct.Features.Apis.Rest;
/// <summary>
/// A controller to handle REST API requests for a the <see cref="RecordSchemaPrimitiveTypes" /> schema.
/// </summary>
public class RecordSchemaPrimitiveTypesController : RestApiController<Guid, RecordSchemaPrimitiveTypes>
{
    /// <summary>
    /// Creates a new instance of <see cref="RecordSchemaPrimitiveTypesController" />
    /// </summary>
    public RecordSchemaPrimitiveTypesController(IDataStoreService<Guid, RecordSchemaPrimitiveTypes> dataStoreService) : base(dataStoreService)
    {
    }
}
