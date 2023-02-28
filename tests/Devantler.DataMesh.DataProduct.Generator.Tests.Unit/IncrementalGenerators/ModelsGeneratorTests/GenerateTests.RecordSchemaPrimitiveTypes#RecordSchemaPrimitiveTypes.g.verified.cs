﻿//HintName: RecordSchemaPrimitiveTypes.g.cs
// <auto-generated>
// This code was generated by: 'Devantler.DataMesh.DataProduct.Generator.IncrementalGenerators.ModelsGenerator'.
// Any changes made to this file will be overwritten.
namespace Devantler.DataMesh.DataProduct.Models;
public class RecordSchemaPrimitiveTypes : IModel
{
    /// <summary>
    /// The unique identifier for the record.
    /// </summary>
    public Guid Id { get; set; }
    public bool BooleanField { get; set; }
    public byte[] BytesField { get; set; }
    public double DoubleField { get; set; }
    public float FloatField { get; set; }
    public int IntField { get; set; }
    public long LongField { get; set; }
    #nullable enable
    public object? NullField { get; set; }
    #nullable disable
    public string StringField { get; set; }
}