using System.Collections.Immutable;
using Chr.Avro.Abstract;
using Devantler.Commons.CodeGen.Core.Model;
using Devantler.Commons.CodeGen.CSharp;
using Devantler.Commons.CodeGen.CSharp.Model;
using Devantler.Commons.CodeGen.Mapping.Avro.Extensions;
using Devantler.Commons.StringHelpers;
using Devantler.DataMesh.DataProduct.Configuration.Options;
using Devantler.DataMesh.DataProduct.Configuration.Options.DataStoreOptions;
using Devantler.DataMesh.DataProduct.Configuration.Options.DataStoreOptions.Relational;
using Devantler.DataMesh.DataProduct.Generator.Models;
using Devantler.DataMesh.SchemaRegistry;
using Microsoft.CodeAnalysis;

namespace Devantler.DataMesh.DataProduct.Generator.IncrementalGenerators;

/// <summary>
/// A generator that generates a Sqlite database context.
/// </summary>
[Generator]
public class DbContextGenerator : GeneratorBase
{
    /// <summary>
    /// A method to generate a Sqlite database context.
    /// </summary>
    /// <param name="compilation"></param>
    /// <param name="additionalFiles"></param>
    /// <param name="options"></param>
    public override Dictionary<string, string> Generate(
        Compilation compilation,
        ImmutableArray<AdditionalFile> additionalFiles,
        DataProductOptions options
    )
    {
        if (options.DataStoreOptions.Type != DataStoreType.Relational)
            return new Dictionary<string, string>();

        var dataStoreOptions = options.DataStoreOptions as RelationalDataStoreOptionsBase;

        var schemaRegistryService = options.GetSchemaRegistryService();
        var rootSchema = schemaRegistryService.GetSchema(options.Schema.Subject, options.Schema.Version);

        var codeCompilation = new CSharpCompilation();

        var @class = new CSharpClass($"{dataStoreOptions?.Provider}DbContext")
            .AddImport(new CSharpUsing("Microsoft.EntityFrameworkCore"))
            .AddImport(new CSharpUsing(NamespaceResolver.ResolveForType(compilation.GlobalNamespace, "IEntity")))
            .SetNamespace(NamespaceResolver.ResolveForType(compilation.GlobalNamespace, "DataStoreStartupExtensions"))
            .SetDocBlock(new CSharpDocBlock($"A {dataStoreOptions?.Provider} database context."))
            .SetBaseClass(new CSharpClass("DbContext"));

        var constructor = new CSharpConstructor(@class.Name)
            .SetDocBlock(new CSharpDocBlock($"A constructor to construct a {dataStoreOptions?.Provider} database context."))
            .AddParameter(new CSharpConstructorParameter($"DbContextOptions<{@class.Name}>", "options")
                .SetIsBaseParameter(true));

        var onModelCreatingMethod = new CSharpMethod("OnModelCreating")
            .SetDocBlock(new CSharpDocBlock("A method to configure the model."))
            .AddParameter(new CSharpParameter("ModelBuilder", "modelBuilder"))
            .SetVisibility(Visibility.Protected)
            .SetIsOverride(true);

        foreach (var schema in rootSchema.Flatten())
        {
            if (schema is not RecordSchema recordSchema)
                continue;

            string schemaName = recordSchema.Name.ToPascalCase();
            _ = @class.AddProperty(new CSharpProperty($"DbSet<{schemaName}Entity>", schemaName.ToPlural())
                .SetDocBlock(new CSharpDocBlock($"A property to access the {schemaName.ToKebabCase()} table."))
                .SetValue($"Set<{schemaName}Entity>()")
                .SetIsExpressionBodiedMember(true)
            );
            _ = onModelCreatingMethod.AddStatement(
                $"_ = modelBuilder.Entity<{schemaName}Entity>().ToTable(\"{schemaName}\");");
        }

        _ = @class.AddConstructor(constructor);
        _ = @class.AddMethod(onModelCreatingMethod);

        _ = codeCompilation.AddType(@class);

        var codeGenerator = new CSharpCodeGenerator();
        return codeGenerator.Generate(codeCompilation);
    }
}