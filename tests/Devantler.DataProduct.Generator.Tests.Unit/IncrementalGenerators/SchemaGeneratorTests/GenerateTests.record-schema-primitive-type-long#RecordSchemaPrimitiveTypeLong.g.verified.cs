﻿//HintName: RecordSchemaPrimitiveTypeLong.g.cs
// <auto-generated>
// This code was generated by: 'Devantler.DataProduct.Generator.IncrementalGenerators.SchemaGenerator'.
// Any changes made to this file will be overwritten.
namespace Devantler.DataProduct.Features.Schemas;
/// <summary>
/// An schema class for the RecordSchemaPrimitiveTypeLong record.
/// </summary>
public class RecordSchemaPrimitiveTypeLong : ISchema<Guid>
{
    /// <summary>
    /// The unique identifier for this schema.
    /// </summary>
    public Guid Id { get; set; } = default;
    /// <summary>
    /// The LongField property.
    /// </summary>
    public long LongField { get; set; }
}