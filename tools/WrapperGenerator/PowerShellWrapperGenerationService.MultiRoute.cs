using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed partial class PowerShellWrapperGenerationService
{
    private sealed record PreparedRouteGroup(IReadOnlyList<CmdletEmitter.RouteWorker> Workers,
        IReadOnlyList<string> WorkerSources, string DispatcherSource);

    internal async Task ValidateRouteGroupsAsync(CancellationToken cancellationToken)
    {
        var groups = PrepareRouteGroups(new EmitContext(config.ClientNamespaceName), cancellationToken, recordDiagnostics: false);
        await ValidateRouteOutputNamesAsync(groups, cancellationToken).ConfigureAwait(false);
    }

    private async Task ValidateRouteOutputNamesAsync(IReadOnlyList<PreparedRouteGroup> groups, CancellationToken cancellationToken)
    {
        if (groups.Count == 0)
            return;

        var reserved = new Dictionary<string, CmdletNaming>(StringComparer.OrdinalIgnoreCase);
        foreach (var group in groups)
        foreach (var naming in group.Workers.Select(w => w.InternalNaming).Append(group.Workers[0].Naming))
        {
            var fileName = CmdletFileName(naming);
            if (!reserved.TryAdd(fileName, naming))
                throw new InvalidOperationException($"Operation variant output filename '{fileName}' is shared by multiple grouped commands.");
        }

        Task<int> CheckOrdinaryOutput(CmdletNaming naming, string source, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            var fileName = CmdletFileName(naming);
            if (reserved.TryGetValue(fileName, out var grouped))
                throw new InvalidOperationException(
                    $"Operation variant output filename '{fileName}' conflicts with ordinary {naming.SourceMethod} {naming.SourcePath} " +
                    $"and grouped {grouped.SourceMethod} {grouped.SourcePath}. Review complete variant group membership or cmdlet naming.");
            return Task.FromResult(0);
        }

        // Reuse actual eligibility, pairing and worker naming without writes or duplicated diagnostics.
        var probe = new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, apiVersion, configurationEntries);
        await probe.EmitOrdinaryOperationsAsync(new EmitContext(config.ClientNamespaceName), groups,
            CheckOrdinaryOutput, cancellationToken).ConfigureAwait(false);
    }

    // Validate every opted-in group and build its sources before touching the output directory.
    private List<PreparedRouteGroup> PrepareRouteGroups(EmitContext ctx, CancellationToken cancellationToken, bool recordDiagnostics = true)
    {
        var plans = new List<PreparedRouteGroup>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var group in CmdletConfigurator.GetOperationVariantGroups(configurationEntries))
        {
            if (group.Routes.Count < 2 || group.Routes.Count > 32
                || !group.Routes.Any(r => r.FamilyName == group.DefaultFamily)
                || group.Routes.Select(r => r.FamilyName).Distinct(StringComparer.OrdinalIgnoreCase).Count() < 2)
                throw new InvalidOperationException("Operation groups require 2 to 32 exact routes, at least two families and an explicit root default.");
            var method = new HttpMethod(group.Routes[0].Method.ToUpperInvariant());
            if (method != HttpMethod.Get && method != HttpMethod.Post && method != HttpMethod.Patch
                && method != HttpMethod.Put && method != HttpMethod.Delete)
                throw new InvalidOperationException($"Unsupported operation group method: {method}.");
            var labels = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var route in group.Routes)
            {
                if (!route.Method.Equals(method.Method, StringComparison.OrdinalIgnoreCase)
                    || !Regex.IsMatch(route.FamilyName, "^[A-Za-z][A-Za-z0-9]*$", RegexOptions.CultureInvariant)
                    || !route.Path.StartsWith('/') || route.Path.IndexOfAny(['*', '?', '#']) >= 0
                    || route.Path.Contains("{}", StringComparison.Ordinal))
                    throw new InvalidOperationException($"Invalid exact or mixed-method operation group member: {route.Method} {route.Path} ({route.FamilyName}).");
                if (labels.TryGetValue(route.FamilyName, out var label) && label != route.FamilyName)
                    throw new InvalidOperationException("Operation family labels must not differ only by case.");
                labels[route.FamilyName] = route.FamilyName;
                if (!seen.Add(route.Method + " " + route.Path))
                    throw new InvalidOperationException($"Duplicate operation group membership: {route.Method} {route.Path}.");
            }
            var paths = group.Routes.Select(r => document.Paths.SingleOrDefault(p =>
                p.Key.Equals(r.Path, StringComparison.OrdinalIgnoreCase))).ToArray();
            var present = paths.Select(p => p.Value?.Operations?.ContainsKey(method) == true).ToArray();
            if (paths.All(p => p.Value is null))
                continue; // Module configuration is globally aggregated; unrelated modules have no members.
            if (present.Any(p => !p))
                throw new InvalidOperationException("Operation group is incomplete or filtered: "
                    + string.Join(", ", group.Routes.Where((_, i) => !present[i]).Select(r => r.Path)));

            var workers = new List<CmdletEmitter.RouteWorker>();
            var sources = new List<string>();
            var operations = new List<OpenApiOperation>();
            for (var i = 0; i < group.Routes.Count; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var path = paths[i].Key;
                var pathItem = paths[i].Value!;
                var operation = pathItem.Operations![method];
                if (CmdletConfigurator.IsSuppressed(method, path, config, apiVersion))
                    throw new InvalidOperationException($"Operation group member is suppressed: {method} {path}.");
                if (method != HttpMethod.Get)
                {
                    var (worker, mutationSource) = PrepareMutationRoute(method, path, pathItem, operation,
                        group.Routes[i].FamilyName, i, ctx, recordDiagnostics);
                    workers.Add(worker);
                    sources.Add(mutationSource);
                    operations.Add(operation);
                    continue;
                }
                if (ClassifyOperationKind(operation, HttpMethod.Get) != OperationKind.Resource
                    || (operation.Extensions?.TryGetValue("x-ms-docs-operation-type", out var kind) == true
                        && kind is JsonNodeExtension node && node.Node?.ToString()?.Trim('"') != "operation")
                    || HasCallSegment(path) || HasUnsupportedODataSegment(path)
                    || (EndsWithEmittableODataSegment(path) && !EndsWithSegment(path, "$count"))
                    || operation.RequestBody is not null || HasBinarySuccessContent(operation)
                    || (pathItem.Parameters ?? []).Any(p => p.In != ParameterLocation.Path)
                    || (operation.Parameters ?? []).Any(p => p.In is not (ParameterLocation.Path or ParameterLocation.Query or ParameterLocation.Header)))
                    throw new InvalidOperationException($"Unsupported resource GET group member: {path}.");

                var pathIds = Regex.Matches(path, @"\{([^}]+)\}").Select(m => m.Groups[1].Value).ToHashSet(StringComparer.Ordinal);
                if ((operation.Parameters ?? []).Concat(pathItem.Parameters ?? []).Where(p => p.In == ParameterLocation.Path)
                    .Any(p => p.Name is null || !pathIds.Contains(p.Name) || !p.Required || !PlainString(p.Schema)))
                    throw new InvalidOperationException($"Unsupported GET group path-ID declaration: {path}.");
                var headers = (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Header).ToArray();
                if (headers.Any(p => p.Required || !PlainString(p.Schema)))
                    throw new InvalidOperationException($"Unsupported GET group header contract: {path}.");
                var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, path,
                    headers.Select(p => p.Name!).ToArray()), config, apiVersion);
                if (naming.CompositeKeyBuilderNamespace.Length != 0
                    || naming.PathParamNames.Distinct(StringComparer.OrdinalIgnoreCase).Count() != naming.PathParamNames.Count)
                    throw new InvalidOperationException($"GET groups require ordinary distinct path IDs: {path}.");
                var internalNaming = Naming.WithSuffix(naming, $"_Route{i}");
                string shape, outputType, source;
                if (EndsWithSegment(path, "$count"))
                {
                    var response = operation.Responses?.FirstOrDefault(r => r.Key is "2XX" or "200").Value;
                    if (response?.Content?.Count != 1 || !response.Content.TryGetValue("text/plain", out var media)
                        || media.Schema?.Type != JsonSchemaType.Integer || media.Schema.Format is not (null or "int32"))
                        throw new InvalidOperationException($"Unsupported scalar GET group response: {path}.");
                    shape = "Scalar";
                    outputType = "int";
                    source = "";
                }
                else
                {
                    if ((operation.Responses ?? []).Where(r => r.Key.StartsWith('2')).Any(r =>
                        r.Value.Content?.Keys.Any(contentType => !contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase)
                            && !contentType.EndsWith("+json", StringComparison.OrdinalIgnoreCase)) == true))
                        throw new InvalidOperationException($"Unsupported non-JSON entity GET group response: {path}.");
                    var response = TryGetSuccessJsonSchema(operation);
                    if (response is not null && (operation.Responses ?? []).Where(r => r.Key.StartsWith('2'))
                        .SelectMany(r => (r.Value.Content ?? new Dictionary<string, IOpenApiMediaType>()).Values)
                        .Any(media => media.Schema is null
                            || SchemaSignature(media.Schema) != SchemaSignature(response)))
                        throw new InvalidOperationException($"Incompatible success response schemas in GET group member: {path}.");
                    if (response is null)
                        throw new InvalidOperationException($"Missing GET group response schema: {path}.");
                    if (!HasRootUnion(response) && FindProperty(response, "value") is { } value)
                    {
                        if (response.GetReferenceId() is null || value.Type != JsonSchemaType.Array
                            || value.Items is null
                            || !TryResolveListEntityTypeName(value, ctx.ModelsNamespace, out outputType)
                            || !PlainString(FindProperty(response, "@odata.nextLink")))
                            throw new InvalidOperationException($"Unsupported typed collection GET group response: {path}.");
                        shape = "List";
                        source = ResolveCollectionResponseType(response, ctx.ModelsNamespace, outputType);
                    }
                    else
                    {
                        if (!TryResolveResponseTypeName(response, ctx.ModelsNamespace, out outputType))
                            throw new InvalidOperationException($"Unsupported entity GET group response: {path}.");
                        shape = "Get";
                        source = "";
                    }
                }
                var queries = (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Query).ToArray();
                ValidateGetQueries(queries, shape, path);
                var queryNames = queries.Select(p => p.Name!).ToHashSet(StringComparer.Ordinal);
                source = shape switch
                {
                    "List" => CmdletEmitter.EmitListGet(internalNaming, ctx, outputType, source, queryNames),
                    "Get" => CmdletEmitter.EmitItemGet(internalNaming, ctx, outputType, queryNames),
                    _ => CmdletEmitter.EmitScalarGet(internalNaming, ctx, "int", queryNames),
                };
                workers.Add(new(naming, internalNaming, group.Routes[i].FamilyName, shape,
                    CmdletEmitter.GetDispatchParameters(naming, shape, queryNames), outputType));
                sources.Add(source);
                operations.Add(operation);
            }
            foreach (var shape in workers.Select((w, i) => (Worker: w, Operation: operations[i])).GroupBy(w => w.Worker.Shape))
            {
                var first = shape.First().Operation;
                if (shape.Skip(1).Any(w => ParameterSignature(first) != ParameterSignature(w.Operation)
                    || ResponseSignature(first) != ResponseSignature(w.Operation)
                    || BodySignature(first) != BodySignature(w.Operation)))
                    throw new InvalidOperationException("Operation variants have incompatible body, response, query or header contracts.");
            }
            var dispatcher = CmdletEmitter.EmitMultiRouteDispatcher(group, workers, ctx);
            plans.Add(new(workers, sources, dispatcher));
        }
        if (plans.GroupBy(p => p.Workers[0].Naming.ClassName, StringComparer.OrdinalIgnoreCase).Any(g => g.Count() > 1))
            throw new InvalidOperationException("Operation groups resolve to the same public command; review complete group membership.");
        return plans;
    }

    private static bool PlainString(IOpenApiSchema? schema) =>
        schema?.Type is { } type && (type & ~JsonSchemaType.Null) == JsonSchemaType.String
        && schema.GetReferenceId() is null && !(schema.Enum?.Count > 0 || schema.AnyOf?.Count > 0 || schema.OneOf?.Count > 0);

    private static void ValidateGetQueries(IReadOnlyList<IOpenApiParameter> queries, string shape, string path)
    {
        if (queries.Select(p => p.Name).Distinct(StringComparer.OrdinalIgnoreCase).Count() != queries.Count)
            throw new InvalidOperationException($"Duplicate GET group query parameters: {path}.");
        foreach (var query in queries)
        {
            var allowed = shape == "List" || (shape == "Get"
                ? query.Name is "$select" or "$expand" : query.Name is "$filter" or "$search");
            var schema = query.Schema;
            var supported = query.Name switch
            {
                "$top" or "$skip" => schema?.Type == JsonSchemaType.Integer && schema.Format is null or "int32",
                "$count" => schema?.Type == JsonSchemaType.Boolean,
                "$select" or "$expand" or "$orderby" => schema?.Type == JsonSchemaType.Array && PlainString(schema.Items),
                "$filter" or "$search" => PlainString(schema),
                _ => false,
            };
            if (query.Required || !allowed || !supported || schema?.AnyOf?.Count > 0
                || schema?.OneOf?.Count > 0 || schema?.AllOf?.Count > 0 || schema?.GetReferenceId() is not null)
                throw new InvalidOperationException($"Unsupported GET group query '{query.Name}': {path}.");
        }
    }

    private static string ParameterSignature(OpenApiOperation operation) =>
        string.Join("|", (operation.Parameters ?? []).Where(p => p.In != ParameterLocation.Path)
            .OrderBy(p => p.In).ThenBy(p => p.Name, StringComparer.Ordinal)
            .Select(p => $"{p.In}:{p.Name}:{p.Required}:{SchemaSignature(p.Schema)}"));

    private static string ResponseSignature(OpenApiOperation operation) =>
        string.Join("|", (operation.Responses ?? []).Where(r => r.Key.StartsWith('2')).OrderBy(r => r.Key)
            .Select(r => r.Key + ":" + string.Join(",", (r.Value.Content ?? new Dictionary<string, IOpenApiMediaType>())
                .OrderBy(c => c.Key).Select(c => c.Key + ":" + SchemaSignature(c.Value.Schema)))));

    private static string SchemaSignature(IOpenApiSchema? schema) => schema is null ? "none"
        : schema.GetReferenceId() is { } reference ? "$ref:" + reference
        : $"{schema.Type}:{schema.Format}:" + string.Join(",", (schema.Enum ?? []).Select(e => e.ToJsonString()))
            + (schema.Items is null ? "" : "[" + SchemaSignature(schema.Items) + "]");
}
