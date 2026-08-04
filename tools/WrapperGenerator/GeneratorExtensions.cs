using System;
using System.Linq;
using Microsoft.OpenApi;

namespace WrapperGenerator;

// Small string and OpenAPI-schema helpers used across the generator.
internal static class GeneratorExtensions
{
    public static string ToFirstCharacterUpperCase(this string? input)
        => string.IsNullOrEmpty(input) ? string.Empty : char.ToUpperInvariant(input[0]) + input[1..];

    private static readonly char[] defaultSeparators = ['-'];

    // Pascal-cases separator-delimited text: "user-id" -> "UserId".
    public static string ToPascalCase(this string? input, params char[] separators)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;
        if (separators is null || separators.Length == 0)
            separators = defaultSeparators;
        return string.Concat(input.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(ToFirstCharacterUpperCase));
    }

    // Resolves the schema name for a $ref: a referenced schema is an OpenApiSchemaReference and
    // carries the id. (Kiota's own reader can also recover an id from an allOf-merged schema via a
    // marker its refiner stamps on, but this generator does not run that refiner, so no such marker
    // is ever present and there is nothing more to resolve.)
    internal static string? GetReferenceId(this IOpenApiSchema schema) =>
        schema is OpenApiSchemaReference reference ? reference.Reference?.Id : null;
}
