using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed partial class PowerShellWrapperGenerationService
{
    private (CmdletEmitter.RouteWorker Worker, string Source) PrepareMutationRoute(
        HttpMethod method, string path, IOpenApiPathItem pathItem, OpenApiOperation operation,
        string family, int index, EmitContext ctx, bool recordDiagnostics)
    {
        var kind = ClassifyOperationKind(operation, method);
        if (kind == OperationKind.Function
            || (operation.Extensions?.TryGetValue("x-ms-docs-operation-type", out var extension) == true
                && extension is JsonNodeExtension node
                && node.Node?.ToString()?.Trim('"') != (kind == OperationKind.Action ? "action" : "operation"))
            || HasCallSegment(path) || path.Split('/').Any(s => s.StartsWith('$'))
            || (pathItem.Parameters ?? []).Any(p => p.In != ParameterLocation.Path)
            || (operation.Parameters ?? []).Any(p => p.In is not (ParameterLocation.Path or ParameterLocation.Header)))
            throw new InvalidOperationException($"Unsupported mutation group member, input location or query: {method} {path}.");

        var pathIds = Regex.Matches(path, @"\{([^}]+)\}").Select(m => m.Groups[1].Value).ToHashSet(StringComparer.Ordinal);
        if ((operation.Parameters ?? []).Concat(pathItem.Parameters ?? []).Where(p => p.In == ParameterLocation.Path)
            .Any(p => p.Name is null || !pathIds.Contains(p.Name) || !p.Required || !PlainString(p.Schema)))
            throw new InvalidOperationException($"Unsupported mutation group path-ID declaration: {path}.");
        var headers = (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Header).ToArray();
        if (headers.Any(p => p.Required || !PlainString(p.Schema)))
            throw new InvalidOperationException($"Unsupported mutation group header contract: {path}.");
        var naming = Naming.Resolve(new OperationInfo(method, path, headers.Select(p => p.Name!).ToArray(), kind), config, apiVersion);
        if (naming.CompositeKeyBuilderNamespace.Length != 0
            || naming.PathParamNames.Distinct(StringComparer.OrdinalIgnoreCase).Count() != naming.PathParamNames.Count)
            throw new InvalidOperationException($"Operation groups require ordinary distinct path IDs: {path}.");

        var internalNaming = Naming.WithSuffix(naming, $"_Route{index}");
        var outputType = MutationResponseType(operation, ctx, path);
        var bodySchema = TryGetRequestJsonSchema(operation);
        string? bodyType = null;
        if (operation.RequestBody is not null)
        {
            if (operation.RequestBody.Content?.Count != 1
                || operation.RequestBody.Content.Keys.Any(c => !IsJsonContent(c)) || bodySchema is null
                || HasRootUnion(bodySchema)
                || (bodySchema.Type is { } type && (type & ~JsonSchemaType.Null) != JsonSchemaType.Object)
                || bodySchema.AdditionalProperties is not null
                || SchemaProperties.Classify(bodySchema, ResolveComponentSchema).Unsupported.Count > 0)
                throw new InvalidOperationException($"Unsupported mutation group JSON body or properties: {path}.");
            if (kind == OperationKind.Action)
            {
                if (bodySchema.GetReferenceId() is not null)
                    throw new InvalidOperationException($"Action variants require an ordinary inline request body: {path}.");
                bodyType = $"global::{ctx.ClientNamespace}.{naming.OperationTypeNamespace}.{naming.OperationTypeName}PostRequestBody";
            }
            else if (!TryResolveEntityTypeName(bodySchema, ctx.ModelsNamespace, out bodyType)
                || ResolveComponentSchema(bodySchema.GetReferenceId()!) is null)
                throw new InvalidOperationException($"Resource variants require an ordinary named entity body: {path}.");
        }

        var (scalars, complex, untyped) = bodySchema is null
            ? ([], [], [])
            : BindBodyProperties(bodySchema, ctx, naming, bodyType!, recordDiagnostics);
        var parameters = naming.PathParamNames.Select((name, i) =>
            new CmdletEmitter.DispatchParameter(name, "string", Mandatory: true, Position: i))
            .Concat(naming.HeaderParams.Select(h => new CmdletEmitter.DispatchParameter(h.PsName, "string?")))
            .Concat(CmdletEmitter.GetBodyDispatchParameters(scalars, complex, untyped)).ToArray();

        string source, shape;
        if (kind == OperationKind.Action)
        {
            shape = "Action";
            source = CmdletEmitter.EmitAction(internalNaming, ctx,
                new CmdletEmitter.CallPlan("PostAsync", outputType, bodyType), scalars, complex, untyped);
        }
        else if (method == HttpMethod.Delete)
        {
            if (operation.RequestBody is not null || outputType is not null)
                throw new InvalidOperationException($"DELETE variants require bodyless void operations: {path}.");
            shape = "Remove";
            source = CmdletEmitter.EmitRemove(internalNaming, ctx);
        }
        else
        {
            if (bodyType is null || outputType != bodyType)
                throw new InvalidOperationException($"Resource write variants require the same named body and result entity: {path}.");
            shape = method == HttpMethod.Post ? "New" : method == HttpMethod.Patch ? "Update" : "Set";
            source = method == HttpMethod.Post
                ? CmdletEmitter.EmitNew(internalNaming, ctx, bodyType, scalars, complex, untyped)
                : CmdletEmitter.EmitUpdate(internalNaming, ctx, bodyType, scalars, complex, untyped,
                    reFetchAfterUpdate: method == HttpMethod.Patch && pathItem.Operations?.ContainsKey(HttpMethod.Get) == true,
                    httpMethodName: method == HttpMethod.Patch ? "PatchAsync" : "PutAsync");
        }
        return (new(naming, internalNaming, family, shape, parameters, outputType), source);
    }

    private static bool IsJsonContent(string contentType) =>
        contentType.Equals("application/json", StringComparison.OrdinalIgnoreCase)
        || contentType.EndsWith("+json", StringComparison.OrdinalIgnoreCase);

    private string? MutationResponseType(OpenApiOperation operation, EmitContext ctx, string path)
    {
        var responses = (operation.Responses ?? []).Where(r => r.Key.StartsWith('2')).ToArray();
        if (responses.Length == 0)
            throw new InvalidOperationException($"Mutation variants require an explicit success response: {path}.");
        string? outputType = null;
        foreach (var response in responses.Select(r => r.Value).Where(r => r.Content?.Count > 0))
        {
            if (response.Content!.Count != 1 || response.Content.Keys.Any(c => !IsJsonContent(c)))
                throw new InvalidOperationException($"Unsupported mutation group response media: {path}.");
            var schema = response.Content.Values.Single().Schema;
            if (schema is null
                || !TryResolveResponseTypeName(schema, ctx.ModelsNamespace, out var entityType)
                || (!HasRootUnion(schema) && (ResolveComponentSchema(schema.GetReferenceId()!) is not { } entity
                    || (entity.Type is { } type && (type & ~JsonSchemaType.Null) != JsonSchemaType.Object)))
                || (outputType is not null && outputType != entityType))
                throw new InvalidOperationException($"Unsupported mutation group response contract: {path}.");
            outputType = entityType;
        }
        return outputType;
    }

    private static bool HasRootUnion(IOpenApiSchema schema, HashSet<IOpenApiSchema>? ancestors = null)
    {
        ancestors ??= [];
        if (!ancestors.Add(schema))
            return true;
        var unsupported = schema.AnyOf?.Count > 0 || schema.OneOf?.Count > 0
            || (schema.AllOf ?? []).Any(s => HasRootUnion(s, ancestors));
        ancestors.Remove(schema);
        return unsupported;
    }

    private static string BodySignature(OpenApiOperation operation) => operation.RequestBody is null ? "none"
        : $"{operation.RequestBody.Required}:" + string.Join("|", (operation.RequestBody.Content ?? new Dictionary<string, IOpenApiMediaType>())
            .OrderBy(c => c.Key, StringComparer.Ordinal).Select(c => c.Key + ":" + BodySchemaSignature(c.Value.Schema)));

    // Referenced models share one definition in this document; inline action bodies must
    // agree recursively, including requiredness and nullability, not just CLR parameter types.
    private static string BodySchemaSignature(IOpenApiSchema? schema) => schema is null ? "none"
        : schema.GetReferenceId() is { } reference ? "$ref:" + reference
        : $"{SchemaSignature(schema)}:{schema.ReadOnly}:" + string.Join(",", (schema.Required ?? new HashSet<string>()).Order(StringComparer.Ordinal))
            + "{" + string.Join(",", (schema.Properties ?? new Dictionary<string, IOpenApiSchema>()).OrderBy(p => p.Key, StringComparer.Ordinal)
                .Select(p => p.Key + ":" + BodySchemaSignature(p.Value))) + "}"
            + "[" + BodySchemaSignature(schema.Items) + "]"
            + string.Join("|", (schema.AllOf ?? []).Select(BodySchemaSignature))
            + string.Join("|", (schema.AnyOf ?? []).Select(BodySchemaSignature))
            + string.Join("|", (schema.OneOf ?? []).Select(BodySchemaSignature));
}
