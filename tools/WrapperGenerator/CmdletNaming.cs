using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace WrapperGenerator;

public sealed record HeaderParam(string RawName, string PsName);

// A PowerShell verb as the [Cmdlet] attribute needs it: the Verbs* class that declares it
// (Update lives in VerbsData, the rest in VerbsCommon) and the verb name itself. Kept as a
// closed set of instances rather than raw strings so a typo cannot invent a verb.
public sealed record PsVerb(string AttributeClass, string Name)
{
    public static readonly PsVerb Get = new("VerbsCommon", "Get");
    public static readonly PsVerb New = new("VerbsCommon", "New");
    public static readonly PsVerb Update = new("VerbsData", "Update");
    public static readonly PsVerb Set = new("VerbsCommon", "Set");
    public static readonly PsVerb Remove = new("VerbsCommon", "Remove");
    // The approved verb for "run this operation", used for every OData action. The published
    // SDK maps many individual actions onto more specific approved verbs (sendMail ships as
    // Send-, checkMemberGroups as Confirm-); those come from the oracle-derived name data,
    // because the mapping is AutoRest's per-operation judgment, not a rule the spec carries.
    public static readonly PsVerb Invoke = new("VerbsLifecycle", "Invoke");

    // Every verb the published v1.0 SDK uses, with the Verbs* class that declares it. The set is
    // the oracle's own (45 distinct verbs, all of them PowerShell-approved) and each entry's
    // class is the Group that Get-Verb reports for it, so an oracle-derived rename can carry any
    // verb the SDK actually ships. A verb outside this set is rejected rather than guessed at:
    // emitting the wrong Verbs* class is a compile error, and inventing one would ship an
    // unapproved verb.
    private static readonly Dictionary<string, PsVerb> ApprovedVerbs = new(StringComparer.Ordinal)
    {
        ["Add"] = new("VerbsCommon", "Add"),
        ["Clear"] = new("VerbsCommon", "Clear"),
        ["Close"] = new("VerbsCommon", "Close"),
        ["Complete"] = new("VerbsLifecycle", "Complete"),
        ["Confirm"] = new("VerbsLifecycle", "Confirm"),
        ["Copy"] = new("VerbsCommon", "Copy"),
        ["Disable"] = new("VerbsLifecycle", "Disable"),
        ["Disconnect"] = new("VerbsCommunications", "Disconnect"),
        ["Enable"] = new("VerbsLifecycle", "Enable"),
        ["Export"] = new("VerbsData", "Export"),
        ["Find"] = new("VerbsCommon", "Find"),
        ["Get"] = new("VerbsCommon", "Get"),
        ["Grant"] = new("VerbsSecurity", "Grant"),
        ["Hide"] = new("VerbsCommon", "Hide"),
        ["Import"] = new("VerbsData", "Import"),
        ["Initialize"] = new("VerbsData", "Initialize"),
        ["Invoke"] = new("VerbsLifecycle", "Invoke"),
        ["Join"] = new("VerbsCommon", "Join"),
        ["Lock"] = new("VerbsCommon", "Lock"),
        ["Merge"] = new("VerbsData", "Merge"),
        ["Move"] = new("VerbsCommon", "Move"),
        ["New"] = new("VerbsCommon", "New"),
        ["Publish"] = new("VerbsData", "Publish"),
        ["Remove"] = new("VerbsCommon", "Remove"),
        ["Rename"] = new("VerbsCommon", "Rename"),
        ["Request"] = new("VerbsLifecycle", "Request"),
        ["Reset"] = new("VerbsCommon", "Reset"),
        ["Resize"] = new("VerbsCommon", "Resize"),
        ["Restart"] = new("VerbsLifecycle", "Restart"),
        ["Restore"] = new("VerbsData", "Restore"),
        ["Resume"] = new("VerbsLifecycle", "Resume"),
        ["Revoke"] = new("VerbsSecurity", "Revoke"),
        ["Search"] = new("VerbsCommon", "Search"),
        ["Send"] = new("VerbsCommunications", "Send"),
        ["Set"] = new("VerbsCommon", "Set"),
        ["Skip"] = new("VerbsCommon", "Skip"),
        ["Start"] = new("VerbsLifecycle", "Start"),
        ["Stop"] = new("VerbsLifecycle", "Stop"),
        ["Submit"] = new("VerbsLifecycle", "Submit"),
        ["Suspend"] = new("VerbsLifecycle", "Suspend"),
        ["Sync"] = new("VerbsData", "Sync"),
        ["Test"] = new("VerbsDiagnostic", "Test"),
        ["Undo"] = new("VerbsCommon", "Undo"),
        ["Unpublish"] = new("VerbsData", "Unpublish"),
        ["Update"] = new("VerbsData", "Update"),
    };

    public static PsVerb FromApprovedName(string verbName)
    {
        ArgumentNullException.ThrowIfNull(verbName);
        return ApprovedVerbs.TryGetValue(verbName, out var verb)
            ? verb
            : throw new NotSupportedException(
                $"'{verbName}' is not in the approved-verb set derived from the published SDK. " +
                "Add it with its Get-Verb group before deriving a rename that uses it.");
    }
}

// One inline parameter of an OData function segment, e.g. StartDateTime in
// reminderView(StartDateTime='{StartDateTime}'). PsName is the cmdlet parameter; TemplateName
// is the URL-template placeholder the value has to be bound to.
public sealed record FunctionParam(string TemplateName, string PsName);

public sealed record CmdletNaming(
    string VerbsClass,
    string VerbName,
    string Noun,
    string ClassName,
    IReadOnlyList<string> PathParamNames,
    string BuilderExpression,
    IReadOnlyList<HeaderParam> HeaderParams,
    OperationKind Kind = OperationKind.Resource,
    // Inline function parameters, in path order; empty unless the operation is a
    // parameterized function.
    IReadOnlyList<FunctionParam>? FunctionParams = null,
    // The kiota namespace, relative to the client namespace, holding the types kiota generates
    // for this operation (its request-body and wrapped-response classes): every fixed segment
    // Pascal-cased and every {id} segment replaced by "Item", e.g. "Users.Item.AssignLicense".
    // Empty for a resource operation, which has no per-operation types.
    string OperationTypeNamespace = "",
    // The kiota builder member for the action/function segment, and the last segment of the
    // namespace its generated types live in.
    string OperationMemberName = "",
    // The prefix kiota gives those generated types ("AssignLicense" ->
    // AssignLicensePostRequestBody). It differs from OperationMemberName for a
    // namespace-qualified operation: the builder and namespace keep the qualifier
    // (MicrosoftGraphSecurityMoveAlerts) while the types drop it (MoveAlertsPostRequestBody).
    string OperationTypeName = "",
    // The {id} segments as the URL template spells them ("user-id"), parallel to
    // PathParamNames. A parameterized function is built by populating kiota's path-parameter
    // dictionary, which is keyed by these template names, not by the cmdlet parameter names.
    IReadOnlyList<string>? PathParamTemplateNames = null,
    // The operation's route, normalized the way NamingOverrides keys its data. Diagnostics
    // report it rather than leaving the route to be reconstructed from the builder expression:
    // that reconstruction is lossy for a function (the builder member keeps the argument names
    // but not the OData argument syntax) and wrong for a namespace-qualified action (kiota
    // keeps the qualifier, the route does not), and a route that reconstructs wrongly resolves
    // against the wrong oracle row.
    string NormalizedPath = "",
    // The operation's route and method exactly as the spec declares them, qualifier and {id}
    // template names intact. NormalizedPath cannot serve here: it is the key NamingOverrides
    // indexes by, so it is lower-cased and collapses every {id} to {}. These are emitted as a
    // [GraphRoute] attribute so verification tooling reads the operation's identity out of the
    // compiled assembly instead of reconstructing it from the builder expression.
    string SourcePath = "",
    string SourceMethod = "")
{
    public IReadOnlyList<FunctionParam> FunctionParameters => FunctionParams ?? [];

    public IReadOnlyList<string> PathParamTemplates => PathParamTemplateNames ?? [];
}

public static class Naming
{
    // GET->Get, POST->New, PATCH->Update, PUT->Set, DELETE->Remove (design spec section 7).
    // HttpMethod's own equality is case-insensitive, so "get"/"GET" resolve identically.
    private static readonly Dictionary<HttpMethod, PsVerb> VerbMap = new()
    {
        [HttpMethod.Get] = PsVerb.Get,
        [HttpMethod.Post] = PsVerb.New,
        [HttpMethod.Patch] = PsVerb.Update,
        [HttpMethod.Put] = PsVerb.Set,
        [HttpMethod.Delete] = PsVerb.Remove,
    };

    public static CmdletNaming Resolve(OperationInfo operation, GeneratorConfig? config = null)
    {
        ArgumentNullException.ThrowIfNull(operation);
        // An action is a call, not a create, so POST does not mean New here. A function is a
        // read and keeps Get, which is also what the HTTP method would have given it.
        var verb = operation.Kind switch
        {
            OperationKind.Action => PsVerb.Invoke,
            OperationKind.Function => PsVerb.Get,
            _ => VerbMap.TryGetValue(operation.HttpMethod, out var mapped)
                ? mapped
                : throw new NotSupportedException($"No cmdlet verb mapping for HTTP method '{operation.HttpMethod}'."),
        };

        // The published SDK picks an action's verb per operation rather than from the method, so
        // where the oracle-derived data records one it replaces the structural default.
        if (NamingOverrides.TryGetOverriddenVerb(operation.HttpMethod, operation.Path, config) is { } publishedVerb)
            verb = PsVerb.FromApprovedName(publishedVerb);

        // The noun comes from the URL path, not the operationId. OperationIds keep whatever
        // plurality the spec author chose, while the published SDK names follow the path:
        // GET /users/{id}/messages is Get-MgUserMessage. The few hand-tuned exceptions the
        // published SDK carries are mirrored as data in NamingOverrides, never as code here.
        var noun = GeneratorConstants.NounPrefix + NamingOverrides.ApplyNounOverrides(operation.HttpMethod, operation.Path, BuildNounFromPath(operation.Path, operation.Kind), config);

        // A list GET (/users/{id}/messages) and its item GET (/users/{id}/messages/{message-id})
        // get the same noun on purpose. PowerShellWrapperGenerationService pairs them into one
        // public Get-MgX dispatcher cmdlet; the two real implementations get suffixed names via
        // WithSuffix below.
        //
        // The "Command" suffix follows PowerShell's own convention for cmdlet classes — the
        // PowerShell codebase names the class behind Get-ChildItem "GetChildItemCommand" — and
        // also keeps the generated class name from colliding with the Kiota model type of the
        // same noun (a GetMgUserCommand class alongside the User model).
        var className = $"{verb.Name}{noun}Command";

        var pathParamNames = ExtractPathParamNames(operation.Path);
        var builderExpression = BuildBuilderExpression(operation.Path, pathParamNames);
        var headerParams = (operation.HeaderParams ?? [])
            .Select(raw => new HeaderParam(raw, raw.ToPascalCase('-')))
            .ToList();

        var normalizedPath = NamingOverrides.NormalizePathTemplate(operation.Path);
        if (operation.Kind == OperationKind.Resource)
            return new CmdletNaming(verb.AttributeClass, verb.Name, noun, className, pathParamNames, builderExpression, headerParams,
                NormalizedPath: normalizedPath, SourcePath: operation.Path, SourceMethod: operation.HttpMethod.Method);

        var call = ParseOperationSegment(LastFixedSegment(operation.Path));
        return new CmdletNaming(verb.AttributeClass, verb.Name, noun, className, pathParamNames, builderExpression, headerParams,
            operation.Kind,
            call.Parameters,
            BuildOperationTypeNamespace(operation.Path),
            call.MemberName,
            call.NounPart,
            ExtractPathParamTemplateNames(operation.Path),
            normalizedPath,
            operation.Path,
            operation.HttpMethod.Method);
    }

    // The raw "{user-id}" names, in path order and parallel to ExtractPathParamNames.
    private static List<string> ExtractPathParamTemplateNames(string path)
    {
        var names = new List<string>();
        foreach (var segment in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (segment.StartsWith('{') && segment.EndsWith('}'))
                names.Add(segment[1..^1]);
        }
        return names;
    }

    // The kiota namespace holding an operation's generated types, relative to the client
    // namespace. Kiota mirrors the route: every fixed segment Pascal-cased, every {id} segment
    // collapsed to "Item" ("/users/{user-id}/messages/{message-id}/copy" ->
    // "Users.Item.Messages.Item.Copy"). Verified against generated clients; a wrong prediction
    // is a compile error in the module, not a silent mis-emission.
    private static string BuildOperationTypeNamespace(string path)
    {
        var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries)
            .Select(segment => segment.StartsWith('{') && segment.EndsWith('}')
                ? "Item"
                : AvoidReservedNamespace(ParseOperationSegment(segment).MemberName));
        return string.Join('.', parts);
    }

    // Kiota renames a namespace whose name would collide with a BCL type by appending
    // "Namespace" (/directory/... generates under DirectoryNamespace). The set is every such
    // rename observed across the generated clients for all 38 v1.0 modules; a name kiota starts
    // renaming that is missing here surfaces as a module compile error, not a silent mis-emit.
    private static readonly HashSet<string> ReservedNamespaceNames = new(StringComparer.Ordinal)
    {
        "Char", "Convert", "Date", "Decimal", "Directory", "Environment", "File", "Range", "Task", "Type",
    };

    private static string AvoidReservedNamespace(string segment) =>
        ReservedNamespaceNames.Contains(segment) ? segment + "Namespace" : segment;

    private static string LastFixedSegment(string path) =>
        path.Split('/', StringSplitOptions.RemoveEmptyEntries)
            .LastOrDefault(s => !(s.StartsWith('{') && s.EndsWith('}'))) ?? string.Empty;

    // Names one of the two internal cmdlets behind a paired GET dispatcher, e.g.
    // Get-MgUserMessage_List. The public dispatcher keeps the bare noun.
    public static CmdletNaming WithSuffix(CmdletNaming naming, string suffix)
    {
        ArgumentNullException.ThrowIfNull(naming);
        return naming with
        {
            Noun = naming.Noun + suffix,
            ClassName = $"{naming.VerbName}{naming.Noun}{suffix}Command",
        };
    }

    // Pascal-cases and singularizes every fixed path segment, then joins them. Two kinds of
    // repetition are dropped, because the published SDK drops them:
    //   /sites/{id}/sites                  -> Site (not SiteSite)
    //   /domains/{id}/domainNameReferences -> DomainNameReference (the shared word "Domain"
    //                                         appears once, matching Get-MgDomainNameReference)
    // An OData cast segment like graph.user becomes AsUser (TryBuildCastSegmentNoun), matching
    // Get-MgGroupOwnerAsUser.
    private static string BuildNounFromPath(string path, OperationKind kind = OperationKind.Resource)
    {
        var fixedSegments = path.Split('/', StringSplitOptions.RemoveEmptyEntries)
            .Where(s => !(s.StartsWith('{') && s.EndsWith('}')))
            .ToList();
        // The trailing segment of an action or function names the operation, not a resource, so
        // it is appended verbatim rather than run through the resource rules. Both of those
        // rules corrupt an operation name: singularization would merge the distinct workbook
        // functions averageIfs and averageIf onto one cmdlet, and the adjacent-duplicate strip
        // (which exists to keep /domains/{id}/domainNameReferences from repeating "Domain")
        // would erase the leading word of .../replies/replyWithQuote, colliding it with the
        // collection-bound .../messages/replyWithQuote that the published SDK ships separately.
        var operationSegmentIndex = kind == OperationKind.Resource ? -1 : fixedSegments.Count - 1;

        var parts = new List<string>();
        var fixedIndex = -1;
        // Where the most recent cast segment landed, so a directly following /$count can be
        // ordered against it. -2 keeps the "immediately after" test false before any cast.
        var lastCastIndex = -2;
        foreach (var segment in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (segment.StartsWith('{') && segment.EndsWith('}'))
                continue;
            fixedIndex++;

            // An OData $-segment contributes the suffix the published SDK gives it, verbatim: it
            // names the shape of the request, not a resource, so the resource rules do not apply.
            if (EmittableODataSegments.TryGetValue(segment, out var odataSegment))
            {
                // A /$count directly after a cast counts the cast-filtered collection, and the
                // published SDK orders the noun that way round: /memberOf/graph.group/$count ships
                // as ...MemberOfCountAsGroup, so the cast suffix trails the whole noun. Only a
                // directly adjacent cast moves — with any segment in between the cast keeps its
                // place (...AsAndroidLobAppContentVersionCount). Scoped to $count because that is
                // the only $-segment observed after a cast: v1.0 has 131 such routes and none for
                // $ref or $value, so their ordering is unobserved rather than decided here.
                if (segment == "$count" && lastCastIndex == fixedIndex - 1)
                    parts.Insert(parts.Count - 1, odataSegment.NounPart);
                else
                    parts.Add(odataSegment.NounPart);
                continue;
            }

            if (fixedIndex == operationSegmentIndex)
            {
                parts.Add(ParseOperationSegment(segment).NounPart);
                continue;
            }

            if (TryBuildCastSegmentNoun(segment) is { } castNounPart)
            {
                parts.Add(castNounPart);
                lastCastIndex = fixedIndex;
                continue;
            }

            // A parameterized function contributes kiota's own member name, arguments included
            // ("columnsAfter(count={count})" -> "ColumnsAfterWithCount"). The spec routinely
            // publishes a function at several arities under one parent — 340 operations in 167
            // such groups across v1.0, most of them the workbook range functions — and naming
            // them all after the bare function would make every group collide. Distinguishing
            // them by arity is what kiota already does, so the two agree by construction; where
            // an arity actually ships, the oracle-derived rename supplies its published noun.
            var part = Singularizer.SingularizeSegment(ParseOperationSegment(segment).MemberName);
            if (parts.Count > 0)
            {
                var previous = parts[^1];
                if (string.Equals(previous, part, StringComparison.Ordinal))
                    continue;
                var boundaryWord = Singularizer.TrailingWord(previous);
                if (string.Equals(part, boundaryWord, StringComparison.Ordinal))
                    continue;
                if (part.StartsWith(boundaryWord, StringComparison.Ordinal) && part.Length > boundaryWord.Length)
                    part = part[boundaryWord.Length..];
            }
            parts.Add(part);
        }
        return string.Concat(parts);
    }

    // One parsed action/function path segment: the bare OData operation name, the kiota builder
    // member it becomes, the part it contributes to the cmdlet noun, and its inline parameters
    // in path order. MemberName and NounPart differ for a namespace-qualified operation, where
    // kiota keeps the qualifier and the noun drops it.
    public sealed record OperationSegment(string OperationName, string MemberName, string NounPart, IReadOnlyList<FunctionParam> Parameters);

    // Parses a path segment as an OData operation call. "assignLicense" carries no parameters
    // and becomes the AssignLicense builder property; "reminderView(StartDateTime='{StartDateTime}',
    // EndDateTime='{EndDateTime}')" becomes the ReminderViewWithStartDateTimeWithEndDateTime
    // builder method, kiota's name for a parameterized function (one "With<Param>" per
    // parameter, in path order). A segment without parentheses parses as a bare name, so the
    // same helper serves every segment of the route.
    public static OperationSegment ParseOperationSegment(string segment)
    {
        ArgumentNullException.ThrowIfNull(segment);
        var open = segment.IndexOf('(', StringComparison.Ordinal);
        if (open < 0)
            return new OperationSegment(BareOperationName(segment), ToMemberName(segment),
                BareOperationName(segment).ToFirstCharacterUpperCase(), []);

        var name = segment[..open];
        var close = segment.LastIndexOf(')');
        var argumentList = close > open ? segment[(open + 1)..close] : string.Empty;

        var parameters = new List<FunctionParam>();
        foreach (var argument in argumentList.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            // Each argument is "Name={Placeholder}" or "Name='{Placeholder}'". The PLACEHOLDER
            // names the value: it is the key the URL template expands, and the name kiota builds
            // its member from. The two are usually spelled the same, but not always —
            // "column={column1}" generates ColumnWithColumn1 and expands {column1} — so taking
            // the left-hand side would both miss the member name and leave the value unbound.
            var equals = argument.IndexOf('=', StringComparison.Ordinal);
            var value = (equals < 0 ? argument : argument[(equals + 1)..]).Trim().Trim('\'');
            var rawName = value.StartsWith('{') && value.EndsWith('}')
                ? value[1..^1]
                : (equals < 0 ? argument : argument[..equals]).Trim();
            if (rawName.Length == 0)
                continue;
            parameters.Add(new FunctionParam(rawName, rawName.ToPascalCase('-')));
        }

        var arity = string.Concat(parameters.Select(p => "With" + p.PsName));
        return new OperationSegment(BareOperationName(name), ToMemberName(name) + arity,
            BareOperationName(name).ToFirstCharacterUpperCase() + arity, parameters);
    }

    // An OData operation may be qualified by the namespace that declares it
    // ("microsoft.graph.security.applyHold"). The qualifier is type information, not part of the
    // operation's name — the published SDK's own route for that operation is the bare
    // "/applyHold" — so the noun is built from the last segment only.
    private static string BareOperationName(string name)
    {
        var lastDot = name.LastIndexOf('.');
        return lastDot < 0 ? name : name[(lastDot + 1)..];
    }

    // Kiota keeps the whole qualified name and concatenates it into one builder member
    // ("microsoft.graph.security.applyHold" -> MicrosoftGraphSecurityApplyHold), which is also
    // the namespace its per-operation types live in, so this form has to survive intact even
    // though the noun drops the qualifier.
    private static string ToMemberName(string name) =>
        string.Concat(name.Split('.', StringSplitOptions.RemoveEmptyEntries).Select(part => part.ToFirstCharacterUpperCase()));

    // The "As<Type>" noun part for an OData cast segment ("microsoft.graph.user", or
    // "graph.user" in the KiotaCompat specs), matching published names like
    // Get-MgGroupOwnerAsUser; null for a non-cast segment. The cast type name is singularized
    // like any other segment rather than assumed to be singular already.
    public static string? TryBuildCastSegmentNoun(string segment)
    {
        ArgumentNullException.ThrowIfNull(segment);
        var castType = segment.StartsWith("microsoft.graph.", StringComparison.OrdinalIgnoreCase)
            ? segment["microsoft.graph.".Length..]
            : segment.StartsWith("graph.", StringComparison.OrdinalIgnoreCase)
                ? segment["graph.".Length..]
                : null;
        return castType is null
            ? null
            : "As" + Singularizer.SingularizeSegment(castType.ToFirstCharacterUpperCase());
    }

    // The cmdlet parameter names for a path's {parameter} segments, in path order. Each raw
    // name is PascalCased on its hyphens: "{user-id}" -> "UserId", "{bookingBusiness-id}" ->
    // "BookingBusinessId". These become the cmdlet's mandatory positional parameters and the
    // indexer arguments in the builder expression.
    private static List<string> ExtractPathParamNames(string path)
    {
        var names = new List<string>();
        foreach (var segment in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (segment.StartsWith('{') && segment.EndsWith('}'))
                names.Add(segment[1..^1].ToPascalCase('-'));
        }
        return names;
    }

    // The Kiota request-builder chain for a path, returned as C# source text ready to append
    // after "client.": one property per fixed segment, one indexer per path parameter, e.g.
    // "/users/{user-id}/messages/{message-id}" -> "Users[UserId].Messages[MessageId]".
    private static string BuildBuilderExpression(string path, List<string> pathParamNames)
    {
        var expression = new System.Text.StringBuilder();
        var paramIndex = 0;
        var first = true;

        foreach (var segment in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (segment.StartsWith('{') && segment.EndsWith('}'))
            {
                expression.Append('[').Append(pathParamNames[paramIndex++]).Append(']');
            }
            else
            {
                if (!first)
                    expression.Append('.');
                expression.Append(ToCastAwareBuilderMemberName(segment));
            }
            first = false;
        }

        return expression.ToString();
    }

    // A fixed path segment becomes one Kiota request-builder member; the "cast-aware" part is
    // what the name is for. An OData cast segment carries dots ("microsoft.graph.user", or
    // "graph.user" in the KiotaCompat specs); Kiota maps it to a single member by upper-casing
    // each dot-separated part and concatenating, so "microsoft.graph.user" is the
    // "MicrosoftGraphUser" property, "graph.user" is "GraphUser" (verified against a generated
    // Kiota C# client). Emitting the raw segment would leave a stray dot ("Graph.user") —
    // invalid C# and not a real builder member. Non-cast segments have no dots and pass
    // through unchanged. NOTE: cast endpoints are not generated end to end yet (tracked
    // follow-up), so this keeps the expression a valid identifier chain until then.
    private static string ToCastAwareBuilderMemberName(string segment)
    {
        if (EmittableODataSegments.TryGetValue(segment, out var odataSegment))
            return odataSegment.BuilderMember;

        // ParseOperationSegment concatenates dot-separated parts exactly as the cast rule needs
        // ("graph.user" -> GraphUser), so it serves both a cast segment and a qualified
        // operation. Splitting on dots directly would keep a zero-argument function's literal
        // "()" in the member name and emit a call against a property.
        var call = ParseOperationSegment(segment);
        return call.Parameters.Count > 0 ? call.MemberName + "()" : AvoidRequestMethodClash(call.MemberName);
    }

    // What an OData $-segment is called on either side of the generator: the kiota builder member
    // it reads through, and the noun part the published SDK gives it.
    private sealed record ODataSegmentNames(string BuilderMember, string NounPart);

    // The OData $-segments the generator emits. Membership is the support test — a segment is in
    // this table only when both a name and an emitter exist for it, so a $-segment nothing can
    // emit stays out and keeps being skipped rather than falling through to the resource
    // emitters and producing a cmdlet that reads an entity from a call kiota types as int, a
    // reference collection, or a stream.
    //
    // Builder members are kiota's names without the "$": /$count is the Count property, /$ref is
    // Ref, /$value is Content (the folder is Value, the accessor is Content — verified on Groups'
    // photo builder). Noun parts are the published suffixes: Get-MgUserCount,
    // Get-MgApplicationOwnerByRef, Get-MgGroupPhotoContent.
    private static readonly Dictionary<string, ODataSegmentNames> EmittableODataSegments = new(StringComparer.Ordinal)
    {
        ["$count"] = new("Count", "Count"),
        ["$ref"] = new("Ref", "ByRef"),
        ["$value"] = new("Content", "Content"),
    };

    public static bool IsSupportedODataSegment(string segment)
    {
        ArgumentNullException.ThrowIfNull(segment);
        return EmittableODataSegments.ContainsKey(segment);
    }

    // Kiota renames a builder property whose name would clash with a request method the builder
    // declares: a /delete segment is exposed as DeletePath, not Delete. The rename is scoped to
    // the property — the generated namespace keeps the segment name
    // (…UsedRange.Delete.DeleteRequestBuilder DeletePath), and sibling segments that are not
    // method names (Clear, EntireColumn) are untouched.
    //
    // Only "delete" occurs: of the 9,116 distinct routes in the configured v1.0 specs, 24 carry a
    // /delete segment and none carries /get, /post, /patch, /put or /head. Mapping the other
    // method names would encode a prediction no spec exercises, so only the observed clash is
    // encoded; a new one appears as a module compile error rather than silently binding the
    // wrong member.
    private static string AvoidRequestMethodClash(string memberName) =>
        memberName == "Delete" ? "DeletePath" : memberName;

    // Whether a list GET and an item GET form a mergeable pair for the public Get-MgX
    // dispatcher: the item's path must extend the list's path by exactly one id, either
    // trailing (Users[UserId].Messages -> Users[UserId].Messages[MessageId]) or inserted
    // before a shared trailing OData cast (Owners.GraphUser -> Owners[Id].GraphUser). Callers
    // group by noun first, so this only decides the structural fit; a same-noun item that does
    // not extend the list is rejected.
    public static bool IsListItemPair(CmdletNaming list, CmdletNaming item)
    {
        ArgumentNullException.ThrowIfNull(list);
        ArgumentNullException.ThrowIfNull(item);
        if (item.PathParamNames.Count != list.PathParamNames.Count + 1
            || !item.PathParamNames.Take(list.PathParamNames.Count).SequenceEqual(list.PathParamNames))
            return false;

        if (item.BuilderExpression.StartsWith(list.BuilderExpression + "[", StringComparison.Ordinal))
            return true;

        // OData cast pair: the id inserts BEFORE the trailing cast member, not at the end
        // (owners/graph.user vs owners/{id}/graph.user builds Owners.GraphUser vs
        // Owners[Id].GraphUser). The published SDK ships these as one cmdlet, same as a
        // plain list/item pair; without this the two emit identical file names and collide.
        var listCast = TrailingCastMember(list.BuilderExpression);
        var itemCast = TrailingCastMember(item.BuilderExpression);
        if (listCast is null || itemCast is null || !string.Equals(listCast, itemCast, StringComparison.Ordinal))
            return false;

        var listStem = list.BuilderExpression[..^(listCast.Length + 1)];
        var itemStem = item.BuilderExpression[..^(itemCast.Length + 1)];
        if (!itemStem.StartsWith(listStem + "[", StringComparison.Ordinal) || !itemStem.EndsWith("]", StringComparison.Ordinal))
            return false;
        var indexer = itemStem[(listStem.Length + 1)..^1];
        return indexer.Length > 0 && !indexer.Contains('[') && !indexer.Contains('.');
    }

    // The kiota builder member for a trailing OData cast segment (GraphUser from
    // "graph.user", MicrosoftGraphUser from "microsoft.graph.user"); null when the
    // expression does not end in a cast.
    private static string? TrailingCastMember(string builderExpression)
    {
        var lastDot = builderExpression.LastIndexOf('.');
        if (lastDot < 0)
            return null;
        var member = builderExpression[(lastDot + 1)..];
        if (member.Contains('['))
            return null;
        if (member.StartsWith("MicrosoftGraph", StringComparison.Ordinal) && member.Length > 14 && char.IsUpper(member[14]))
            return member;
        if (member.StartsWith("Graph", StringComparison.Ordinal) && member.Length > 5 && char.IsUpper(member[5]))
            return member;
        return null;
    }
}
