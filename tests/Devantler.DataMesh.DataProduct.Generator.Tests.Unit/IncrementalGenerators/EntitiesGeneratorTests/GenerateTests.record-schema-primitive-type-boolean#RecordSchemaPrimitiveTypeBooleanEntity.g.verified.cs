﻿//HintName: RecordSchemaPrimitiveTypeBooleanEntity.g.cs
// <auto-generated>
// This code was generated by: 'Devantler.DataMesh.DataProduct.Generator.IncrementalGenerators.EntitiesGenerator'.
// Any changes made to this file will be overwritten.
using Devantler.DataMesh.DataProduct.Features.Schemas;
namespace Devantler.DataMesh.DataProduct.Features.DataStore.Entities;
/// <summary>
/// An entity class for the RecordSchemaPrimitiveTypeBoolean record.
/// </summary>
public class RecordSchemaPrimitiveTypeBooleanEntity : IEntity<Guid>
{
    /// <summary>
    /// The unique identifier for this entity.
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// The BooleanField property.
    /// </summary>
    public bool BooleanField { get; set; }
}
