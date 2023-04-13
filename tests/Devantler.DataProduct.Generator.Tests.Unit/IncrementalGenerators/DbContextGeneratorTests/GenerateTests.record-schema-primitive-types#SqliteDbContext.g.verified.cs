﻿//HintName: SqliteDbContext.g.cs
// <auto-generated>
// This code was generated by: 'Devantler.DataProduct.Generator.IncrementalGenerators.DbContextGenerator'.
// Any changes made to this file will be overwritten.
using Microsoft.EntityFrameworkCore;
using Devantler.DataProduct.Features.DataStore.Entities;
namespace Devantler.DataProduct.Features.DataStore;
/// <summary>
/// A Sqlite database context.
/// </summary>
public class SqliteDbContext : DbContext
{
    /// <summary>
    /// A constructor to construct a Sqlite database context.
    /// </summary>
    public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
    {
    }
    /// <summary>
    /// A property to access the record-schema-primitive-types table.
    /// </summary>
    public DbSet<RecordSchemaPrimitiveTypesEntity> RecordSchemaPrimitiveTypes => Set<RecordSchemaPrimitiveTypesEntity>();
    /// <summary>
    /// A method to configure the schema.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        _ = modelBuilder.Entity<RecordSchemaPrimitiveTypesEntity>().ToTable("RecordSchemaPrimitiveTypes");
    }
}