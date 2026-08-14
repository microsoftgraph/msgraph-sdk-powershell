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
}

public sealed record CmdletNaming(
    string VerbsClass,
    string VerbName,
    string Noun,
    string ClassName,
    IReadOnlyList<string> PathParamNames,
    string BuilderExpression,
    IReadOnlyList<HeaderParam> HeaderParams);

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
        if (!VerbMap.TryGetValue(operation.HttpMethod, out var verb))
            throw new NotSupportedException($"No cmdlet verb mapping for HTTP method '{operation.HttpMethod}'.");

        // The noun comes from the URL path, not the operationId. OperationIds keep whatever
        // plurality the spec author chose, while the published SDK names follow the path:
        // GET /users/{id}/messages is Get-MgUserMessage. The few hand-tuned exceptions the
        // published SDK carries are mirrored as data in NamingOverrides, never as code here.
        var noun = GeneratorConstants.NounPrefix + NamingOverrides.ApplyNounOverrides(operation.HttpMethod, operation.Path, BuildNounFromPath(operation.Path), config);

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

        return new CmdletNaming(verb.AttributeClass, verb.Name, noun, className, pathParamNames, builderExpression, headerParams);
    }

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
    private static string BuildNounFromPath(string path)
    {
        var parts = new List<string>();
        foreach (var segment in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (segment.StartsWith('{') && segment.EndsWith('}'))
                continue;

            if (TryBuildCastSegmentNoun(segment) is { } castNounPart)
            {
                parts.Add(castNounPart);
                continue;
            }

            var part = Singularizer.SingularizeSegment(segment.ToFirstCharacterUpperCase());
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
    private static string ToCastAwareBuilderMemberName(string segment) =>
        segment.Contains('.', StringComparison.Ordinal)
            ? string.Concat(segment.Split('.', StringSplitOptions.RemoveEmptyEntries).Select(part => part.ToFirstCharacterUpperCase()))
            : segment.ToFirstCharacterUpperCase();

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
