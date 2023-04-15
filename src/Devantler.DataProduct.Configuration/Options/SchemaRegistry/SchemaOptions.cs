namespace Devantler.DataProduct.Configuration.Options.SchemaRegistry;

/// <summary>
/// Options to configure the schema used in the date product.
/// </summary>
public class SchemaOptions
{
    /// <summary>
    /// The subject of the schema.
    /// </summary>
    public string Subject { get; set; } = string.Empty;

    /// <summary>
    /// The version of the schema.
    /// </summary>
    public int Version { get; set; }
}