using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed partial class PowerShellWrapperGenerationService
{
    private sealed record MultiRouteOperation(CmdletNaming Naming, OpenApiOperation Operation,
        IReadOnlyList<string> QueryParams, bool CanReFetch);

    private static bool MatchesRoute(MultiRoute route, string method, string path) =>
        route.Method.Equals(method, StringComparison.OrdinalIgnoreCase)
        && route.Path.Equals(path, StringComparison.OrdinalIgnoreCase);

    private List<MultiRouteGroup> PrepareMultiRouteGroups()
    {
        var groups = CmdletConfigurator.GetMultiRouteGroups(config).ToList();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var group in groups)
        {
            if (group.Routes.Count < 2 || group.Routes.Count > 32)
                throw new InvalidOperationException("Multi-route groups require 2 to 32 exact operations.");
            if (group.SelectorParameter is { } selector
                && (!IsRouteIdentifier(selector) || !char.IsUpper(selector[0]) || CmdletEmitter.IsReservedDispatchParameterName(selector)))
                throw new InvalidOperationException($"Invalid multi-route selector parameter '{selector}'.");
            var labels = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var route in group.Routes)
            {
                if (!IsRouteIdentifier(route.Name) || route.Name.Equals("Published", StringComparison.OrdinalIgnoreCase)
                    || !route.Path.StartsWith('/') || route.Path.Contains('*')
                    || route.Method.ToUpperInvariant() is not ("GET" or "POST" or "PATCH" or "PUT" or "DELETE"))
                    throw new InvalidOperationException($"Invalid exact multi-route member '{route.Method} {route.Path}' ({route.Name}).");
                if (labels.TryGetValue(route.Name, out var existingLabel) && existingLabel != route.Name)
                    throw new InvalidOperationException($"Multi-route labels differ only by case: '{existingLabel}', '{route.Name}'.");
                labels[route.Name] = route.Name;
                if (!seen.Add(route.Method + " " + route.Path))
                    throw new InvalidOperationException($"Operation belongs to more than one multi-route member: {route.Method} {route.Path}.");
            }
            if (!group.Routes.Any(r => r.Name == group.DefaultRoute)
                || group.Routes.Select(r => r.Name).Distinct(StringComparer.OrdinalIgnoreCase).Count() < 2)
                throw new InvalidOperationException("Multi-route group requires at least two route names and an explicit matching default.");
        }
        return groups;
    }

    private static bool IsRouteIdentifier(string value) =>
        Regex.IsMatch(value, "^[A-Za-z][A-Za-z0-9]*$", RegexOptions.CultureInvariant);

    private async Task<int> EmitMultiRouteOperationsAsync(IReadOnlyList<MultiRouteGroup> groups,
        IReadOnlyList<MultiRouteOperation> operations, EmitContext ctx, CancellationToken cancellationToken)
    {
        var written = 0;
        foreach (var group in groups)
        {
            var members = group.Routes.Select(r => operations.SingleOrDefault(o =>
                MatchesRoute(r, o.Naming.SourceMethod, o.Naming.SourcePath))).ToArray();
            if (members.All(m => m is null)
                && !group.Routes.Any(r => document.Paths.Any(p => p.Key.Equals(r.Path, StringComparison.OrdinalIgnoreCase)
                    && p.Value.Operations?.Keys.Any(m => m.Method.Equals(r.Method, StringComparison.OrdinalIgnoreCase)) == true)))
                continue; // A module's configuration is also loaded when generating other modules.
            if (members.Any(m => m is null))
                throw new InvalidOperationException("Multi-route group is incomplete, filtered, suppressed or unsupported: "
                    + string.Join(", ", group.Routes.Where((_, i) => members[i] is null).Select(r => $"{r.Method} {r.Path}")));
            var selected = members.Select(m => m!).ToArray();
            var first = selected[0].Naming;
            if (selected.Any(o => o.Naming.VerbName != first.VerbName || o.Naming.Noun != first.Noun
                || !o.Naming.SourceMethod.Equals(first.SourceMethod, StringComparison.OrdinalIgnoreCase) || o.Naming.Kind != first.Kind))
                throw new InvalidOperationException("Multi-route members must resolve to the same public command, HTTP method and operation kind after naming overrides.");

            var workers = new List<CmdletEmitter.RouteWorker>();
            var sources = new List<string>();
            for (var i = 0; i < selected.Length; i++)
            {
                var op = selected[i];
                var naming = op.Naming;
                var method = naming.SourceMethod.ToUpperInvariant();
                if (naming.NormalizedPath.Contains('@', StringComparison.Ordinal)
                    || HasParameterizedIntermediateSegment(naming.SourcePath)
                    || (method == "GET" && (HasBinarySuccessContent(op.Operation)
                        || TryGetRequestJsonSchema(op.Operation) is not null
                        || (EndsWithEmittableODataSegment(naming.SourcePath) && !EndsWithSegment(naming.SourcePath, "$count")))))
                    throw new InvalidOperationException($"Unsupported multi-route operation shape: {method} {naming.SourcePath}.");
                var workerNaming = Naming.WithSuffix(naming, $"_Route{i}");
                var shape = "Invoke";
                string? outputType = null;
                string? source;
                IReadOnlyList<CmdletEmitter.DispatchParameter> bodyParameters = [];
                var extraQueryParameters = method == "GET"
                    ? GetExtraQueryParameters(op.Operation) : [];
                if (naming.Kind == OperationKind.Resource && method == "GET"
                    && EndsWithSegment(naming.SourcePath, "$count"))
                {
                    shape = "Scalar";
                    outputType = "int";
                    source = CmdletEmitter.EmitScalarGet(workerNaming, ctx, "int", op.QueryParams.ToHashSet(), extraQueryParameters);
                }
                else if (naming.Kind == OperationKind.Resource && method == "GET")
                {
                    var response = TryGetSuccessJsonSchema(op.Operation)
                        ?? throw new InvalidOperationException($"Multi-route GET has no JSON response: {naming.SourcePath}.");
                    if (FindProperty(response, "value") is { } value)
                    {
                        shape = "List";
                        if (!TryResolveListEntityTypeName(value, ctx.ModelsNamespace, out var entity))
                            throw new InvalidOperationException($"Unsupported multi-route collection response: {naming.SourcePath}.");
                        outputType = entity;
                        source = CmdletEmitter.EmitListGet(workerNaming, ctx, entity,
                            ResolveCollectionResponseType(response, ctx.ModelsNamespace, entity), op.QueryParams.ToHashSet(), extraQueryParameters);
                    }
                    else
                    {
                        shape = "Get";
                        if (!TryResolveEntityTypeName(response, ctx.ModelsNamespace, out var entity))
                            throw new InvalidOperationException($"Unsupported multi-route item response: {naming.SourcePath}.");
                        outputType = entity;
                        source = CmdletEmitter.EmitItemGet(workerNaming, ctx, entity, op.QueryParams.ToHashSet(), extraQueryParameters);
                    }
                }
                else
                {
                    if (op.QueryParams.Count != 0 || HasNonJsonRequestContent(op.Operation)
                        || HasBinarySuccessContent(op.Operation) || naming.Kind == OperationKind.Function
                        || EndsWithEmittableODataSegment(naming.SourcePath))
                        throw new InvalidOperationException($"Unsupported multi-route operation shape: {naming.SourceMethod} {naming.SourcePath}.");
                    var body = TryGetRequestJsonSchema(op.Operation);
                    if (method == "DELETE" && body is not null)
                        throw new InvalidOperationException($"Unsupported multi-route DELETE request body: {naming.SourcePath}.");
                    string? bodyType = null;
                    IReadOnlyList<CmdletProperty> scalars = [];
                    IReadOnlyList<ComplexParameter> complex = [];
                    IReadOnlyList<UntypedParameter> untyped = [];
                    if (body is not null)
                    {
                        bodyType = naming.Kind == OperationKind.Action
                            ? $"global::{ctx.ClientNamespace}.{naming.OperationTypeNamespace}.{naming.OperationTypeName}PostRequestBody"
                            : TryResolveEntityTypeName(body, ctx.ModelsNamespace, out var entity) ? entity
                            : throw new InvalidOperationException($"Unsupported multi-route request body: {naming.SourcePath}.");
                        (scalars, complex, untyped) = BindBodyProperties(body, ctx, naming, bodyType);
                        bodyParameters = CmdletEmitter.BodyDispatchParameters(scalars, complex, untyped);
                    }
                    if (naming.Kind == OperationKind.Action)
                    {
                        if (!TryResolveOperationReturnType(op.Operation, ctx, naming, true, out outputType, out var methodName, out var returnsStream))
                            throw new InvalidOperationException($"Unsupported multi-route action response: {naming.SourcePath}.");
                        source = CmdletEmitter.EmitAction(workerNaming, ctx,
                            new(methodName, outputType, bodyType, returnsStream), scalars, complex, untyped);
                    }
                    else
                    {
                        source = method switch
                        {
                            "DELETE" => CmdletEmitter.EmitRemove(workerNaming, ctx),
                            "POST" when bodyType is not null => CmdletEmitter.EmitNew(workerNaming, ctx, bodyType, scalars, complex, untyped),
                            "PATCH" when bodyType is not null => CmdletEmitter.EmitUpdate(workerNaming, ctx, bodyType, scalars, complex, untyped, op.CanReFetch),
                            "PUT" when bodyType is not null => CmdletEmitter.EmitUpdate(workerNaming, ctx, bodyType, scalars, complex, untyped,
                                reFetchAfterUpdate: false, httpMethodName: "PutAsync"),
                            _ => null,
                        };
                        if (method != "DELETE" && TryGetRequestJsonSchema(op.Operation) is { } request)
                            TryResolveEntityTypeName(request, ctx.ModelsNamespace, out outputType);
                    }
                }
                if (source is null)
                    throw new InvalidOperationException($"No supported multi-route worker for {naming.SourceMethod} {naming.SourcePath}.");
                if (method == "GET" && op.QueryParams.Any(q => q.StartsWith('$')
                    && (shape == "Get" ? q is not ("$select" or "$expand")
                        : shape == "Scalar" && q is not ("$filter" or "$search"))))
                    throw new InvalidOperationException($"Unsupported multi-route query option for {shape}: {naming.SourcePath}.");
                var parameters = CmdletEmitter.GetDispatchParameters(naming, shape, op.QueryParams.ToHashSet(), bodyParameters, extraQueryParameters);
                workers.Add(new(naming, workerNaming, group.Routes[i].Name, shape, parameters, outputType));
                sources.Add(source);
            }

            ValidateMultiRouteWorkers(group, selected, workers);
            // Validate and emit the public surface before writing any of this group's workers.
            var dispatcher = CmdletEmitter.EmitMultiRouteDispatcher(group, workers, ctx);
            for (var i = 0; i < workers.Count; i++)
                written += await WriteCmdletFileAsync(workers[i].InternalNaming, sources[i], cancellationToken).ConfigureAwait(false);
            written += await WriteCmdletFileAsync(first, dispatcher, cancellationToken).ConfigureAwait(false);
        }
        return written;
    }

    private static void ValidateMultiRouteWorkers(MultiRouteGroup group, IReadOnlyList<MultiRouteOperation> operations,
        IReadOnlyList<CmdletEmitter.RouteWorker> workers)
    {
        foreach (var family in workers.GroupBy(w => w.RouteName))
        {
            if (family.GroupBy(w => w.Shape).Any(g => g.Count() != 1))
                throw new InvalidOperationException($"Multi-route family '{family.Key}' is not an unambiguous list/item pair or single operation.");
            var list = family.SingleOrDefault(w => w.Shape == "List");
            var item = family.SingleOrDefault(w => w.Shape == "Get");
            if (list is not null && item is not null && !Naming.IsListItemPair(list.Naming, item.Naming))
                throw new InvalidOperationException($"Multi-route family '{family.Key}' is not an unambiguous list/item pair.");
        }
        foreach (var shape in workers.GroupBy(w => w.Shape))
        {
            var baseline = shape.First();
            var baselineOp = operations[workers.ToList().IndexOf(baseline)].Operation;
            foreach (var worker in shape.Skip(1))
            {
                var operation = operations[workers.ToList().IndexOf(worker)].Operation;
                if (SchemaSignature(TryGetRequestJsonSchema(baselineOp)) != SchemaSignature(TryGetRequestJsonSchema(operation))
                    || SchemaSignature(TryGetSuccessJsonSchema(baselineOp)) != SchemaSignature(TryGetSuccessJsonSchema(operation))
                    || ParameterSignature(baselineOp) != ParameterSignature(operation))
                    throw new InvalidOperationException($"Incompatible multi-route body, response, query or header shape: {worker.Naming.SourcePath}.");
            }
        }
        if (group.SelectorParameter is not null && workers.GroupBy(w => w.RouteName)
            .Any(f => !f.Select(w => w.Shape).Order().SequenceEqual(workers.Where(w => w.RouteName == group.DefaultRoute).Select(w => w.Shape).Order())))
            throw new InvalidOperationException("Selected multi-route families must expose the same operation shapes.");
    }

    private static string ParameterSignature(OpenApiOperation operation) =>
        string.Join("|", (operation.Parameters ?? []).Where(p => p.In != ParameterLocation.Path)
            .OrderBy(p => p.In).ThenBy(p => p.Name, StringComparer.Ordinal)
            .Select(p => $"{p.In}:{p.Name}:{p.Required}:{SchemaSignature(p.Schema)}"));

    private static IReadOnlyList<CmdletEmitter.StringQueryParameter> GetExtraQueryParameters(OpenApiOperation operation)
    {
        var parameters = new List<CmdletEmitter.StringQueryParameter>();
        var standard = new HashSet<string>(["$filter", "$select", "$expand", "$orderby", "$search", "$top", "$skip", "$count"], StringComparer.Ordinal);
        foreach (var parameter in (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Query && !standard.Contains(p.Name!)))
        {
            if (parameter.Name is null || !IsRouteIdentifier(parameter.Name)
                || parameter.Schema?.Type != JsonSchemaType.String || parameter.Schema.GetReferenceId() is not null
                || parameter.Schema.Enum?.Count > 0 || parameter.Schema.AllOf?.Count > 0
                || parameter.Schema.AnyOf?.Count > 0 || parameter.Schema.OneOf?.Count > 0)
                throw new InvalidOperationException($"Unsupported multi-route query parameter '{parameter.Name}': only plain named strings and existing OData query options are supported.");
            parameters.Add(new(parameter.Name, char.ToUpperInvariant(parameter.Name[0]) + parameter.Name[1..], parameter.Required));
        }
        return parameters;
    }

    private static string SchemaSignature(IOpenApiSchema? schema)
    {
        if (schema is null)
            return "none";
        if (schema.GetReferenceId() is { } reference)
            return "$ref:" + reference;
        return $"{schema.Type}:{schema.Format}:"
            + string.Join(",", (schema.Enum ?? []).Select(e => e.ToJsonString()))
            + "[" + (schema.Items is null ? "" : SchemaSignature(schema.Items)) + "]"
            + "{" + string.Join(",", (schema.Properties ?? new Dictionary<string, IOpenApiSchema>())
                .OrderBy(p => p.Key, StringComparer.Ordinal).Select(p => p.Key + ":" + SchemaSignature(p.Value))) + "}"
            + string.Join(",", (schema.Required ?? new HashSet<string>()).Order(StringComparer.Ordinal))
            + string.Join(",", (schema.AllOf ?? []).Select(SchemaSignature))
            + string.Join(",", (schema.AnyOf ?? []).Select(SchemaSignature))
            + string.Join(",", (schema.OneOf ?? []).Select(SchemaSignature));
    }
}
