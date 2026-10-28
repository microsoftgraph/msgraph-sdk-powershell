using System.Collections.Generic;

namespace WrapperGenerator;

// Exact reviewed GET routes whose existing mandatory IDs select the request.
public sealed record MultiRoute(string Method, string Path, string Name);

public sealed record MultiRouteGroup(
    string ApiVersion,
    IReadOnlyList<MultiRoute> Routes,
    string DefaultRoute);

public sealed record GeneratorConfig(
    string ClientNamespaceName,
    string OutputPath,
    string ApiVersion = "v1.0",
    bool UseCollisionData = true,
    IReadOnlyList<MultiRouteGroup>? MultiRouteGroups = null);
