namespace WrapperGenerator;

// Configuration for a generation run. The generation service reads exactly two values: the
// client namespace the module is generated with, and the output folder for the .g.cs files.
public sealed record GeneratorConfig(string ClientNamespaceName, string OutputPath);
