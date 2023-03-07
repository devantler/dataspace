namespace Devantler.DataMesh.DataProduct.Configuration.Options.Services.DataStore.DocumentBased;

/// <summary>
/// The document based data store provider to use.
/// </summary>
public class DocumentBasedDataStoreProvider : IProvider
{
    /// <summary>
    /// The MongoDb data store provider. Not supported yet.
    /// </summary>
    public const string MongoDb = "MongoDb";

    /// <summary>
    /// The LiteDb data store provider. Not supported yet.
    /// </summary>
    public const string LiteDb = "LiteDb";

    /// <summary>
    /// The UnQLite data store provider. Not supported yet.
    /// </summary>
    public const string UnQLite = "UnQLite";

    /// <summary>
    /// The RavenDb data store provider. Not supported yet.
    /// </summary>
    public const string RavenDb = "RavenDb";

    /// <summary>
    /// The CouchDb data store provider. Not supported yet.
    /// </summary>
    public const string CouchDb = "CouchDb";
}
