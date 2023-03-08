namespace Devantler.DataMesh.DataProduct.Features.Apis.GraphQL;

/// <summary>
/// Extensions for registering GraphQL to the DI container and configuring the web application to use it.
/// </summary>
public static class GraphQLStartupExtensions
{
    /// <summary>
    /// Registers GraphQL to the DI container.
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="environment"></param>
    public static WebApplicationBuilder AddGraphQL(this WebApplicationBuilder builder, IWebHostEnvironment environment)
    {
        _ = builder.Services
            .AddGraphQLServer()
            .ModifyRequestOptions(opt => opt.IncludeExceptionDetails = environment.IsDevelopment())
            .AddQueryType<Query>()
            .AddProjections() // TODO: Gate this behind a setting in the options.Services.Apis.GraphQL.EnableProjections
            .AddFiltering() // TODO: Gate this behind a setting in the options.Services.Apis.GraphQL.EnableFiltering
            .AddSorting(); // TODO: Gate this behind a setting in the options.Services.Apis.GraphQL.EnableSorting

        return builder;
    }

    /// <summary>
    /// Configures the web application to use GraphQL.
    /// </summary>
    /// <param name="app"></param>
    public static WebApplication UseGraphQL(this WebApplication app)
    {
        _ = app.MapGraphQL();

        return app;
    }
}
