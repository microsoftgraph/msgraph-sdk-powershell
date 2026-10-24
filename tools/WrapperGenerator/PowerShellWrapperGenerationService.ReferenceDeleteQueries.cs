using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed partial class PowerShellWrapperGenerationService
{
    private IReadOnlyList<ReferenceDeleteQueryBinding> PrepareReferenceDeleteQueryBindings(IReadOnlyList<MultiRouteGroup> groups)
    {
        var bindings = CmdletConfigurator.GetReferenceDeleteQueryBindings(config).ToArray();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var binding in bindings)
        {
            if (string.IsNullOrWhiteSpace(binding.ApiVersion) || string.IsNullOrEmpty(binding.Path)
                || !binding.Path.StartsWith('/') || !binding.Path.EndsWith("/$ref", StringComparison.OrdinalIgnoreCase)
                || binding.Path.Contains('*') || binding.Path.Contains('?') || binding.Path.Contains('#')
                || binding.Path.Contains("{}", StringComparison.Ordinal)
                || binding.ParameterName != "Id")
                throw new InvalidOperationException($"Invalid exact reference DELETE query binding: {binding.Path}; only the reviewed '@id' to 'Id' mapping is supported.");
            if (!seen.Add(binding.ApiVersion + " " + binding.Path))
                throw new InvalidOperationException($"Duplicate reference DELETE query binding: {binding.ApiVersion} {binding.Path}.");
            if (groups.Any(group => group.ApiVersion.Equals(binding.ApiVersion, StringComparison.OrdinalIgnoreCase)
                && group.Routes.Any(route => MatchesRoute(route, "DELETE", binding.Path))))
                throw new InvalidOperationException($"Reference DELETE query binding overlaps a multi-route member: {binding.Path}.");
        }
        return bindings;
    }

    private string EmitConfiguredReferenceDelete(CmdletNaming naming, EmitContext ctx, OpenApiOperation operation,
        ReferenceDeleteQueryBinding binding, IReadOnlyList<IOpenApiParameter> pathItemParameters)
    {
        if (!naming.SourceMethod.Equals("DELETE", StringComparison.OrdinalIgnoreCase)
            || naming.Kind != OperationKind.Resource
            || !naming.SourcePath.Equals(binding.Path, StringComparison.OrdinalIgnoreCase)
            || !naming.SourcePath.EndsWith("/$ref", StringComparison.OrdinalIgnoreCase)
            || operation.RequestBody is not null
            || (operation.Responses ?? []).Any(response => response.Key.StartsWith('2')
                && response.Value.Content?.Count > 0)
            || pathItemParameters.Any(parameter => parameter.In != ParameterLocation.Path))
            throw new InvalidOperationException($"Unsupported configured reference DELETE operation shape: {naming.SourcePath}.");

        var queries = (operation.Parameters ?? []).Where(parameter => parameter.In == ParameterLocation.Query).ToArray();
        if (binding.ParameterName != "Id" || queries.Length != 1 || queries[0].Name != "@id"
            || !queries[0].Required || !IsPlainStringQuery(queries[0])
            || (operation.Parameters ?? []).Any(parameter =>
                parameter.In is not (ParameterLocation.Path or ParameterLocation.Header or ParameterLocation.Query)))
            throw new InvalidOperationException($"Reference DELETE requires the spec's single required plain string '@id' query mapped to 'Id': {naming.SourcePath}.");

        IReadOnlyList<CmdletEmitter.StringQueryParameter> extraQueries =
            [new("@id", "Id", true) { BuilderPropertyName = "Id" }];
        var parameters = CmdletEmitter.GetDispatchParameters(naming, "Invoke",
            queries.Select(query => query.Name!).ToHashSet(StringComparer.Ordinal), [], extraQueries);
        ValidateReferenceDeleteParameters(naming, parameters);
        return CmdletEmitter.EmitRemove(naming, ctx, extraQueries);
    }

    private static void ValidateReferenceDeleteParameters(CmdletNaming naming,
        IReadOnlyList<CmdletEmitter.DispatchParameter> parameters)
    {
        var names = parameters.Select(parameter => parameter.Name).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var aliases = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var parameter in parameters)
        {
            if (CmdletEmitter.IsReservedDispatchParameterName(parameter.Name)
                || (parameter.Alias is { } alias
                    && (CmdletEmitter.IsReservedDispatchParameterName(alias) || names.Contains(alias) || !aliases.Add(alias))))
                throw new InvalidOperationException($"Reference DELETE parameter or alias conflicts with another parameter or a runtime/common parameter: {naming.SourcePath}.");
        }
    }
}
