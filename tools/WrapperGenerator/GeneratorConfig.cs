using System.Collections.Generic;

namespace WrapperGenerator;

// Exact reviewed variants of one public command, selected by existing mandatory path IDs.
// These annotations do not introduce a Route parameter or an endpoint selector.
public sealed record OperationVariant(string Method, string Path, string Name);

public sealed record OperationVariantGroup(
    string ApiVersion,
    IReadOnlyList<OperationVariant> Routes,
    string DefaultRoute);

public sealed record GeneratorConfig(
    string ClientNamespaceName,
    string OutputPath,
    string ApiVersion = "v1.0",
    bool UseCollisionData = true,
    IReadOnlyList<OperationVariantGroup>? OperationVariantGroups = null);
