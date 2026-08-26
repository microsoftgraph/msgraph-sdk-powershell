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

    // Body-property classification totals for this run; reported as one reconciliation line.
    // propertiesSeenCount is accumulated from the classifier's own independent count so the
    // reported total is not merely the sum of the buckets beside it.
    private int propertiesSeenCount;
    private int boundScalarCount;
    private int boundComplexCount;
    private int boundUntypedCount;
    private int unsupportedPropertyCount;
    private int excludedPropertyCount;

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
    private static readonly string[] KiotaReservedModelNames =
        ["Action", "DayOfWeek", "Directory", "Environment", "File", "Task", "Type", "ValueType"];

    // One GET operation from the first pass, held until we know whether it pairs with a
    // list/item partner. CollectionValueSchema is the response's "value" array property when
    // the response is a collection, null for a single entity. It is resolved once here so
    // later steps never re-walk the schema.
    private sealed record GetOperationRecord(CmdletNaming Naming, IOpenApiSchema ResponseSchema, IOpenApiSchema? CollectionValueSchema, IReadOnlyList<string> QueryParams)
    {
        public bool IsCollection => CollectionValueSchema is not null;
    }

    private sealed record DeltaOperationRecord(CmdletNaming Naming, OpenApiOperation Operation, IReadOnlyList<string> QueryParams, string PathTemplate)
    {
        // The parameterless form is the canonical command; the argument form is its resume path.
        public bool IsResumeForm => !LastSegment(PathTemplate).Equals("delta()", StringComparison.Ordinal);

        // Both forms of one operation normalise to the same key, which is what pairs them.
        public string PairKey => PathTemplate[..^LastSegment(PathTemplate).Length] + "delta()";
    }

    private static string LastSegment(string pathTemplate)
    {
        var i = pathTemplate.LastIndexOf('/');
        return i < 0 ? pathTemplate : pathTemplate[(i + 1)..];
    }

    // A change-tracking call, identified by shape rather than by a list of routes: the final
    // segment is a call whose name is delta, in either its parameterless or argument form.
    private static bool IsDeltaCall(string pathTemplate)
    {
        var last = LastSegment(pathTemplate);
        return last.StartsWith("delta(", StringComparison.Ordinal) && last.EndsWith(')');
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

        // No per-module Shared.g.cs: the helpers it carried (GraphRouteAttribute, UntypedValue,
        // the bearer provider) live once in Microsoft.Graph.Wrapper.Runtime, which every module
        // project references.
        var written = 0;
        var getOperations = new List<GetOperationRecord>();
        // Delta operations are held back for the same reason GETs are: the parameterless form and
        // its token form are one command, so the decision needs both before either is emitted.
        var deltaOperations = new List<DeltaOperationRecord>();

        foreach (var (pathTemplate, pathItem) in document.Paths)
        {
            foreach (var (httpMethod, operation) in pathItem.Operations ?? new Dictionary<HttpMethod, OpenApiOperation>())
            {
                cancellationToken.ThrowIfCancellationRequested();

                // What the OData metadata says this operation is. Actions and functions are
                // calls on a resource rather than CRUD over one, which decides the verb, the
                // request shape and the kiota member the call goes through.
                var operationKind = ClassifyOperationKind(operation, httpMethod);

                // Operation shapes the emitters cannot produce a valid cmdlet for yet are
                // skipped up front instead of emitted malformed: OData $-segments would produce
                // broken names (Get-MgBookingBusinesscount) or invalid builder chains
                // (client...$value does not compile). The README's gap list tracks these
                // shapes as future work.
                if (HasUnsupportedODataSegment(pathTemplate))
                {
                    LogSkippedUnsupportedOperation(httpMethod.Method, pathTemplate, "unsupported OData $-segment, not generated yet");
                    continue;
                }

                // A parenthesised segment on an operation the spec does NOT class as an action or
                // function: the arguments belong to a call the generator has no shape for, and the
                // segment would mangle into a garbage noun.
                if (operationKind == OperationKind.Resource && HasCallSegment(pathTemplate))
                {
                    LogSkippedUnsupportedOperation(httpMethod.Method, pathTemplate, "call segment on an operation the spec does not class as an action or function");
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
                // An action or function returning bytes goes through EmitOperationCall, which binds
                // the response as a byte array, so the media test below is scoped to resource
                // operations rather than intercepting every GET.

                var cmdletNaming = Naming.Resolve(new OperationInfo(httpMethod, pathTemplate, headerParams, operationKind), config);

                // An action or function is emitted from its own shape: it is never half of a
                // list/item pair, and its request and response types are the per-operation
                // classes kiota generates beside the request builder.
                if (operationKind != OperationKind.Resource)
                {
                    if (operationKind == OperationKind.Function && IsDeltaCall(pathTemplate))
                    {
                        deltaOperations.Add(new DeltaOperationRecord(cmdletNaming, operation, queryParams, pathTemplate));
                        continue;
                    }

                    var operationSource = EmitOperationCall(cmdletNaming, ctx, operation, operationKind, queryParams, pathTemplate);
                    if (operationSource is null)
                        continue;
                    written += await WriteCmdletFileAsync(cmdletNaming, operationSource, cancellationToken).ConfigureAwait(false);
                    continue;
                }

                // An OData /$value is the raw bytes behind a resource: GET reads them, PUT
                // replaces them, DELETE clears them. GET and PUT need their own shapes because
                // kiota types both as Stream; DELETE is an ordinary delete and falls through.
                //
                // A GET whose success response declares non-JSON content (octet-stream, image/*)
                // is the same shape under a different spelling: a literal media segment such as
                // /content, /logo or /favicon, which kiota also types as Stream. The styled
                // documents attach an entity schema to those endpoints as well, so the content
                // type is what identifies them, not the schema. The test excludes the emittable
                // $-segments because /$count answers text/plain — without that exclusion it would
                // divert /$count here instead of letting its own branch below run.
                var isMediaDownload = httpMethod == HttpMethod.Get
                    && !EndsWithEmittableODataSegment(pathTemplate)
                    && HasBinarySuccessContent(operation);
                if ((EndsWithSegment(pathTemplate, "$value") || isMediaDownload) && httpMethod != HttpMethod.Delete)
                {
                    if (httpMethod != HttpMethod.Get && httpMethod != HttpMethod.Put)
                    {
                        LogSkippedUnsupportedOperation(httpMethod.Method, cmdletNaming.NormalizedPath, "no wrapper emitter for this HTTP method");
                        continue;
                    }
                    // The response is usually the bytes themselves, but several /$value writes
                    // return the updated entity instead (a driveItem, a onenotePage). The type
                    // is resolved from the response rather than assumed to be a stream.
                    if (!TryResolveOperationReturnType(operation, ctx, cmdletNaming, isAction: false,
                            out var contentType, out _, out var contentIsStream)
                        || contentType is null)
                    {
                        LogSkippedUnsupportedOperation(httpMethod.Method, cmdletNaming.NormalizedPath, "content response is neither a stream nor a resolvable entity");
                        continue;
                    }
                    var contentSource = httpMethod == HttpMethod.Get
                        ? CmdletEmitter.EmitContentGet(cmdletNaming, ctx, contentType, contentIsStream)
                        : CmdletEmitter.EmitContentSet(cmdletNaming, ctx, contentType, contentIsStream);
                    written += await WriteCmdletFileAsync(cmdletNaming, contentSource, cancellationToken).ConfigureAwait(false);
                    continue;
                }

                // A /$ref operation manages the references of a relationship rather than the
                // entities behind it. GET lists reference URLs (kiota: StringCollectionResponse,
                // not a collection of entities); POST and PUT take a referenceCreate body and
                // return nothing, so neither the New nor the Set shape fits. DELETE is an
                // ordinary delete and falls through.
                if (EndsWithSegment(pathTemplate, "$ref") && httpMethod != HttpMethod.Delete)
                {
                    var refSource = EmitReferenceOperation(cmdletNaming, ctx, operation, httpMethod, queryParams);
                    if (refSource is null)
                    {
                        LogSkippedUnsupportedOperation(httpMethod.Method, cmdletNaming.NormalizedPath, "no wrapper emitter for this reference operation");
                        continue;
                    }
                    written += await WriteCmdletFileAsync(cmdletNaming, refSource, cancellationToken).ConfigureAwait(false);
                    continue;
                }

                // A /$count GET returns a number, not a resource, so it is emitted directly
                // rather than being held back for list/item pairing — there is no entity schema
                // to resolve and no item GET it could pair with.
                if (httpMethod == HttpMethod.Get && EndsWithSegment(pathTemplate, "$count"))
                {
                    written += await WriteCmdletFileAsync(cmdletNaming,
                        CmdletEmitter.EmitScalarGet(cmdletNaming, ctx, "int", queryParams.ToHashSet()), cancellationToken).ConfigureAwait(false);
                    continue;
                }

                var responseSchema = httpMethod == HttpMethod.Get
                    ? TryGetSuccessJsonSchema(operation)
                    : null;
                var collectionValueSchema = responseSchema is not null ? FindProperty(responseSchema, "value") : null;

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
                    _ when httpMethod == HttpMethod.Put => EmitSetFor(cmdletNaming, ctx, operation),
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
        written += await EmitDeltaOperationsAsync(deltaOperations, ctx, cancellationToken).ConfigureAwait(false);

        // All collisions for the run are reported together so one generation surfaces the
        // complete list; see docs/edge-cases/naming-edge-cases.md for how each kind is resolved.
        if (fileCollisions.Count > 0)
        {
            throw new InvalidOperationException(
                $"{fileCollisions.Count} cmdlet name collision(s): a later operation would overwrite an already-written cmdlet file. " +
                $"Resolve each with a NamingOverrides rename or suppression.\n  " + string.Join("\n  ", fileCollisions));
        }

        LogBodyPropertyReconciliation(
            propertiesSeenCount,
            boundScalarCount, boundComplexCount, boundUntypedCount, excludedPropertyCount, unsupportedPropertyCount);

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
    // One command per change-tracking operation. The published SDK does not ship the argument
    // form as its own command - it folds it into the canonical delta command - so the argument
    // form is emitted as this command's Resume parameter set and produces no file of its own.
    // The pairing is DERIVED from route shape, never from a list of cmdlet names, and anything
    // the rule cannot resolve fails generation rather than being silently kept or dropped:
    // a wrong guess here would either invent a command the SDK does not ship or lose an
    // operation, and both are worse than a build that stops and names the route.
    private async Task<int> EmitDeltaOperationsAsync(List<DeltaOperationRecord> deltaOperations, EmitContext ctx, CancellationToken cancellationToken)
    {
        var written = 0;
        foreach (var pair in deltaOperations.GroupBy(d => d.PairKey, StringComparer.Ordinal))
        {
            var canonical = pair.Where(d => !d.IsResumeForm).ToList();
            var resume = pair.Where(d => d.IsResumeForm).ToList();

            if (canonical.Count == 0)
                throw new InvalidOperationException(
                    $"delta resume form has no parameterless sibling to merge into: {string.Join(", ", resume.Select(r => r.PathTemplate))}");
            if (canonical.Count > 1)
                throw new InvalidOperationException(
                    $"delta operation has {canonical.Count} parameterless forms, so the resume form cannot be attached unambiguously: {string.Join(", ", canonical.Select(c => c.PathTemplate))}");
            if (resume.Count > 1)
                throw new InvalidOperationException(
                    $"delta operation has {resume.Count} resume forms: {string.Join(", ", resume.Select(r => r.PathTemplate))}");

            var op = canonical[0];
            if (!TryResolveOperationReturnType(op.Operation, ctx, op.Naming, isAction: false, out var returnType, out var methodName, out var returnsStream))
            {
                LogSkippedUnsupportedOperation("GET", op.Naming.BuilderExpression, "delta response schema is neither a resolvable entity nor a value-wrapping response");
                continue;
            }

            // A delta cmdlet writes the envelope's items to the pipeline and never the envelope
            // itself, so OutputType has to name the item model. Advertising the response type
            // describes an object the cmdlet never emits, which is what help, IntelliSense and
            // anything reading OutputType would then report.
            string? deltaItemType = null;
            if (TryGetSuccessJsonSchema(op.Operation) is { } deltaResponseSchema
                && FindProperty(deltaResponseSchema, "value") is { } deltaValueSchema
                && TryResolveListEntityTypeName(deltaValueSchema, ctx.ModelsNamespace, out var resolvedItemType))
            {
                deltaItemType = resolvedItemType;
            }

            var source = CmdletEmitter.EmitDelta(op.Naming, ctx,
                new CmdletEmitter.CallPlan(methodName, returnType, BodyTypeName: null, returnsStream),
                op.QueryParams.ToHashSet(), deltaItemType);
            written += await WriteCmdletFileAsync(op.Naming, source, cancellationToken).ConfigureAwait(false);
        }

        return written;
    }

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
        // Both colliding cmdlets usually share the same name, so the route is what actually
        // identifies which two operations collided. It is reported directly rather than left to
        // be reconstructed from the builder expression, which cannot express a function's OData
        // arguments or an action's namespace qualifier.
        var cmdletName = $"{naming.VerbName}-{naming.Noun} [{naming.NormalizedPath}]";
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

    [LoggerMessage(Level = LogLevel.Information, Message = "Wrote {FileName} ({Verb}-{Noun})")]
    private partial void LogWroteCmdletFile(string fileName, string verb, string noun);
    [LoggerMessage(Level = LogLevel.Information, Message = "Wrote {Count} file(s) to {OutputPath}")]
    private partial void LogWroteFiles(int count, string outputPath);
    [LoggerMessage(Level = LogLevel.Information, Message = "Suppressed {Method} {PathTemplate}: the published SDK ships no cmdlet for it (see NamingOverrides)")]
    private partial void LogSuppressedOperation(string method, string pathTemplate);
    [LoggerMessage(Level = LogLevel.Warning, Message = "Skipped {Method} {PathTemplate}: {Reason}")]
    private partial void LogSkippedUnsupportedOperation(string method, string pathTemplate, string reason);
    // Information, not Warning: an unbindable body property is a known coverage gap per shape,
    // not a defect in this run, and at Graph scale these would drown the operation warnings.
    [LoggerMessage(Level = LogLevel.Information, Message = "Unbound body property {Noun}.{Property}: {Shape} (required={IsRequired})")]
    private partial void LogSkippedBodyProperty(string noun, string property, string shape, bool isRequired);
    [LoggerMessage(Level = LogLevel.Information, Message = "Excluded body property {Noun}.{Property}: {Policy}")]
    private partial void LogExcludedBodyProperty(string noun, string property, string policy);
    [LoggerMessage(Level = LogLevel.Information, Message = "Body properties classified={Classified} = scalar={Scalars} + model={Complex} + untyped={Untyped} + excluded={Excluded} + unsupported={Unsupported}")]
    private partial void LogBodyPropertyReconciliation(int classified, int scalars, int complex, int untyped, int excluded, int unsupported);

    // What the spec says the operation is. x-ms-docs-operation-type is the Graph metadata's own
    // classification, so actions and functions are identified from the document rather than
    // guessed from the path — a segment carrying parentheses is a consequence of being a
    // function, not the definition of one. The HTTP method is checked too: an entry claiming to
    // be an action on anything but POST (or a function on anything but GET) would be emitted
    // with the wrong request shape, so it falls back to resource handling.
    private static OperationKind ClassifyOperationKind(OpenApiOperation operation, HttpMethod httpMethod)
    {
        if (operation.Extensions is null
            || !operation.Extensions.TryGetValue("x-ms-docs-operation-type", out var extension)
            || extension is not JsonNodeExtension node)
            return OperationKind.Resource;

        return node.Node?.ToString()?.Trim('"') switch
        {
            "action" when httpMethod == HttpMethod.Post => OperationKind.Action,
            "function" when httpMethod == HttpMethod.Get => OperationKind.Function,
            _ => OperationKind.Resource,
        };
    }

    // True when the path contains a segment shape the emitters cannot handle yet: an OData
    // $-segment ($count/$value/$ref), or a parenthesised segment on an operation the spec does
    // NOT class as an action or function — the latter would mangle into a garbage noun, whereas
    // a declared function's segment is parsed into its name and inline arguments. OData cast
    // segments (microsoft.graph.user) are deliberately NOT excluded here: they emit valid
    // builder chains and the parity gate tracks them separately.
    // True when a segment BEFORE the last one is a function call carrying arguments. A
    // zero-argument call ("range()") is exempt: kiota exposes it as a plain property, so there
    // is nothing to bind.
    private static bool HasParameterizedIntermediateSegment(string pathTemplate)
    {
        var fixedSegments = pathTemplate.Split('/', StringSplitOptions.RemoveEmptyEntries)
            .Where(s => !(s.StartsWith('{') && s.EndsWith('}')))
            .ToList();
        return fixedSegments.Take(Math.Max(0, fixedSegments.Count - 1))
            .Any(s => Naming.ParseOperationSegment(s).Parameters.Count > 0);
    }

    private static bool EndsWithEmittableODataSegment(string pathTemplate) =>
        pathTemplate.Split('/', StringSplitOptions.RemoveEmptyEntries) is { Length: > 0 } parts
        && Naming.IsSupportedODataSegment(parts[^1]);

    private static bool EndsWithSegment(string pathTemplate, string segment) =>
        pathTemplate.Split('/', StringSplitOptions.RemoveEmptyEntries) is { Length: > 0 } parts
        && string.Equals(parts[^1], segment, StringComparison.Ordinal);

    private static bool HasUnsupportedODataSegment(string pathTemplate) =>
        pathTemplate.Split('/', StringSplitOptions.RemoveEmptyEntries)
            .Any(segment => segment.StartsWith('$') && !Naming.IsSupportedODataSegment(segment));

    private static bool HasCallSegment(string pathTemplate) =>
        pathTemplate.Split('/', StringSplitOptions.RemoveEmptyEntries)
            .Any(segment => segment.Contains('(', StringComparison.Ordinal));

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

    // Emits one OData action or function. Both resolve the same three facts — which kiota method
    // carries the call, what it returns, and whether it takes a generated request body — from
    // the operation's own schemas; the difference between them is the HTTP verb and that only an
    // action has a body.
    private string? EmitOperationCall(CmdletNaming naming, EmitContext ctx, OpenApiOperation operation,
        OperationKind kind, IReadOnlyList<string> queryParams, string pathTemplate)
    {
        var isAction = kind == OperationKind.Action;
        var httpVerb = isAction ? "POST" : "GET";

        // OData parameter aliases ("doesUserHaveAccess(userId='@userId')") pass their values as
        // query options rather than in the path, a binding model none of the emitted shapes
        // cover, and kiota's member name for the quoted form is irregular
        // (GetAllRecordingsuserIdUserIdWithStartDateTime...). 13 v1.0 operations use them, 5 of
        // which the published SDK ships; they are reported rather than emitted against a guessed
        // name. See docs/edge-cases/action-function-edge-cases.md.
        if (naming.NormalizedPath.Contains('@', StringComparison.Ordinal))
        {
            LogSkippedUnsupportedOperation(httpVerb, naming.NormalizedPath, "OData parameter-alias arguments (@name), not generated yet");
            return null;
        }

        // Arguments are bound for the operation's own segment. A route that calls a
        // parameterized function part-way along (".../columns/itemAt(index={index})/dataBodyRange")
        // would need the intermediate call's arguments too, and emitting it without them leaves
        // {index} unexpanded in the request URL — a cmdlet that cannot work. Refused rather than
        // emitted broken; supporting it means binding every intermediate call's arguments.
        if (HasParameterizedIntermediateSegment(pathTemplate))
        {
            LogSkippedUnsupportedOperation(httpVerb, naming.NormalizedPath, "route calls a parameterized function before its final segment, whose arguments cannot be bound");
            return null;
        }

        if (!TryResolveOperationReturnType(operation, ctx, naming, isAction, out var returnType, out var methodName, out var returnsStream))
        {
            LogSkippedUnsupportedOperation(httpVerb, naming.BuilderExpression, "response schema is neither a resolvable entity nor a value-wrapping response");
            return null;
        }

        if (!isAction)
            return CmdletEmitter.EmitFunction(naming, ctx, new CmdletEmitter.CallPlan(methodName, returnType, BodyTypeName: null, returnsStream), queryParams.ToHashSet());

        // Action parameters live in an inline "action parameters" object that kiota generates as
        // a per-operation <Member>PostRequestBody class; there is no named entity schema to
        // resolve, so the type name is predicted from the route the same way kiota builds it.
        var bodySchema = TryGetRequestJsonSchema(operation);
        var bodyType = bodySchema is null
            ? null
            : $"global::{ctx.ClientNamespace}.{naming.OperationTypeNamespace}.{naming.OperationTypeName}PostRequestBody";
        var (scalars, complex, untyped) = bodySchema is null
            ? ([], [], [])
            : BindBodyProperties(bodySchema, ctx, naming, bodyType!);

        return CmdletEmitter.EmitAction(naming, ctx, new CmdletEmitter.CallPlan(methodName, returnType, bodyType, returnsStream), scalars, complex, untyped);
    }

    // Resolves what a call returns and which kiota method returns it. Three shapes occur, and
    // kiota names the method from the shape: a response referencing an entity comes back from
    // the plain PostAsync/GetAsync; a response wrapping its payload in a "value" property comes
    // back from a dedicated …As<Member><Verb>ResponseAsync (the plain overload beside it returns
    // a type kiota marks [Obsolete]); no response body at all means the method returns Task.
    private bool TryResolveOperationReturnType(OpenApiOperation operation, EmitContext ctx, CmdletNaming naming,
        bool isAction, out string? returnType, out string methodName, out bool returnsStream)
    {
        returnType = null;
        returnsStream = false;
        var httpVerb = isAction ? "Post" : "Get";
        methodName = httpVerb + "Async";

        // A byte response: kiota types a binary schema as Stream from the ordinary Post/GetAsync.
        // The Intune reporting surface is almost all of this shape.
        if (HasBinarySuccessContent(operation))
        {
            returnType = "System.IO.Stream";
            returnsStream = true;
            return true;
        }

        var responseSchema = TryGetSuccessJsonSchema(operation);
        if (responseSchema is null)
            // No response body: kiota emits a plain Task-returning method. Actions that only act
            // (revoke, send, restart) are the largest single response shape in the corpus.
            return true;

        responseSchema = UnwrapNullableUnion(responseSchema);

        // A referenced entity is returned as that model, even when the entity itself happens to
        // have a "value" member — microsoft.graph.workbookFunctionResult does, and treating it
        // as a wrapper made every workbook function ask kiota for a per-operation response class
        // it never generates. Only an INLINE object whose payload hangs off "value" gets one.
        if (TryResolveEntityTypeName(responseSchema, ctx.ModelsNamespace, out var entityType))
        {
            returnType = entityType;
            return true;
        }

        if (FindProperty(responseSchema, "value") is not null)
        {
            returnType = $"global::{ctx.ClientNamespace}.{naming.OperationTypeNamespace}.{naming.OperationTypeName}{httpVerb}Response";
            methodName = $"{httpVerb}As{naming.OperationTypeName}{httpVerb}ResponseAsync";
            return true;
        }

        return false;
    }

    // The Graph docs express "entity or null" as anyOf[$ref, {type: object, nullable: true}].
    // That is a nullability annotation, not a choice of types, and kiota resolves it to the
    // referenced entity; unwrapping keeps a real union (which the classifier reports) distinct
    // from this encoding.
    private static IOpenApiSchema UnwrapNullableUnion(IOpenApiSchema schema)
    {
        foreach (var union in new[] { schema.AnyOf, schema.OneOf })
        {
            if (union is null || union.Count == 0)
                continue;
            var referenced = union.Where(branch => branch.GetReferenceId() is not null).ToList();
            if (referenced.Count == 1)
                return referenced[0];
        }
        return schema;
    }

    // A /$ref operation other than DELETE. GET returns the reference URLs; POST and PUT send a
    // referenceCreate body and return nothing, which is the action shape (body in, no output)
    // rather than the New shape (body in, entity out).
    private string? EmitReferenceOperation(CmdletNaming naming, EmitContext ctx, OpenApiOperation operation,
        HttpMethod httpMethod, IReadOnlyList<string> queryParams)
    {
        if (httpMethod == HttpMethod.Get)
        {
            // A collection navigation's $ref lists reference URLs, which kiota types as a
            // StringCollectionResponse; a single-valued navigation's $ref returns the one URL as
            // a plain string. The response schema says which — a "value" array means the former.
            var refResponse = TryGetSuccessJsonSchema(operation);
            var isCollection = refResponse is not null && FindProperty(refResponse, "value") is not null;
            return isCollection
                ? CmdletEmitter.EmitListGet(naming, ctx, "string",
                    $"{ctx.ModelsNamespace}.StringCollectionResponse", queryParams.ToHashSet())
                : CmdletEmitter.EmitScalarGet(naming, ctx, "string", queryParams.ToHashSet());
        }

        if (httpMethod != HttpMethod.Post && httpMethod != HttpMethod.Put)
            return null;

        var bodySchema = TryGetRequestJsonSchema(operation);
        if (bodySchema is null || !TryResolveEntityTypeName(bodySchema, ctx.ModelsNamespace, out var bodyType))
            return null;
        var (scalars, complex, untyped) = BindBodyProperties(bodySchema, ctx, naming, bodyType);
        var method = httpMethod == HttpMethod.Post ? "PostAsync" : "PutAsync";
        return CmdletEmitter.EmitAction(naming, ctx,
            new CmdletEmitter.CallPlan(method, ReturnTypeName: null, BodyTypeName: bodyType),
            scalars, complex, untyped);
    }

    // PUT replaces a resource outright. Two shapes occur: a JSON body naming an entity (the
    // synchronization and secrets endpoints), which is the PATCH shape with PutAsync in place of
    // PatchAsync and no re-fetch, and a binary body (logos, uploaded content), which kiota types
    // as Stream and which takes -InFile like any other content write.
    private string? EmitSetFor(CmdletNaming naming, EmitContext ctx, OpenApiOperation operation)
    {
        if (HasNonJsonRequestContent(operation))
        {
            return TryResolveOperationReturnType(operation, ctx, naming, isAction: false,
                    out var uploadReturn, out _, out var uploadIsStream) && uploadReturn is not null
                ? CmdletEmitter.EmitContentSet(naming, ctx, uploadReturn, uploadIsStream)
                : null;
        }

        var bodySchema = TryGetRequestJsonSchema(operation);
        if (bodySchema is null)
            return null;
        if (!TryResolveEntityTypeName(bodySchema, ctx.ModelsNamespace, out var entityType))
            return null;
        var (properties, complex, untyped) = BindBodyProperties(bodySchema, ctx, naming, entityType);
        return CmdletEmitter.EmitUpdate(naming, ctx, entityType, properties, complex, untyped,
            reFetchAfterUpdate: false, httpMethodName: "PutAsync");
    }

    // True when the request body is declared only as a non-JSON media type, which kiota types as
    // a Stream parameter rather than a model.
    private static bool HasNonJsonRequestContent(OpenApiOperation operation)
    {
        var content = operation.RequestBody?.Content;
        if (content is null || content.Count == 0)
            return false;
        return !content.Keys.Any(contentType =>
            contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase)
            || contentType.EndsWith("+json", StringComparison.OrdinalIgnoreCase));
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
        var (properties, complex, untyped) = BindBodyProperties(bodySchema, ctx, naming, entityType);
        return CmdletEmitter.EmitNew(naming, ctx, entityType, properties, complex, untyped);
    }

    private string? EmitUpdateFor(CmdletNaming naming, EmitContext ctx, OpenApiOperation operation, bool canReFetch)
    {
        // "application/json" is an intentional, Graph-scoped assumption (see EmitNewFor).
        var bodySchema = TryGetRequestJsonSchema(operation);
        if (bodySchema is null)
            return null;
        if (!TryResolveEntityTypeName(bodySchema, ctx.ModelsNamespace, out var entityType))
            return null;
        var (properties, complex, untyped) = BindBodyProperties(bodySchema, ctx, naming, entityType);
        return CmdletEmitter.EmitUpdate(naming, ctx, entityType, properties, complex, untyped, canReFetch);
    }

    // Classifies a request body and resolves each complex property's component-schema key to
    // the kiota CLR type name, reusing ResolveModelTypeName so reserved-name renames and
    // sub-namespace moves are applied in exactly one place. A property whose reference does not
    // resolve is dropped with a diagnostic rather than emitted against a guessed type name,
    // which would fail the module compile.
    private (IReadOnlyList<CmdletProperty> Scalars, IReadOnlyList<ComplexParameter> Complex, IReadOnlyList<UntypedParameter> Untyped) BindBodyProperties(
        IOpenApiSchema bodySchema, EmitContext ctx, CmdletNaming naming, string entityType)
    {
        var classified = SchemaProperties.Classify(bodySchema, ResolveComponentSchema);
        var (scalars, complex, untyped) = SchemaProperties.ResolveParameterNameCollisions(
            classified.Scalars, classified.Complex, classified.Untyped, naming.PathParamNames);

        // C# forbids a member sharing its enclosing type's name, so kiota suffixes such a
        // property with "Prop": microsoft.graph.list's own "list" property generates as
        // List.ListProp (verified in a generated Files client). The assignment target has to
        // match the member kiota emitted, or the module does not compile.
        var enclosingTypeName = entityType[(entityType.LastIndexOf('.') + 1)..];
        scalars = [.. scalars.Select(p => p.PascalName == enclosingTypeName ? p with { PascalName = p.PascalName + "Prop" } : p)];
        complex = [.. complex.Select(p => p.PascalName == enclosingTypeName ? p with { PascalName = p.PascalName + "Prop" } : p)];
        untyped = [.. untyped.Select(p => p.PascalName == enclosingTypeName ? p with { PascalName = p.PascalName + "Prop" } : p)];

        foreach (var skipped in classified.Unsupported)
            LogSkippedBodyProperty(naming.Noun, skipped.OpenApiName, skipped.Shape.ToString(), skipped.IsRequired);

        // Named so an external reconciliation can tell a policy exclusion from an omission
        // without re-deriving the policy from the spec.
        foreach (var dropped in classified.Excluded)
            LogExcludedBodyProperty(naming.Noun, dropped.OpenApiName, dropped.Policy.ToString());

        // Totals for the run's reconciliation line: every classified property must end up in
        // exactly one of these buckets, so a shape that silently fell through the classifier
        // would show up as a mismatch at Graph scale, not just in the unit test.
        propertiesSeenCount += classified.PropertiesSeen;
        boundScalarCount += classified.Scalars.Count;
        boundComplexCount += classified.Complex.Count;
        boundUntypedCount += classified.Untyped.Count;
        unsupportedPropertyCount += classified.Unsupported.Count;
        excludedPropertyCount += classified.Excluded.Count;

        var parameters = new List<ComplexParameter>(complex.Count);
        foreach (var property in complex)
        {
            parameters.Add(new ComplexParameter(
                property.PascalName,
                property.ParameterName,
                ResolveModelTypeName(property.ReferenceId, ctx.ModelsNamespace, modelSubNamespaces, kiotaReservedRenames),
                property.IsArray,
                property.IsEnum));
        }
        var untypedParameters = untyped.Select(p => new UntypedParameter(p.PascalName, p.ParameterName)).ToList();
        return (scalars, parameters, untypedParameters);
    }

    private IOpenApiSchema? ResolveComponentSchema(string referenceId) =>
        document.Components?.Schemas?.TryGetValue(referenceId, out var schema) == true ? schema : null;

    // A success response kiota types as Stream rather than a model. Two independent signals, both
    // needed: the documents are not consistent about which they use.
    //
    //   * an explicit binary schema (`type: string, format: binary`) — /applications/{id}/logo
    //   * a media type that carries neither JSON nor text — the reports functions declare
    //     `application/octet-stream` with a bare `type: object` and no format
    //
    // Neither alone suffices. Testing only the format misses the reports surface (which then
    // emits `typeof()` and fails to compile); testing only "not JSON" wrongly claims a
    // `text/plain` scalar, which is a string, not a download.
    private static bool HasBinarySuccessContent(OpenApiOperation operation)
    {
        if (operation.Responses is null)
            return false;
        foreach (var key in new[] { "2XX", "200", "201" })
        {
            if (!operation.Responses.TryGetValue(key, out var response) || response?.Content is null)
                continue;
            foreach (var (contentType, media) in response.Content)
            {
                if (string.Equals(media?.Schema?.Format, "binary", StringComparison.OrdinalIgnoreCase))
                    return true;
                if (contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase)
                    || contentType.EndsWith("+json", StringComparison.OrdinalIgnoreCase)
                    || contentType.StartsWith("text/", StringComparison.OrdinalIgnoreCase))
                    continue;
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
