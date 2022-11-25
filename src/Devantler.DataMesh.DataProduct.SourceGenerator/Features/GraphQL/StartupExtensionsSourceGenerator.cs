using System;

namespace Devantler.DataMesh.DataProduct.SourceGenerator.Features.GraphQL;

public class StartupExtensionsSourceGenerator
{
    internal string Execute() => string.Join(Environment.NewLine,
        "// <auto-generated />",
        "namespace Devantler.DataMesh.DataProduct.Features.GraphQL;",
        "public static partial class GraphQLStartupExtensions",
        "{",
        "    static partial void AddFromSourceGenerator(IServiceCollection services);",
        "        Console.WriteLine(\"Hello from GraphQLStartupExtensionsSourceGenerator!\");",
        "    }",
        "}"
    );
}
