using System;
using System.Linq;
using Microsoft.OpenApi;

namespace WrapperGenerator;

// Small string and OpenAPI-schema helpers used across the generator.
internal static class GeneratorExtensions
{
    public static string ToFirstCharacterLowerCase(this string? input)
        => string.IsNullOrEmpty(input) ? string.Empty : char.ToLowerInvariant(input[0]) + input[1..];

    public static string ToFirstCharacterUpperCase(this string? input)
        => string.IsNullOrEmpty(input) ? string.Empty : char.ToUpperInvariant(input[0]) + input[1..];

    private static readonly char[] defaultSeparators = ['-'];

    public static string ToPascalCase(this string? input, params char[] separators) => ToInternalCamelCase(input, separators, true);

    private static string ToInternalCamelCase(string? input, char[] separators, bool firstCharacterUpperCase = false, bool normalizeFirstCharacter = true)
    {
        if (string.IsNullOrEmpty(input)) return string.Empty;
        if (separators is null || separators.Length == 0) separators = defaultSeparators;
        var chunks = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        if (chunks.Length == 0) return string.Empty;
        return ((normalizeFirstCharacter, firstCharacterUpperCase) switch
        {
            (false, _) => chunks[0],
            (true, true) => chunks[0].ToFirstCharacterUpperCase(),
            (true, false) => chunks[0].ToFirstCharacterLowerCase()
        }) +
                string.Join(string.Empty, chunks.Skip(1).Select(ToFirstCharacterUpperCase));
    }

    // Resolves the schema name for a $ref: a referenced schema is an OpenApiSchemaReference and
    // carries the id. (Kiota's own reader can also recover an id from an allOf-merged schema via a
    // marker its refiner stamps on, but this generator does not run that refiner, so no such marker
    // is ever present and there is nothing more to resolve.)
    internal static string? GetReferenceId(this IOpenApiSchema schema) =>
        schema is OpenApiSchemaReference reference ? reference.Reference?.Id : null;
}
