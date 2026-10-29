using System.Collections.Generic;

namespace WrapperGenerator;

// Exact reviewed variants of one public command, selected by existing mandatory path IDs.
// These annotations do not introduce a Route parameter or an endpoint selector.
/// <param name="Method">The HTTP method shared by the group's operations.</param>
/// <param name="Path">The exact OpenAPI path, including named placeholders.</param>
/// <param name="FamilyName">A maintainer-chosen label used with the shape to name parameter sets.</param>
public sealed record OperationVariant(string Method, string Path, string FamilyName);

/// <param name="Routes">The complete reviewed operations sharing one public cmdlet.</param>
/// <param name="DefaultFamily">The family whose minimal mandatory-ID set supplies the default.</param>
public sealed record OperationVariantGroup(
    IReadOnlyList<OperationVariant> Routes,
    string DefaultFamily);

/// <param name="ClientNamespaceName">The namespace of the typed Kiota client.</param>
/// <param name="OutputPath">The directory receiving generated cmdlet sources.</param>
/// <param name="UseCollisionData">Whether to use generated oracle naming and suppression data.</param>
/// <param name="OperationVariantGroups">Shared variant definitions, independent of the ingesting API profile.</param>
public sealed record GeneratorConfig(
    string ClientNamespaceName,
    string OutputPath,
    bool UseCollisionData = true,
    IReadOnlyList<OperationVariantGroup>? OperationVariantGroups = null);
