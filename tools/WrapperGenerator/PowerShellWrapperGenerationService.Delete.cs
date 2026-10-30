using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed partial class PowerShellWrapperGenerationService
{
    // OpenAPI operation parameters override inherited parameters by (name, location).
    private static IReadOnlyList<IOpenApiParameter> EffectiveDeleteParameters(
        IOpenApiPathItem pathItem, OpenApiOperation operation, string path)
    {
        var effective = new Dictionary<(string?, ParameterLocation?), IOpenApiParameter>();
        foreach (var level in new[] { pathItem.Parameters, operation.Parameters })
        {
            var seen = new HashSet<(string?, ParameterLocation?)>();
            foreach (var parameter in level ?? [])
            {
                var key = (parameter.Name, parameter.In);
                if (!seen.Add(key))
                    throw new InvalidOperationException($"Duplicate DELETE parameter '{parameter.Name}': {path}.");
                effective[key] = parameter;
            }
        }
        return effective.Values.ToArray();
    }

    private static IReadOnlyList<CmdletProperty> RequiredDeleteQueries(
        IReadOnlyList<IOpenApiParameter> parameters, OpenApiOperation operation, CmdletNaming naming)
    {
        var queries = parameters.Where(p => p.In == ParameterLocation.Query).ToArray();
        var required = queries.Where(p => p.Required).ToArray();
        if (required.Length == 0)
            return [];
        if (operation.RequestBody is not null)
            throw new InvalidOperationException($"Required DELETE queries require a bodyless operation: {naming.SourcePath}.");

        var taken = naming.PathParamNames.Concat(naming.HeaderParams.Select(h => h.PsName))
            .Append(naming.ClassName).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var result = new List<CmdletProperty>();
        foreach (var query in required)
        {
            var schema = query.Schema;
            // Only verified scalar string symbols/serialization are supported here. Other required
            // contracts must stop generation, not yield a command that silently drops its input.
            if (query.Name is null
                || !Regex.IsMatch(query.Name, "^@?[A-Za-z][A-Za-z0-9]*$", RegexOptions.CultureInvariant)
                || schema?.Type != JsonSchemaType.String || !string.IsNullOrEmpty(schema.Format)
                || !PlainString(schema) || schema.AllOf?.Count > 0
                || query.Content?.Count > 0 || query.Style is not (null or ParameterStyle.Form)
                || query.AllowReserved)
                throw new InvalidOperationException(
                    $"Unsupported required DELETE query '{query.Name}' (expected a plain form string): {naming.SourcePath}.");

            var member = SchemaProperties.ToKiotaPropertyName(query.Name);
            if (!taken.Add(member) || CmdletEmitter.IsReservedParameterName(member)
                || queries.Count(p => p.Name is not null
                    && SchemaProperties.ToKiotaPropertyName(p.Name).Equals(member, StringComparison.OrdinalIgnoreCase)) != 1)
                throw new InvalidOperationException(
                    $"Conflicting required DELETE query parameter '{query.Name}' / '{member}': {naming.SourcePath}.");
            result.Add(new(query.Name, member, "string", IsArray: false));
        }
        return result;
    }
}
