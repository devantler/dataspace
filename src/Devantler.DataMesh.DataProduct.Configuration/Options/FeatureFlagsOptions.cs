namespace Devantler.DataMesh.DataProduct.Configuration.Options;

/// <summary>
/// Options to configure the features in the date product.
/// </summary>
public class FeatureFlagsOptions
{
    /// <summary>
    /// A key to indicate the section in the configuration file that contains the features options.
    /// </summary>
    public const string Key = "DataProduct:FeatureFlags";

    /// <summary>
    /// A list of APIs that should be enabled for the data product.
    /// </summary>
    public List<ApiFeatureFlagValues> EnableApis { get; set; } = new();

    /// <summary>
    /// A flag to indicate if data ingestion should be enabled for the data product.
    /// </summary>
    public bool EnableDataIngestion { get; set; }

    /// <summary>
    /// A flag to indicate if data publication should be enabled for the data product.
    /// </summary>
    public bool EnableDataPublication { get; set; }

    /// <summary>
    /// A flag to indicate if metadata publication should be enabled for the data product.
    /// </summary>
    public bool EnableMetadataPublication { get; set; }

    /// <summary>
    /// A flag to indicate if tracing should be enabled for the data product.
    /// </summary>
    public bool EnableTracing { get; set; }

    /// <summary>
    /// A flag to indicate if metrics should be enabled for the data product.
    /// </summary>
    public bool EnableMetrics { get; set; }

    /// <summary>
    /// A flag to indicate if caching should be enabled for the data product.
    /// </summary>
    public bool EnableCaching { get; set; }

    /// <summary>
    /// A flag to indicate if authentication should be enabled for the data product.
    /// </summary>
    public bool EnableAuthentication { get; set; }

    /// <summary>
    /// A flag to indicate if authorization should be enabled for the data product.
    /// </summary>
    public bool EnableAuthorization { get; set; }
}
