namespace WrapperGenerator;

// Configuration for a generation run: the client namespace the module is generated with, the
// output folder for the .g.cs files, the API version the derived collision-resolution data is
// keyed by, and whether that data is applied at all (derivation runs disable it to reproduce
// the raw collision inventory the data is derived FROM).
public sealed record GeneratorConfig(
    string ClientNamespaceName,
    string OutputPath,
    string ApiVersion = "v1.0",
    bool UseCollisionData = true);
