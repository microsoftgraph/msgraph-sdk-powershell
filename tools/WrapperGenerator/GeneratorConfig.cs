namespace WrapperGenerator;

/// <param name="ClientNamespaceName">The namespace of the typed Kiota client.</param>
/// <param name="OutputPath">The directory receiving generated cmdlet sources.</param>
/// <param name="UseCollisionData">Whether to use generated oracle naming and suppression data.</param>
public sealed record GeneratorConfig(
    string ClientNamespaceName,
    string OutputPath,
    bool UseCollisionData = true);
