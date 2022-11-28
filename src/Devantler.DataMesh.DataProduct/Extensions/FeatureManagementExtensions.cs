namespace Devantler.DataMesh.DataProduct.Extensions;

public static class FeatureManagementExtensions
{
    public static bool IsFeatureEnabled(this IConfiguration configuration, string featureFlag) =>
        configuration.GetValue<bool>($"Features:FeatureFlags:{featureFlag}");

    public static string GetDynamicFeatureValue(this IConfiguration configuration, string featureFlag) =>
        configuration.GetValue<string>($"Features:DynamicFeatures:{featureFlag}") ?? string.Empty;
}
