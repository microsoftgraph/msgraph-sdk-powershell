namespace WrapperGenerator;

// Generator-wide naming constants. The noun prefix is expected to become user-configurable
// (per PR review); until then every consumer reads it from here so that change lands in one
// place instead of a scattered find/replace.
internal static class GeneratorConstants
{
    public const string NounPrefix = "Mg";
}
