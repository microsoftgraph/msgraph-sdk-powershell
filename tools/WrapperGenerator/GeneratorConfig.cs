using System;
using System.Collections.Generic;
using System.Text.Json;

namespace WrapperGenerator;

// Configuration for a generation run: the client namespace the module is generated with, the
// output folder for the .g.cs files, the API version the derived collision-resolution data is
// keyed by, whether that data is applied at all, and the explicit configured module identity.
// Module identity is independent of a client namespace and is never inferred from it.
public sealed record GeneratorConfig(
    string ClientNamespaceName,
    string OutputPath,
    string ApiVersion = "v1.0",
    bool UseCollisionData = true,
    string? Module = null)
{
    private static readonly Lazy<HashSet<string>> ConfiguredModules = new(() =>
    {
        using var stream = typeof(GeneratorConfig).Assembly.GetManifestResourceStream("WrapperGenerator.ModulesMapping.jsonc")
            ?? throw new InvalidOperationException("The configured module roster is missing.");
        using var document = JsonDocument.Parse(stream, new JsonDocumentOptions
        {
            CommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true,
        });
        var modules = new HashSet<string>(StringComparer.Ordinal);
        foreach (var module in document.RootElement.EnumerateObject())
            modules.Add(module.Name);
        return modules;
    });

    internal static void ValidateModule(string? module)
    {
        if (module is not null && !ConfiguredModules.Value.Contains(module))
            throw new ArgumentException($"Unknown or noncanonical module '{module}'. Use an exact config/ModulesMapping.jsonc key.", nameof(module));
    }
}
