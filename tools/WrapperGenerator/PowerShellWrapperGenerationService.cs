using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi;

namespace WrapperGenerator;

// Emits one PowerShell cmdlet class per selected OpenAPI operation, straight from the
// OpenApiDocument that Program loaded and IncludePathFilter trimmed. There is no CodeDOM,
// refiner, or writer pipeline in between: an operation goes from OpenAPI to C# source text
// in one pass (naming via CmdletNaming, code text via CmdletEmitter).
public sealed partial class PowerShellWrapperGenerationService
{
    private readonly OpenApiDocument document;
    private readonly GeneratorConfig config;
    private readonly ILogger logger;
    private readonly HashSet<string> modelSubNamespaces;

    // Every file written this run, keyed case-insensitively (Windows file systems are), so a
    // second cmdlet resolving to an existing file is a detected collision instead of a silent
    // overwrite.
    private readonly Dictionary<string, string> writtenCmdletFiles = new(StringComparer.OrdinalIgnoreCase);
    private readonly List<string> fileCollisions = [];
    private readonly Dictionary<string, string> kiotaReservedRenames;

    public PowerShellWrapperGenerationService(OpenApiDocument document, GeneratorConfig configuration, ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(document);
        ArgumentNullException.ThrowIfNull(configuration);
        ArgumentNullException.ThrowIfNull(logger);
        this.document = document;
        config = configuration;
        this.logger = logger;

        // Kiota nests each dotted schema-name segment as a sub-namespace under Models
        // ("security.alert" -> Models.Security.Alert), and when a model's own name matches
        // such a namespace ("microsoft.graph.security" alongside "microsoft.graph.security.*")
        // it moves the class INSIDE it: Models.Security.Security. Collect those namespace
        // roots so ResolveModelTypeName can mirror the move — a bare "Security" would
        // otherwise resolve to the namespace, not the type, and fail to compile.
        // Model names grouped by the sub-namespace kiota puts them in ("" = Models root):
        // needed both for the namespace-move rule and to dedupe reserved-name renames the
        // way kiota does (against siblings in the same namespace).
        modelSubNamespaces = new HashSet<string>(StringComparer.Ordinal);
        var namesByNamespace = new Dictionary<string, HashSet<string>>(StringComparer.Ordinal) { [""] = new(StringComparer.Ordinal) };
        foreach (var key in document.Components?.Schemas?.Keys ?? Enumerable.Empty<string>())
        {
            var segments = StripGraphPrefix(key).Split('.')
                .Select(static s => char.ToUpperInvariant(s[0]) + s[1..]).ToArray();
            if (segments.Length > 1)
                modelSubNamespaces.Add(segments[0]);
            var ns = string.Join('.', segments[..^1]);
            if (!namesByNamespace.TryGetValue(ns, out var names))
                namesByNamespace[ns] = names = new HashSet<string>(StringComparer.Ordinal);
            names.Add(segments[^1]);
        }

        // Kiota renames model classes whose name is on its C# reserved list (BCL conflicts:
        // Directory, File, Task, ...) by appending "Object", then dedupes numerically against
        // sibling models. Observed and verified: microsoft.graph.directory generates as
        // DirectoryObject1 (directoryObject already exists at the root) and
        // microsoft.graph.identityGovernance.task as IdentityGovernance.TaskObject. This
        // mirrors observed kiota 1.32.2 behavior — a wrong prediction fails the module
        // compile, it cannot fail silently. Keyed by the full Pascal segment path.
        kiotaReservedRenames = new Dictionary<string, string>(StringComparer.Ordinal);
        foreach (var (ns, names) in namesByNamespace)
        {
            foreach (var reserved in KiotaReservedModelNames)
            {
                if (!names.Contains(reserved))
                    continue;
                var renamed = reserved + "Object";
                while (names.Contains(renamed))
                    renamed += "1";
                kiotaReservedRenames[ns.Length == 0 ? reserved : $"{ns}.{reserved}"] = renamed;
            }
        }
    }

    // Kiota's C# refiner reserves type names that collide with common BCL types (see
    // CSharpReservedClassNamesProvider in microsoft/kiota). Only names observed in Graph
    // docs are listed; a new one surfaces as a compile failure in the affected module.
    private static readonly string[] KiotaReservedModelNames = ["Directory", "File", "Task", "Type", "Environment"];

    // One GET operation from the first pass, held until we know whether it pairs with a
    // list/item partner. CollectionValueSchema is the response's "value" array property when
    // the response is a collection, null for a single entity. It is resolved once here so
    // later steps never re-walk the schema.
    private sealed record GetOperationRecord(CmdletNaming Naming, IOpenApiSchema ResponseSchema, IOpenApiSchema? CollectionValueSchema, IReadOnlyList<string> QueryParams)
    {
        public bool IsCollection => CollectionValueSchema is not null;
    }

    public async Task GenerateAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var ctx = new EmitContext(ClientNamespace: config.ClientNamespaceName);

        writtenCmdletFiles.Clear();
        fileCollisions.Clear();

        Directory.CreateDirectory(config.OutputPath);
        foreach (var stale in Directory.GetFiles(config.OutputPath, "*.g.cs"))
            File.Delete(stale);

        await File.WriteAllTextAsync(Path.Combine(config.OutputPath, "Shared.g.cs"), CmdletEmitter.EmitSharedAuth(ctx), cancellationToken).ConfigureAwait(false);
        LogWroteSharedFile();

        var written = 0;
        var getOperations = new List<GetOperationRecord>();

        foreach (var (pathTemplate, pathItem) in document.Paths)
        {
            foreach (var (httpMethod, operation) in pathItem.Operations ?? new Dictionary<HttpMethod, OpenApiOperation>())
            {
                cancellationToken.ThrowIfCancellationRequested();

                // Operation shapes the emitters cannot produce a valid cmdlet for yet are
                // skipped up front instead of emitted malformed: OData $-segments would produce
                // broken names (Get-MgBookingBusinesscount) or invalid builder chains
                // (client...$value does not compile), and parameterized function segments
                // ("getByUserIdAndRole(userId='{userId}',...)") mangle into garbage nouns.
                // The README's gap list tracks these shapes as future work.
                if (HasUnsupportedPathSegment(pathTemplate))
                {
                    LogSkippedUnsupportedOperation(httpMethod.Method, pathTemplate, "unsupported OData path segment ($-segment or parameterized function), not generated yet");
                    continue;
                }

                // Skip operations the published SDK deliberately does not ship. NamingOverrides
                // holds the citation for each one.
                if (NamingOverrides.IsSuppressed(httpMethod, pathTemplate, config))
                {
                    LogSuppressedOperation(httpMethod.Method, pathTemplate);
                    continue;
                }

                var queryParams = (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Query).Select(p => p.Name!).ToList();
                var headerParams = (operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Header).Select(p => p.Name!).ToList();

                // Only GET responses need inspecting: the list/item pairing is decided by the
                // response shape, and DELETE returns 204 with no body.
                //
                // Success-response resolution is Graph-scoped on purpose: the Graph metadata
                // keys success responses as "2XX" with JSON content, so TryGetSuccessJsonSchema
                // checks "2XX" first and falls back across 200/201/default and "+json" content
                // types for the few operations that deviate, rather than doing general content
                // negotiation the way a generic OpenAPI reader would have to.
                // A success response that also declares non-JSON content (octet-stream,
                // image/*) is a media download — kiota generates GetAsync returning Stream
                // there regardless of any JSON schema the doc also lists (the styled docs
                // attach an entity schema to /content endpoints; found by compiling Teams).
                // Stream downloads are not generated yet; see the README gap list.
                if (httpMethod == HttpMethod.Get && HasNonJsonSuccessContent(operation))
                {
                    LogSkippedUnsupportedOperation(httpMethod.Method, pathTemplate, "media/stream content endpoint, not generated yet");
                    continue;
                }

                var responseSchema = httpMethod == HttpMethod.Get
                    ? TryGetSuccessJsonSchema(operation)
                    : null;
                var collectionValueSchema = responseSchema is not null ? FindProperty(responseSchema, "value") : null;

                var cmdletNaming = Naming.Resolve(new OperationInfo(httpMethod, pathTemplate, headerParams), config);

                if (httpMethod == HttpMethod.Get && responseSchema is null)
                {
                    LogSkippedUnsupportedOperation(httpMethod.Method, pathTemplate, "missing supported success JSON response schema");
                    continue;
                }

                // GETs are held back: pairing is decided per noun, so it needs every GET first.
                if (httpMethod == HttpMethod.Get)
                {
                    getOperations.Add(new GetOperationRecord(cmdletNaming, responseSchema!, collectionValueSchema, queryParams));
                    continue;
                }

                string? source = httpMethod switch
                {
                    _ when httpMethod == HttpMethod.Delete => CmdletEmitter.EmitRemove(cmdletNaming, ctx),
                    _ when httpMethod == HttpMethod.Post => EmitNewFor(cmdletNaming, ctx, operation),
                    _ when httpMethod == HttpMethod.Patch => EmitUpdateFor(cmdletNaming, ctx, operation,
                        canReFetch: pathItem.Operations?.ContainsKey(HttpMethod.Get) == true),
                    _ => null,
                };

                if (source is null)
                {
                    var reason = httpMethod == HttpMethod.Delete || httpMethod == HttpMethod.Post || httpMethod == HttpMethod.Patch
                        ? "missing supported request JSON schema"
                        : "no wrapper emitter for this HTTP method";
                    LogSkippedUnsupportedOperation(httpMethod.Method, pathTemplate, reason);
                    continue;
                }

                written += await WriteCmdletFileAsync(cmdletNaming, source, cancellationToken).ConfigureAwait(false);
            }
        }

        written += await EmitGetOperationsAsync(getOperations, ctx, cancellationToken).ConfigureAwait(false);

        // All collisions for the run are reported together so one generation surfaces the
        // complete list; see edge-cases/naming-edge-cases.md for how each kind is resolved.
        if (fileCollisions.Count > 0)
        {
            throw new InvalidOperationException(
                $"{fileCollisions.Count} cmdlet name collision(s): a later operation would overwrite an already-written cmdlet file. " +
                $"Resolve each with a NamingOverrides rename or suppression.\n  " + string.Join("\n  ", fileCollisions));
        }

        LogWroteFiles(written + 1, config.OutputPath);
    }

    // Pairs a list GET (GET /users/{id}/messages) with its item GET
    // (GET /users/{id}/messages/{message-id}) and presents them as one public Get-MgX cmdlet,
    // matching the published SDK surface. The real work stays in two separate internal cmdlets
    // (the *_List/*_Get classes named by Naming.WithSuffix); the public dispatcher only picks
    // which one to invoke.
    //
    // A pairing is only trusted when it is structurally unambiguous: exactly one collection GET
    // and one single-entity GET share the noun, and the item's path extends the list's path by
    // exactly one id, in either of the shapes Naming.IsListItemPair accepts. Everything else
    // keeps the standalone shape: singleton navs with no list (GET /users/{id}/calendar),
    // list-only endpoints such as delta queries, or an unexpected same-noun collision.
    private async Task<int> EmitGetOperationsAsync(List<GetOperationRecord> getOperations, EmitContext ctx, CancellationToken cancellationToken)
    {
        var written = 0;
        var consumed = new HashSet<GetOperationRecord>();

        var listsByNoun = getOperations.Where(o => o.IsCollection).ToLookup(o => o.Naming.Noun);
        var itemsByNoun = getOperations.Where(o => !o.IsCollection).ToLookup(o => o.Naming.Noun);

        foreach (var listGroup in listsByNoun)
        {
            if (listGroup.Count() != 1)
                continue;
            var listOp = listGroup.Single();

            var itemGroup = itemsByNoun[listGroup.Key];
            if (itemGroup.Count() != 1)
                continue;
            var itemOp = itemGroup.Single();

            if (!Naming.IsListItemPair(listOp.Naming, itemOp.Naming))
                continue;

            if (!TryResolveListEntityTypeName(listOp.CollectionValueSchema!, ctx.ModelsNamespace, out var listEntityType)
                || !TryResolveEntityTypeName(itemOp.ResponseSchema, ctx.ModelsNamespace, out var entityType))
            {
                LogSkippedUnsupportedOperation("GET", listOp.Naming.BuilderExpression, "response schema is not a resolvable $ref entity type");
                continue;
            }
            var collectionResponseType = ResolveCollectionResponseType(listOp.ResponseSchema, ctx.ModelsNamespace, listEntityType);

            // The two real implementations: separate, independently documented cmdlets, unchanged
            // from (and reusing) the standalone shapes used for unpaired GETs.
            var internalListNaming = Naming.WithSuffix(listOp.Naming, "_List");
            var internalItemNaming = Naming.WithSuffix(itemOp.Naming, "_Get");
            var internalListSource = CmdletEmitter.EmitListGet(internalListNaming, ctx, listEntityType, collectionResponseType, listOp.QueryParams.ToHashSet());
            var internalItemSource = CmdletEmitter.EmitItemGet(internalItemNaming, ctx, entityType, itemOp.QueryParams.ToHashSet());

            // The thin public dispatcher on top, presenting the merged Get-MgX surface.
            var dispatcherSource = CmdletEmitter.EmitGetDispatcher(listOp.Naming, itemOp.Naming,
                internalListNaming, internalItemNaming, ctx, entityType, collectionResponseType,
                listOp.QueryParams.ToHashSet(), itemOp.QueryParams.ToHashSet());

            written += await WriteCmdletFileAsync(internalListNaming, internalListSource, cancellationToken).ConfigureAwait(false);
            written += await WriteCmdletFileAsync(internalItemNaming, internalItemSource, cancellationToken).ConfigureAwait(false);
            written += await WriteCmdletFileAsync(listOp.Naming, dispatcherSource, cancellationToken).ConfigureAwait(false);
            consumed.Add(listOp);
            consumed.Add(itemOp);
        }

        foreach (var op in getOperations)
        {
            if (consumed.Contains(op))
                continue;

            string? source;
            if (op.IsCollection)
            {
                if (!TryResolveListEntityTypeName(op.CollectionValueSchema!, ctx.ModelsNamespace, out var listEntityType))
                {
                    LogSkippedUnsupportedOperation("GET", op.Naming.BuilderExpression, "collection response schema is not a resolvable $ref entity type");
                    continue;
                }

                source = CmdletEmitter.EmitListGet(op.Naming, ctx, listEntityType,
                    ResolveCollectionResponseType(op.ResponseSchema, ctx.ModelsNamespace, listEntityType), op.QueryParams.ToHashSet());
            }
            else
            {
                if (!TryResolveEntityTypeName(op.ResponseSchema, ctx.ModelsNamespace, out var entityType))
                {
                    LogSkippedUnsupportedOperation("GET", op.Naming.BuilderExpression, "response schema is not a resolvable $ref entity type");
                    continue;
                }

                source = CmdletEmitter.EmitItemGet(op.Naming, ctx, entityType, op.QueryParams.ToHashSet());
            }

            written += await WriteCmdletFileAsync(op.Naming, source, cancellationToken).ConfigureAwait(false);
        }

        return written;
    }

    private async Task<int> WriteCmdletFileAsync(CmdletNaming naming, string source, CancellationToken cancellationToken)
    {
        const string cmdletClassSuffix = "Command";
        var className = naming.ClassName;
        var fileBaseName = className.EndsWith(cmdletClassSuffix, StringComparison.Ordinal)
            ? className[..^cmdletClassSuffix.Length]
            : className;
        var fileName = fileBaseName + ".g.cs";
        // Both colliding cmdlets usually share the same name, so the builder expression (the
        // request path) is what actually identifies which two operations collided.
        var cmdletName = $"{naming.VerbName}-{naming.Noun} [{naming.BuilderExpression}]";
        if (writtenCmdletFiles.TryGetValue(fileName, out var existing))
        {
            fileCollisions.Add($"{fileName}: '{cmdletName}' collides with already-written '{existing}'");
            return 0;
        }
        writtenCmdletFiles[fileName] = cmdletName;
        await File.WriteAllTextAsync(Path.Combine(config.OutputPath, fileName), source, cancellationToken).ConfigureAwait(false);
        LogWroteCmdletFile(fileName, naming.VerbName, naming.Noun);
        return 1;
    }

    [LoggerMessage(Level = LogLevel.Information, Message = "Wrote Shared.g.cs")]
    private partial void LogWroteSharedFile();
    [LoggerMessage(Level = LogLevel.Information, Message = "Wrote {FileName} ({Verb}-{Noun})")]
    private partial void LogWroteCmdletFile(string fileName, string verb, string noun);
    [LoggerMessage(Level = LogLevel.Information, Message = "Wrote {Count} file(s) to {OutputPath}")]
    private partial void LogWroteFiles(int count, string outputPath);
    [LoggerMessage(Level = LogLevel.Information, Message = "Suppressed {Method} {PathTemplate}: the published SDK ships no cmdlet for it (see NamingOverrides)")]
    private partial void LogSuppressedOperation(string method, string pathTemplate);
    [LoggerMessage(Level = LogLevel.Warning, Message = "Skipped {Method} {PathTemplate}: {Reason}")]
    private partial void LogSkippedUnsupportedOperation(string method, string pathTemplate, string reason);

    // True when the path contains a segment shape the emitters cannot handle yet: an OData
    // $-segment ($count/$value/$ref) or a parameterized function/action call (any segment
    // with parentheses, including delta()). OData cast segments (microsoft.graph.user) are
    // deliberately NOT excluded here: they emit valid builder chains and the parity gate
    // tracks them separately.
    private static bool HasUnsupportedPathSegment(string pathTemplate) =>
        pathTemplate.Split('/', StringSplitOptions.RemoveEmptyEntries)
            .Any(segment => segment.StartsWith('$') || segment.Contains('('));

    // collectionValueSchema is the already-resolved "value" array property from
    // GetOperationRecord, so nothing is re-walked here.
    private bool TryResolveListEntityTypeName(IOpenApiSchema collectionValueSchema, string modelsNamespace, out string entityTypeName)
    {
        entityTypeName = string.Empty;
        var itemSchema = collectionValueSchema.Items;
        if (itemSchema is null)
            return false;
        return TryResolveEntityTypeName(itemSchema, modelsNamespace, out entityTypeName);
    }

    // The old openApiDocs specs declare "value" directly on the schema; the KiotaCompat specs
    // compose it through allOf. Look in both places, recursively for nested composition.
    private static IOpenApiSchema? FindProperty(IOpenApiSchema schema, string propertyName)
    {
        if (schema.Properties?.TryGetValue(propertyName, out var direct) == true)
            return direct;

        foreach (var branch in schema.AllOf ?? [])
        {
            if (FindProperty(branch, propertyName) is { } found)
                return found;
        }

        return null;
    }

    private string? EmitNewFor(CmdletNaming naming, EmitContext ctx, OpenApiOperation operation)
    {
        // "application/json" is an intentional, Graph-scoped assumption: Graph request bodies are
        // JSON, so the content type is indexed directly rather than negotiated. See the matching
        // note on the response lookup in GenerateAsync.
        var bodySchema = TryGetRequestJsonSchema(operation);
        if (bodySchema is null)
            return null;
        if (!TryResolveEntityTypeName(bodySchema, ctx.ModelsNamespace, out var entityType))
            return null;
        var properties = SchemaProperties.ResolveParameterNameCollisions(
            SchemaProperties.ExtractPrimitiveProperties(bodySchema), naming.PathParamNames);
        return CmdletEmitter.EmitNew(naming, ctx, entityType, properties, SchemaProperties.HasPasswordProfile(bodySchema));
    }

    private string? EmitUpdateFor(CmdletNaming naming, EmitContext ctx, OpenApiOperation operation, bool canReFetch)
    {
        // "application/json" is an intentional, Graph-scoped assumption (see EmitNewFor).
        var bodySchema = TryGetRequestJsonSchema(operation);
        if (bodySchema is null)
            return null;
        if (!TryResolveEntityTypeName(bodySchema, ctx.ModelsNamespace, out var entityType))
            return null;
        var properties = SchemaProperties.ResolveParameterNameCollisions(
            SchemaProperties.ExtractPrimitiveProperties(bodySchema), naming.PathParamNames);
        return CmdletEmitter.EmitUpdate(naming, ctx, entityType, properties, SchemaProperties.HasPasswordProfile(bodySchema), canReFetch);
    }

    private static bool HasNonJsonSuccessContent(OpenApiOperation operation)
    {
        if (operation.Responses is null)
            return false;
        foreach (var key in new[] { "2XX", "200", "201" })
        {
            if (!operation.Responses.TryGetValue(key, out var response) || response?.Content is null)
                continue;
            foreach (var contentType in response.Content.Keys)
            {
                if (!contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase)
                    && !contentType.EndsWith("+json", StringComparison.OrdinalIgnoreCase))
                    return true;
            }
        }
        return false;
    }

    private static IOpenApiSchema? TryGetSuccessJsonSchema(OpenApiOperation operation)
    {
        if (operation.Responses is null)
            return null;

        foreach (var key in new[] { "2XX", "200", "201", "default" })
        {
            if (!operation.Responses.TryGetValue(key, out var response) || response?.Content is null)
                continue;

            var schema = TryGetJsonSchemaFromContent(response.Content);
            if (schema is not null)
                return schema;
        }

        return null;
    }

    private static IOpenApiSchema? TryGetRequestJsonSchema(OpenApiOperation operation)
    {
        var content = operation.RequestBody?.Content;
        if (content is null)
            return null;
        return TryGetJsonSchemaFromContent(content);
    }

    private static IOpenApiSchema? TryGetJsonSchemaFromContent(IDictionary<string, IOpenApiMediaType> content)
    {
        if (content.TryGetValue("application/json", out var exactJson) && exactJson?.Schema is not null)
            return exactJson.Schema;

        foreach (var (contentType, mediaType) in content)
        {
            if (contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase)
                || contentType.EndsWith("+json", StringComparison.OrdinalIgnoreCase))
            {
                if (mediaType?.Schema is not null)
                    return mediaType.Schema;
            }
        }

        return null;
    }

    private bool TryResolveEntityTypeName(IOpenApiSchema schema, string modelsNamespace, out string entityTypeName)
    {
        entityTypeName = string.Empty;
        var id = schema.GetReferenceId();
        if (string.IsNullOrEmpty(id))
            return false;
        entityTypeName = ResolveModelTypeName(id, modelsNamespace, modelSubNamespaces, kiotaReservedRenames);
        return true;
    }

    // The collection response type is resolved from the list response's own $ref, not by
    // appending "CollectionResponse" to the entity type: kiota's reserved-name rename hits
    // the entity but not its collection response (identityGovernance.task ->
    // Models.IdentityGovernance.TaskObject, but taskCollectionResponse -> TaskCollectionResponse
    // unchanged — found by compiling Identity.Governance). Falls back to the append for
    // inline response schemas without a $ref.
    private string ResolveCollectionResponseType(IOpenApiSchema listResponseSchema, string modelsNamespace, string listEntityType) =>
        TryResolveEntityTypeName(listResponseSchema, modelsNamespace, out var fromRef)
            ? fromRef
            : listEntityType + "CollectionResponse";

    private static string StripGraphPrefix(string schemaName) =>
        schemaName.StartsWith("microsoft.graph.", StringComparison.Ordinal)
            ? schemaName["microsoft.graph.".Length..]
            : schemaName;

    // Maps a schema reference id to the C# type name kiota generates for it. Public and pure
    // so the mapping rules are directly testable.
    //
    // Every reference is fully qualified. Bare names break two ways, both found by compiling
    // real modules: a name that matches a kiota sub-namespace resolves to the namespace
    // instead of the type ("Security"), and a name that matches a BCL type in scope resolves
    // to that ("Directory" vs System.IO.Directory under implicit usings). Kiota itself nests
    // dotted segments as sub-namespaces ("security.alert" -> Models.Security.Alert), and when
    // a model's own name matches such a namespace it moves the class inside it
    // (microsoft.graph.security -> Models.Security.Security, verified against a real client).
    public static string ResolveModelTypeName(string schemaName, string modelsNamespace, IReadOnlySet<string> modelSubNamespaces,
        IReadOnlyDictionary<string, string>? kiotaReservedRenames = null)
    {
        ArgumentNullException.ThrowIfNull(schemaName);
        ArgumentNullException.ThrowIfNull(modelsNamespace);
        ArgumentNullException.ThrowIfNull(modelSubNamespaces);

        var segments = StripGraphPrefix(schemaName).Split('.')
            .Select(static segment => char.ToUpperInvariant(segment[0]) + segment[1..]).ToArray();
        if (kiotaReservedRenames is not null && kiotaReservedRenames.TryGetValue(string.Join('.', segments), out var renamed))
            segments[^1] = renamed;
        var qualified = $"{modelsNamespace}.{string.Join('.', segments)}";
        return segments.Length == 1 && modelSubNamespaces.Contains(segments[0])
            ? $"{qualified}.{segments[0]}"
            : qualified;
    }
}
