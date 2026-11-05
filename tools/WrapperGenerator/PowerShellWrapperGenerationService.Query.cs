using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed partial class PowerShellWrapperGenerationService
{
    // OpenAPI operation parameters override inherited parameters by (name, location).
    private static IReadOnlyList<IOpenApiParameter> EffectiveParameters(
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
                    throw new InvalidOperationException($"Duplicate parameter '{parameter.Name}': {path}.");
                effective[key] = parameter;
            }
        }
        return effective.Values.ToArray();
    }

    private static IReadOnlyList<CmdletProperty> RequiredQueries(
        IReadOnlyList<IOpenApiParameter> parameters, string method, string path)
    {
        var queries = parameters.Where(p => p.In == ParameterLocation.Query).ToArray();
        var required = queries.Where(p => p.Required).ToArray();
        if (required.Length == 0)
            return [];
        var publicNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var result = new List<CmdletProperty>();
        foreach (var query in required)
        {
            var schema = query.Schema;
            if (query.Name is null
                || !Regex.IsMatch(query.Name, "^[@$]?[A-Za-z][A-Za-z0-9]*(?:[-._][A-Za-z0-9]+)*$", RegexOptions.CultureInvariant)
                || schema is null || !SchemaProperties.TryMapQueryInputType(schema, out var type, out var isArray)
                || query.Content?.Count > 0 || query.Style is not (null or ParameterStyle.Form)
                || query.AllowReserved)
                throw new InvalidOperationException(
                    $"Unsupported required query '{query.Name}' (expected a supported scalar or scalar array with form serialization): {method} {path}.");

            var member = QueryMemberName(query.Name);
            var publicName = "Query" + query.Name.TrimStart('@', '$').ToPascalCase('-', '.', '_');
            if (!publicNames.Add(publicName)
                || queries.Count(p => p.Name is not null
                    && QueryMemberName(p.Name).Equals(member, StringComparison.OrdinalIgnoreCase)) != 1)
                throw new InvalidOperationException(
                    $"Conflicting required query parameter '{query.Name}' / '{publicName}' / Kiota member '{member}': {method} {path}.");
            result.Add(new(query.Name, member, type, isArray) { ParameterName = publicName });
        }
        return result;
    }

    private static string QueryMemberName(string rawName) => rawName.TrimStart('@', '$').ToPascalCase('-', '.', '_');

    private static IReadOnlyList<string> OptionalQueryNames(IReadOnlyList<IOpenApiParameter> parameters) =>
        parameters.Where(p => p.In == ParameterLocation.Query && !p.Required).Select(p => p.Name!).ToArray();
}
