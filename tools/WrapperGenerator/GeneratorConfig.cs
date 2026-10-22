using System.Collections.Generic;

namespace WrapperGenerator;

// Every member is an exact reviewed method/path, not a prefix or a collision heuristic.
public sealed record MultiRouteQueryBinding(string QueryName, string ParameterName);

public sealed record MultiRoute(string Method, string Path, string Name)
{
    public IReadOnlyList<MultiRouteQueryBinding> QueryBindings { get; init; } = [];
}

public sealed record MultiRouteGroup(
    string ApiVersion,
    IReadOnlyList<MultiRoute> Routes,
    string DefaultRoute,
    string? SelectorParameter = null)
{
    public bool AllowZeroArgumentFunctions { get; init; }
    public bool AllowAsymmetricRoutes { get; init; }
    public bool AllowResponseUnion { get; init; }
    public bool AllowRouteSpecificBodies { get; init; }
    public bool AllowReferenceDelete { get; init; }
    public bool AllowMediaRoutes { get; init; }
    public bool AllowExplicitRouteSelection { get; init; }
    public bool IncludeDerivedSuppressedRoutes { get; init; }
    public bool AllowPublishedParameterInference { get; init; }
    public bool AllowMixedReadOperations { get; init; }
}

public sealed record ReferenceDeleteQueryBinding(string ApiVersion, string Path, string ParameterName);

// Configuration for a generation run: the client namespace the module is generated with, the
// output folder for the .g.cs files, the API version the derived collision-resolution data is
// keyed by, and whether that data is applied at all (derivation runs disable it to reproduce
// the raw collision inventory the data is derived FROM).
public sealed record GeneratorConfig(
    string ClientNamespaceName,
    string OutputPath,
    string ApiVersion = "v1.0",
    bool UseCollisionData = true,
    IReadOnlyList<MultiRouteGroup>? MultiRouteGroups = null)
{
    public IReadOnlyList<ReferenceDeleteQueryBinding> ReferenceDeleteQueryBindings { get; init; } = [];
}
