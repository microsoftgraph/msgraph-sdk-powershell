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
        IReadOnlyList<string> QueryParams, bool CanReFetch, IReadOnlyList<IOpenApiParameter> PathItemParameters);

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
            if ((group.RequireExplicitRoute ? !string.IsNullOrEmpty(group.DefaultRoute) : !group.Routes.Any(r => r.Name == group.DefaultRoute))
                || group.Routes.Select(r => r.Name).Distinct(StringComparer.OrdinalIgnoreCase).Count() < 2)
                throw new InvalidOperationException("Multi-route groups require at least two route names and a matching default, or an empty default for required-route selection.");
            if ((group.AllowAsymmetricRoutes || group.AllowExplicitRouteSelection) && group.SelectorParameter is null)
                throw new InvalidOperationException("Asymmetric or explicit multi-route groups require an explicit selector parameter.");
            if (group.AllowPublishedParameterInference && !group.AllowExplicitRouteSelection)
                throw new InvalidOperationException("Published parameter inference requires the explicit per-route parameter policy.");
            if (group.Routes.Any(r => r.QueryBindings.Count > 0) && !group.AllowReferenceDelete)
                throw new InvalidOperationException("Explicit multi-route query bindings require the reviewed reference DELETE policy.");
            if (group.RequireExplicitRoute != group.AllowMixedMediaReads)
                throw new InvalidOperationException("Required route selection is supported only by the reviewed mixed-media read policy.");
            if (!group.AllowMixedMediaReads && group.Routes.Any(r => r.ReadKind != MultiRouteReadKind.Auto))
                throw new InvalidOperationException("Explicit read plans require the reviewed mixed-media read policy.");
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
                || !o.Naming.SourceMethod.Equals(first.SourceMethod, StringComparison.OrdinalIgnoreCase)
                || (!group.AllowMixedReadOperations && o.Naming.Kind != first.Kind)))
                throw new InvalidOperationException("Multi-route members must resolve to the same public command, HTTP method and operation kind after naming overrides.");
            ValidateMultiRoutePolicies(group, selected);

            var workers = new List<CmdletEmitter.RouteWorker>();
            var sources = new List<string>();
            for (var i = 0; i < selected.Length; i++)
            {
                var op = selected[i];
                var naming = op.Naming;
                var method = naming.SourceMethod.ToUpperInvariant();
                var binaryRead = group.AllowMixedMediaReads && group.Routes[i].ReadKind == MultiRouteReadKind.Binary;
                if (naming.NormalizedPath.Contains('@', StringComparison.Ordinal)
                    || HasParameterizedIntermediateSegment(naming.SourcePath)
                    || (method == "GET" && ((HasBinarySuccessContent(op.Operation) && !group.AllowMediaRoutes && !binaryRead)
                        || TryGetRequestJsonSchema(op.Operation) is not null
                        || (EndsWithEmittableODataSegment(naming.SourcePath) && !EndsWithSegment(naming.SourcePath, "$count")
                            && !group.AllowMediaRoutes))))
                    throw new InvalidOperationException($"Unsupported multi-route operation shape: {method} {naming.SourcePath}.");
                var workerNaming = Naming.WithSuffix(naming, $"_Route{i}");
                var shape = "Invoke";
                string? outputType = null;
                string? source;
                IReadOnlyList<CmdletEmitter.DispatchParameter> bodyParameters = [];
                var extraQueryParameters = method == "GET"
                    ? GetExtraQueryParameters(op.Operation)
                    : group.AllowReferenceDelete ? GetReferenceDeleteQueries(group.Routes[i], op.Operation) : [];
                if ((group.AllowMediaRoutes || binaryRead) && method == "GET")
                {
                    if (op.QueryParams.Count != 0
                        || !TryResolveOperationReturnType(op.Operation, ctx, naming, false,
                            out var contentType, out _, out var contentStream)
                        || contentType is null || !contentStream)
                        throw new InvalidOperationException($"Unsupported reviewed media GET contract: {naming.SourcePath}.");
                    shape = "Get";
                    outputType = "byte[]";
                    bodyParameters = [new("OutFile", "string?")];
                    source = CmdletEmitter.EmitContentGet(workerNaming, ctx, contentType, true, useStoppingToken: true);
                }
                else if (naming.Kind == OperationKind.Resource && method == "GET"
                    && EndsWithSegment(naming.SourcePath, "$count"))
                {
                    shape = "Scalar";
                    outputType = "int";
                    source = CmdletEmitter.EmitScalarGet(workerNaming, ctx, "int", op.QueryParams.ToHashSet(), extraQueryParameters);
                }
                else if (naming.Kind == OperationKind.Function && group.AllowZeroArgumentFunctions)
                {
                    if (!group.AllowZeroArgumentFunctions || naming.FunctionParameters.Count != 0
                        || !LastSegment(naming.SourcePath).EndsWith("()", StringComparison.Ordinal)
                        || IsDeltaCall(naming.SourcePath) || (!group.AllowMixedReadOperations && op.QueryParams.Count != 0)
                        || naming.HeaderParams.Count != 0
                        || !TryResolveOperationReturnType(op.Operation, ctx, naming, false,
                            out outputType, out var functionMethod, out var functionStream)
                        || outputType is null || functionStream)
                        throw new InvalidOperationException($"Unsupported multi-route function shape: {naming.SourcePath}.");
                    if (group.AllowMixedReadOperations)
                    {
                        var response = TryGetSuccessJsonSchema(op.Operation);
                        var value = response is null ? null : FindProperty(response, "value");
                        var nextLink = response is null ? null : FindProperty(response, "@odata.nextLink");
                        if (!IsStringNextLinkSchema(nextLink))
                            throw new InvalidOperationException($"Mixed read function response requires a plain string '@odata.nextLink' pagination member: {naming.SourcePath}.");
                        if (value is null || !TryResolveListEntityTypeName(value, ctx.ModelsNamespace, out var entity)
                            || extraQueryParameters.Any(p => p.Name != "model" || p.Required))
                            throw new InvalidOperationException($"Mixed reads require a typed paged function returning the common entity collection and only an optional string 'model' query: {naming.SourcePath}.");
                        shape = "List";
                        source = CmdletEmitter.EmitListGet(workerNaming, ctx, entity, outputType,
                            op.QueryParams.ToHashSet(), extraQueryParameters, functionMethod);
                        outputType = entity;
                    }
                    else
                    {
                        shape = "Get";
                        source = CmdletEmitter.EmitFunction(workerNaming, ctx, new(functionMethod, outputType, null), op.QueryParams.ToHashSet());
                    }
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
                    if ((op.QueryParams.Count != 0 && !group.AllowReferenceDelete) || HasNonJsonRequestContent(op.Operation)
                        || (group.AllowRouteSpecificBodies && op.Operation.RequestBody?.Content?.Keys.Any(contentType =>
                            !contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase)
                            && !contentType.EndsWith("+json", StringComparison.OrdinalIgnoreCase)) == true)
                        || HasBinarySuccessContent(op.Operation) || naming.Kind == OperationKind.Function
                        || (EndsWithEmittableODataSegment(naming.SourcePath) && !group.AllowReferenceDelete && !group.AllowMediaRoutes))
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
                        (scalars, complex, untyped) = BindBodyProperties(body, ctx, naming, bodyType,
                            requireCompleteBinding: group.AllowRouteSpecificBodies);
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
                            "DELETE" => CmdletEmitter.EmitRemove(workerNaming, ctx, extraQueryParameters),
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
                if (group.AllowMixedMediaReads && shape != (group.Routes[i].ReadKind == MultiRouteReadKind.List ? "List" : "Get"))
                    throw new InvalidOperationException($"Mixed-media read plan does not match the actual response shape: {naming.SourcePath}.");
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
                if ((!group.AllowRouteSpecificBodies
                        && SchemaSignature(TryGetRequestJsonSchema(baselineOp)) != SchemaSignature(TryGetRequestJsonSchema(operation)))
                    || (!group.AllowResponseUnion
                        && !(group.AllowMixedReadOperations && shape.Key == "List"
                            && baseline.OutputType == worker.OutputType)
                        && SchemaSignature(TryGetSuccessJsonSchema(baselineOp)) != SchemaSignature(TryGetSuccessJsonSchema(operation)))
                    || (group.AllowMixedMediaReads
                        ? false // Every role is checked against its own exact supported query/header contract.
                        : group.AllowMixedReadOperations
                        ? !CompatibleMixedReadParameters(baselineOp, operation)
                        : ParameterSignature(baselineOp, !group.AllowReferenceDelete) != ParameterSignature(operation, !group.AllowReferenceDelete)))
                    throw new InvalidOperationException($"Incompatible multi-route body, response, query or header shape: {worker.Naming.SourcePath}.");
            }
        }
        if (group.SelectorParameter is not null && !group.AllowAsymmetricRoutes && workers.GroupBy(w => w.RouteName)
            .Any(f => !f.Select(w => w.Shape).Order().SequenceEqual(workers.Where(w => w.RouteName == group.DefaultRoute).Select(w => w.Shape).Order())))
            throw new InvalidOperationException("Selected multi-route families must expose the same operation shapes.");
        if (group.AllowMixedReadOperations && workers.Select(w => w.OutputType).Distinct(StringComparer.Ordinal).Count() != 1)
            throw new InvalidOperationException("Mixed read workers must emit the same entity type; differing envelope types do not authorize differing payload models.");
        if (group.AllowMixedMediaReads && workers.Where((_, i) => group.Routes[i].ReadKind != MultiRouteReadKind.Binary)
            .Select(w => w.OutputType).Distinct(StringComparer.Ordinal).Count() != 1)
            throw new InvalidOperationException("Mixed-media JSON list/item workers must emit the same recording entity type.");
    }

    private static string ParameterSignature(OpenApiOperation operation, bool includeQueries = true) =>
        string.Join("|", (operation.Parameters ?? []).Where(p => p.In != ParameterLocation.Path
                && (includeQueries || p.In != ParameterLocation.Query))
            .OrderBy(p => p.In).ThenBy(p => p.Name, StringComparer.Ordinal)
            .Select(p => $"{p.In}:{p.Name}:{p.Required}:{SchemaSignature(p.Schema)}"));

    private static bool CompatibleMixedReadParameters(OpenApiOperation left, OpenApiOperation right)
    {
        var leftParameters = (left.Parameters ?? []).Where(p => p.In != ParameterLocation.Path)
            .ToDictionary(p => (p.In, p.Name));
        var rightParameters = (right.Parameters ?? []).Where(p => p.In != ParameterLocation.Path)
            .ToDictionary(p => (p.In, p.Name));
        foreach (var key in leftParameters.Keys.Union(rightParameters.Keys))
        {
            var inLeft = leftParameters.TryGetValue(key, out var leftParameter);
            var inRight = rightParameters.TryGetValue(key, out var rightParameter);
            if (inLeft && inRight)
            {
                if (leftParameter!.Required != rightParameter!.Required
                    || SchemaSignature(leftParameter.Schema) != SchemaSignature(rightParameter.Schema))
                    return false;
            }
            else
            {
                var parameter = inLeft ? leftParameter! : rightParameter!;
                if (parameter.In != ParameterLocation.Query || parameter.Name != "model"
                    || parameter.Required || !IsPlainStringQuery(parameter))
                    return false;
            }
        }
        return true;
    }

    private static void ValidateMultiRoutePolicies(MultiRouteGroup group, IReadOnlyList<MultiRouteOperation> operations)
    {
        var naming = operations[0].Naming;
        var method = naming.SourceMethod.ToUpperInvariant();
        var extension = group.AllowZeroArgumentFunctions || group.AllowAsymmetricRoutes || group.AllowResponseUnion
            || group.AllowRouteSpecificBodies || group.AllowReferenceDelete || group.AllowMediaRoutes || group.AllowExplicitRouteSelection
            || group.AllowMixedReadOperations || group.AllowMixedMediaReads;
        if (extension && method == "GET" && operations.Any(o => o.Operation.RequestBody is not null))
            throw new InvalidOperationException("Reviewed GET route extensions do not support any request body.");
        if (extension
            && operations.Any(o => o.PathItemParameters.Any(p => p.In is ParameterLocation.Query or ParameterLocation.Header)))
            throw new InvalidOperationException("Reviewed route extensions do not support path-item query or header parameters; explicit operation binding is required.");
        if (group.AllowMixedReadOperations && (method != "GET" || operations.Count != 3
            || operations.Count(o => o.Naming.Kind == OperationKind.Function) != 1
            || operations.Count(o => o.Naming.Kind == OperationKind.Resource) != 2
            || !group.AllowZeroArgumentFunctions || !group.AllowAsymmetricRoutes
            || !group.AllowExplicitRouteSelection || !group.AllowPublishedParameterInference))
            throw new InvalidOperationException("Mixed reads require exactly one zero-argument paged GET function and its resource list/item family, with asymmetric explicit selection and reviewed Published inference.");
        if (group.AllowZeroArgumentFunctions && (!group.AllowMixedReadOperations && naming.Kind != OperationKind.Function || method != "GET"))
            throw new InvalidOperationException("The zero-argument function policy applies only to GET functions.");
        if (group.AllowMixedMediaReads)
            ValidateMixedMediaReadPolicy(group, operations);
        if (group.AllowAsymmetricRoutes && (!group.AllowMixedReadOperations && naming.Kind != OperationKind.Resource || method != "GET"))
            throw new InvalidOperationException("The asymmetric route policy applies only to resource GET groups.");
        if (group.AllowRouteSpecificBodies && (naming.Kind != OperationKind.Action || method != "POST"
            || (group.SelectorParameter is not null && !group.AllowExplicitRouteSelection)))
            throw new InvalidOperationException("Route-specific body plans require POST actions with parent discrimination or an explicit route-selection policy.");
        if (group.AllowResponseUnion && !(naming.Kind == OperationKind.Resource && method == "GET"
            || naming.Kind == OperationKind.Action && method == "POST"))
            throw new InvalidOperationException("Response unions are supported only for reviewed resource GET or POST action groups.");
        if (group.AllowReferenceDelete && (naming.Kind != OperationKind.Resource || method != "DELETE"
            || operations.Any(o => !EndsWithSegment(o.Naming.SourcePath, "$ref"))))
            throw new InvalidOperationException("The reference DELETE policy requires exact resource DELETE /$ref routes.");
        if (group.AllowMediaRoutes && (naming.Kind != OperationKind.Resource || method is not ("GET" or "DELETE")
            || operations.Any(o => !EndsWithSegment(o.Naming.SourcePath, "$value"))))
            throw new InvalidOperationException("The media route policy requires exact resource GET or DELETE /$value routes.");
        if (group.AllowExplicitRouteSelection && !(
            naming.Kind == OperationKind.Action && method == "POST"
            || (naming.Kind == OperationKind.Resource || group.AllowMixedReadOperations) && method == "GET" && (group.AllowAsymmetricRoutes
                || operations.All(o => EndsWithSegment(o.Naming.SourcePath, "$count")))))
            throw new InvalidOperationException("Explicit route selection is supported only for reviewed scalar counts, asymmetric resource GETs or POST actions.");
    }

    private static IReadOnlyList<CmdletEmitter.StringQueryParameter> GetReferenceDeleteQueries(MultiRoute route, OpenApiOperation operation)
    {
        var queries = (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Query).ToArray();
        if (queries.Length == 0 && route.QueryBindings.Count == 0)
            return [];
        if (queries.Length != 1 || queries[0].Name != "@id" || !queries[0].Required
            || !IsPlainStringQuery(queries[0]) || route.QueryBindings.Count != 1
            || route.QueryBindings[0].QueryName != "@id" || route.QueryBindings[0].ParameterName != "MemberReferenceUri")
            throw new InvalidOperationException($"Reference DELETE requires an explicit MemberReferenceUri binding for the spec's required string '@id' query: {route.Path}.");
        return [new("@id", "MemberReferenceUri", true) { BuilderPropertyName = "Id" }];
    }

    private static bool IsPlainStringQuery(IOpenApiParameter parameter) =>
        parameter.Schema?.Type == JsonSchemaType.String && parameter.Schema.GetReferenceId() is null
        && !(parameter.Schema.Enum?.Count > 0 || parameter.Schema.AllOf?.Count > 0
            || parameter.Schema.AnyOf?.Count > 0 || parameter.Schema.OneOf?.Count > 0);

    private static bool IsStringNextLinkSchema(IOpenApiSchema? schema) =>
        schema?.Type is { } type && (type & ~JsonSchemaType.Null) == JsonSchemaType.String
        && schema.GetReferenceId() is null && !(schema.AnyOf?.Count > 0 || schema.OneOf?.Count > 0);

    private static IReadOnlyList<CmdletEmitter.StringQueryParameter> GetExtraQueryParameters(OpenApiOperation operation)
    {
        var parameters = new List<CmdletEmitter.StringQueryParameter>();
        var standard = new HashSet<string>(["$filter", "$select", "$expand", "$orderby", "$search", "$top", "$skip", "$count"], StringComparer.Ordinal);
        foreach (var parameter in (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Query && !standard.Contains(p.Name!)))
        {
            if (parameter.Name is null || !IsRouteIdentifier(parameter.Name) || !IsPlainStringQuery(parameter))
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
