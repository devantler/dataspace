namespace Devantler.DataMesh.DataProduct.Configuration.Options.DataStoreOptions.Relational;

/// <summary>
/// Options to configure a SQLite data store.
/// </summary>
public class SqliteDataStoreOptions : RelationalDataStoreOptionsBase
{
    /// <inheritdoc/>
    public override RelationalDataStoreProvider Provider { get; set; } = RelationalDataStoreProvider.SQlite;
    /// <inheritdoc/>
    public override string ConnectionString { get; set; } = string.Empty;
}