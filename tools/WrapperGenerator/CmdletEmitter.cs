using System;
using System.Collections.Generic;
using System.Linq;

namespace WrapperGenerator;

// Emits the wrapper cmdlet shapes from section 8 of the design spec, one cmdlet class per
// selected OpenAPI operation: mandatory path-id parameters, an optional -AccessToken with a
// Connect-MgGraph fallback, a ShouldProcess gate on mutating calls, and the Kiota client's
// property/indexer chain for the actual request.
public static class CmdletEmitter
{
    // Transport acquisition lives on GraphClientCmdlet in Microsoft.Graph.Wrapper.Runtime: the
    // session path reuses one adapter keyed to the session HttpClient's identity, the token
    // path shares one HttpClient with per-request auth. Only the client construction is emitted.
    private const string AuthBlock = """

                var requestAdapter = GetRequestAdapter();
                var client = new ApiClient(requestAdapter);
        """;

    // Escapes a spec-derived value so it is safe inside a double-quoted C# string literal in the
    // generated source: backslash first, then double-quote. Applied to values taken from the
    // OpenAPI document (the cmdlet noun and header names) wherever they land inside "..." — an
    // unescaped quote or backslash would otherwise produce source that does not compile.
    private static string EscapeLiteral(string value) =>
        value.Replace("\\", "\\\\", StringComparison.Ordinal).Replace("\"", "\\\"", StringComparison.Ordinal);

    // parameterSetName scopes the ids to one set. Only the delta shape needs it: resuming from a
    // link must not demand path ids the link already carries, and which the raw-URL builder
    // discards. Everywhere else the ids belong to every set, which is what null produces.
    private static string PathParams(CmdletNaming naming, string? parameterSetName = null)
    {
        var setAttr = parameterSetName is null ? "" : $", ParameterSetName = \"{parameterSetName}\"";
        return string.Join("\n", naming.PathParamNames.Select((name, i) => $$"""
                [Parameter(Mandatory = true, Position = {{i}}{{setAttr}})]
                public string {{name}} { get; set; } = string.Empty;
        """));
    }

    private static string TargetId(CmdletNaming naming) =>
        naming.PathParamNames.Count > 0 ? naming.PathParamNames[^1] : "null";

    // Header parameters declared in the spec (most commonly an "If-Match" ETag on PATCH/DELETE)
    // become real cmdlet parameters. Graph sometimes requires them even when the spec marks
    // them optional; Planner's PATCH/DELETE is the known example. Dropping them would make
    // those endpoints impossible to call.
    private static string HeaderParamDecls(CmdletNaming naming) => HeaderParamDeclsFor(naming.HeaderParams, parameterSetName: null);

    private static string HeaderParamDeclsFor(IReadOnlyList<HeaderParam> headers, string? parameterSetName)
    {
        var setAttr = parameterSetName is null ? "" : $", ParameterSetName = \"{parameterSetName}\"";
        return string.Join("", headers.Select(h => $$"""


                [Parameter(Mandatory = false{{setAttr}},
                    HelpMessage = "Sets the '{{EscapeLiteral(h.RawName)}}' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
                public string? {{h.PsName}} { get; set; }
        """));
    }

    private static string HeaderBindings(CmdletNaming naming) => HeaderBindingsFor(naming.HeaderParams, extraIndent: "");

    // extraIndent shifts the lines 4 spaces deeper for call sites inside nested if/else blocks.
    private static string HeaderBindingsFor(IReadOnlyList<HeaderParam> headers, string extraIndent) =>
        string.Join("", headers.Select(h => $$"""


                {{extraIndent}}if (this.IsParameterBound(nameof({{h.PsName}})))
                {{extraIndent}}    requestConfiguration.Headers.Add("{{EscapeLiteral(h.RawName)}}", {{h.PsName}}!);
        """));

    // Splits a paired list/item GET's header parameters into: declared on both operations (bind
    // regardless of which parameter set is active), list-only, and get-only.
    private static (IReadOnlyList<HeaderParam> Shared, IReadOnlyList<HeaderParam> ListOnly, IReadOnlyList<HeaderParam> GetOnly) PartitionHeaderParams(
        CmdletNaming listNaming, CmdletNaming itemNaming)
    {
        var listNames = listNaming.HeaderParams.Select(h => h.RawName).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var itemNames = itemNaming.HeaderParams.Select(h => h.RawName).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var shared = listNaming.HeaderParams.Where(h => itemNames.Contains(h.RawName)).ToList();
        var listOnly = listNaming.HeaderParams.Where(h => !itemNames.Contains(h.RawName)).ToList();
        var getOnly = itemNaming.HeaderParams.Where(h => !listNames.Contains(h.RawName)).ToList();
        return (shared, listOnly, getOnly);
    }

    // -AccessToken is declared once on GraphClientCmdlet and inherited; nothing is emitted.
    private static string AccessTokenParamDecl() => "";

    // The shared try/catch tail around every Graph call. Only the ErrorRecord's target object
    // varies, and sometimes the nesting depth (EmitUpdate's re-fetch sits one block deeper).
    // The error surface itself (id, category) lives on GraphClientCmdlet. A pipeline stop
    // (downstream Select-Object -First, Ctrl+C) passes through untouched: it is the engine's
    // stop signal, not a Graph failure. The filter is load-bearing only where WriteObject runs
    // inside the try - list workers and dispatchers - and is emitted uniformly so every catch
    // tail in the corpus stays identical.
    private static string CatchBlock(string targetIdExpr, string extraIndent = "") => $$"""
            {{extraIndent}}catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {{extraIndent}}{
                {{extraIndent}}ThrowGraphRequestFailed(ex, {{targetIdExpr}});
                {{extraIndent}}return;
            {{extraIndent}}}
""";

    // The -Headers dictionary, matching the published SDK's parameter of the same name. It
    // lets a caller set any header, not just the ones the spec declares.
    // -Headers is declared once on GraphClientCmdlet and inherited; nothing is emitted.
    private static string GenericHeadersParamDecl() => "";

    // Copying -Headers onto the outgoing request lives on GraphClientCmdlet; the call stays in
    // the per-request configuration lambda so the headers apply per request.
    private static string GenericHeadersBinding(string extraIndent = "") => $$"""


                {{extraIndent}}AddRequestHeaders(requestConfiguration.Headers);
        """;

    // Post/Patch/DeleteAsync always take a requestConfiguration lambda, because -Headers exists
    // on every cmdlet. Reuses the same binding fragments the GET emitters use, at this call
    // site's deeper indent, so there is one binding implementation instead of three.
    private static string EmitCallWithOptionalHeaders(CmdletNaming naming, string method, string? bodyArg)
    {
        var call = $"client.{naming.BuilderExpression}.{method}(";
        var args = bodyArg is null ? "" : bodyArg + ", ";
        var bindings = HeaderBindingsFor(naming.HeaderParams, extraIndent: "                ") + GenericHeadersBinding("                ");
        return $"{call}{args}requestConfiguration =>\n                {{{bindings}\n                }})";
    }

    // How one action/function call is issued: the kiota method to invoke, the type it returns
    // (null when the operation has no response body), and the generated request-body type
    // (null when the operation declares no body). Kiota picks the method name from the response
    // shape — a response that wraps its payload in "value" gets a dedicated
    // …As<Member><Verb>ResponseAsync method, and the plain PostAsync/GetAsync overload beside it
    // is marked [Obsolete] — so the choice is resolved once, where the schema is read, rather
    // than re-derived in the template.
    public sealed record CallPlan(string MethodName, string? ReturnTypeName, string? BodyTypeName, bool ReturnsStream = false);

    // -OutFile matches the published surface for stream reads
    // (Get-MgUserPhotoContent -OutFile <path>). It is optional: the shipped reporting cmdlets
    // are documented without it, so an unbound -OutFile writes the bytes to the pipeline
    // instead, and both documented usages work.
    // The [GraphRoute] attribute line for a cmdlet class. See GraphRouteAttribute in Microsoft.Graph.Wrapper.Runtime.
    private static string RouteAttr(CmdletNaming naming) =>
        $"    [GraphRoute(\"{EscapeLiteral(naming.SourceMethod)}\", \"{EscapeLiteral(naming.SourcePath)}\")]";

    private static string OutFileParamDecl() => """


                [Parameter(Mandatory = false,
                    HelpMessage = "Writes the response content to this path instead of returning it as bytes.")]
                public string? OutFile { get; set; }
        """;

    // A stream response is read into a byte array before it reaches the pipeline. The raw Stream
    // is tied to the request that produced it, so emitting it would hand the caller an object
    // that is empty by the time they use it; the bytes are what the operation actually returns.
    // The response stream is disposed as well as the buffer: it owns the underlying HTTP
    // response, and a cmdlet that leaks one per call leaks a connection per call.
    private const string StreamOutputBlock = """

                if (result is not null)
                {
                    using (result)
                    {
                        if (this.IsParameterBound(nameof(OutFile)))
                        {
                            using var file = System.IO.File.Create(OutFile!);
                            result.CopyTo(file);
                        }
                        else
                        {
                            using var buffer = new System.IO.MemoryStream();
                            result.CopyTo(buffer);
                            WriteObject(buffer.ToArray());
                        }
                    }
                }
        """;

    // Kiota keys its path-parameter dictionary by the URL-template placeholder, percent-encoding
    // every character that is not valid in an identifier: "{user-id}" is stored as "user%2Did".
    // The emitted dictionary has to use the same key or the template leaves the placeholder
    // unexpanded and the request goes to a literal "{user-id}" URL.
    private static string ToTemplateKey(string templateName)
    {
        var encoded = new System.Text.StringBuilder(templateName.Length);
        foreach (var c in templateName)
        {
            if (char.IsLetterOrDigit(c) || c == '_')
                encoded.Append(c);
            else
                encoded.Append('%').Append(((int)c).ToString("X2", System.Globalization.CultureInfo.InvariantCulture));
        }
        return encoded.ToString();
    }

    private static string FunctionParamDecls(CmdletNaming naming) =>
        string.Join("\n", naming.FunctionParameters.Select((p, i) => $$"""

                [Parameter(Mandatory = true, Position = {{naming.PathParamNames.Count + i}},
                    HelpMessage = "Value for the '{{EscapeLiteral(p.TemplateName)}}' parameter of this OData function.")]
                public string {{p.PsName}} { get; set; } = string.Empty;
        """));

    // A parameterized OData function has no fluent accessor that can carry its arguments: these
    // OpenAPI documents declare no path parameters at all, so kiota emits the accessor with an
    // empty signature and leaves the placeholders in the URL template. The builder's public
    // path-parameter constructor takes the same dictionary the accessor would have populated,
    // so the values are supplied there and kiota expands its own template as usual.
    private static string FunctionBuilderConstruction(CmdletNaming naming, EmitContext ctx)
    {
        var builderType = $"global::{ctx.ClientNamespace}.{naming.OperationTypeNamespace}.{naming.OperationMemberName}RequestBuilder";
        var entries = new List<string>
        {
            // ApiClient assigns the adapter's BaseUrl, so constructing the client above is what
            // makes this key resolvable, not merely a discarded convenience.
            "            { \"baseurl\", requestAdapter.BaseUrl! },",
        };
        entries.AddRange(naming.PathParamTemplates
            .Select((template, i) => $"            {{ \"{EscapeLiteral(ToTemplateKey(template))}\", {naming.PathParamNames[i]} }},"));
        entries.AddRange(naming.FunctionParameters
            .Select(p => $"            {{ \"{EscapeLiteral(ToTemplateKey(p.TemplateName))}\", {p.PsName} }},"));

        return $$"""

                    var pathParameters = new Dictionary<string, object>
                    {
            {{string.Join("\n", entries)}}
                    };
                    var requestBuilder = new {{builderType}}(pathParameters, requestAdapter);
            """;
    }

    // The receiver the request method is called on: the fluent chain for an ordinary operation,
    // the explicitly constructed builder for a parameterized function.
    private static string CallReceiver(CmdletNaming naming) =>
        naming.FunctionParameters.Count > 0 ? "requestBuilder" : $"client.{naming.BuilderExpression}";

    // queryBindings, when present, is emitted inside the same requestConfiguration lambda as the
    // header bindings, so a call has exactly one configuration block however many kinds of
    // option it binds.
    private static string EmitCallOn(string receiver, CmdletNaming naming, string method, string? bodyArg, string queryBindings = "")
    {
        var args = bodyArg is null ? "" : bodyArg + ", ";
        var query = queryBindings.Length == 0 ? "" : "\n" + queryBindings;
        var bindings = query + HeaderBindingsFor(naming.HeaderParams, extraIndent: "                ") + GenericHeadersBinding("                ");
        return $"{receiver}.{method}({args}requestConfiguration =>\n                {{{bindings}\n                }})";
    }

    // An OData action: a POST that calls an operation on a resource rather than creating one.
    // Its parameters are the properties of a request body kiota generates per operation, so the
    // body type is passed in rather than resolved from a named entity schema.
    public static string EmitAction(CmdletNaming naming, EmitContext ctx, CallPlan call,
        IReadOnlyList<CmdletProperty> properties, IReadOnlyList<ComplexParameter> complexProperties,
        IReadOnlyList<UntypedParameter> untypedProperties)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(call);
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(complexProperties);
        ArgumentNullException.ThrowIfNull(untypedProperties);

        var hasBody = call.BodyTypeName is not null;
        var bodyConstruction = hasBody
            ? $"\n            var body = new {call.BodyTypeName}();\n"
                + EmitPropertyAssignments(properties)
                + EmitComplexAssignments(complexProperties)
                + EmitUntypedAssignments(untypedProperties)
            : "";
        var callExpression = EmitCallOn(CallReceiver(naming), naming, call.MethodName, hasBody ? "body" : null);
        var invocation = call.ReturnTypeName is null
            ? $$"""
                            {{callExpression}}
                                .GetAwaiter().GetResult();
            """
            : $$"""
                            result = {{callExpression}}.GetAwaiter().GetResult();
            """;

        return $$"""
#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using {{ctx.ModelsNamespace}};
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
{{(call.ReturnTypeName is null ? "" : $"    [OutputType(typeof({(call.ReturnsStream ? "byte[]" : call.ReturnTypeName)}))]")}}
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}
{{EmitPropertyParameters(properties)}}
{{EmitComplexParameters(complexProperties)}}
{{EmitUntypedParameters(untypedProperties)}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}
{{(call.ReturnsStream ? OutFileParamDecl() : "")}}
{{AccessTokenParamDecl()}}

        protected override void ProcessRecord()
        {
            if (!ShouldProcess({{TargetId(naming)}}, "{{naming.VerbName}}"))
                return;
{{bodyConstruction}}
{{AuthBlock}}

{{(call.ReturnTypeName is null ? "" : $"            {call.ReturnTypeName}? result;")}}
            try
            {
{{invocation}}
            }
{{CatchBlock(TargetId(naming))}}
{{(call.ReturnTypeName is null ? "" : call.ReturnsStream ? StreamOutputBlock : "\n            WriteObject(result);")}}
        }
    }
}

""";
    }

    // An OData function: a GET that computes a result rather than reading a stored resource.
    // Inline function arguments become mandatory parameters positioned after the path ids.
    public static string EmitFunction(CmdletNaming naming, EmitContext ctx, CallPlan call, IReadOnlySet<string> queryParamNames)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(call);
        ArgumentNullException.ThrowIfNull(queryParamNames);

        // Only options the operation declares: kiota generates a query-parameter property per
        // declared option, so binding an undeclared one would not compile.
        var applicable = CollectionQueryOptions.Where(o => queryParamNames.Contains(o.ODataName)).ToList();
        var queryParamDecls = string.Join("\n\n", applicable.Select(o => o.ParamDecl(null)));
        var queryBindings = string.Join("\n\n", applicable.Select(o => o.Binding));
        var builderConstruction = naming.FunctionParameters.Count > 0 ? FunctionBuilderConstruction(naming, ctx) : "";

        return $$"""
#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using {{ctx.ModelsNamespace}};
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}")]
    [OutputType(typeof({{(call.ReturnsStream ? "byte[]" : call.ReturnTypeName)}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}
{{FunctionParamDecls(naming)}}

{{AccessTokenParamDecl()}}

{{queryParamDecls}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}
{{(call.ReturnsStream ? OutFileParamDecl() : "")}}

        protected override void ProcessRecord()
        {
{{AuthBlock}}
{{builderConstruction}}

            {{call.ReturnTypeName}}? result;
            try
            {
                result = {{EmitCallOn(CallReceiver(naming), naming, call.MethodName, null, queryBindings)}}.GetAwaiter().GetResult();
            }
{{CatchBlock(TargetId(naming))}}
{{(call.ReturnsStream ? StreamOutputBlock : "\n            WriteObject(result);")}}
        }
    }
}

""";
    }

    // A delta (change-tracking) read. It is a function by classification, but its response is a
    // change set spread over nextLink pages and terminated by a deltaLink, so it gets its own
    // shape rather than the function template: items are enumerated like a list, and the
    // terminal link is published to a caller-named variable. The token form of the same
    // operation (delta(token='{token}')) is NOT a separate command - it is this command's
    // Resume parameter set, reached through -DeltaLink, which works for every delta route
    // rather than only the five whose spec declares a token argument.
    // Contract and evidence: docs/edge-cases/delta-edge-cases.md.
    // itemTypeName is the model the cmdlet actually writes; it falls back to the response type only
    // when the item cannot be resolved, so OutputType is never left describing nothing.
    public static string EmitDelta(CmdletNaming naming, EmitContext ctx, CallPlan call, IReadOnlySet<string> queryParamNames, string? itemTypeName = null)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(call);
        ArgumentNullException.ThrowIfNull(queryParamNames);

        // Query options belong to the initial sync only: a resume or continuation starts from a
        // link that already encodes them, and a raw-URL builder ignores them anyway.
        var applicable = CollectionQueryOptions.Where(o => queryParamNames.Contains(o.ODataName)).ToList();
        var queryParamDecls = string.Join("\n\n", applicable.Select(o => o.ParamDecl("DeltaSync")));
        var queryBindings = string.Join("\n\n", applicable.Select(o => o.Binding));

        // -Top caps the total at whole-page granularity, as it does for list cmdlets; the counter
        // exists only when the operation declares $top.
        var hasTop = queryParamNames.Contains("$top");
        var fetchedDecl = hasTop ? "\n                var fetched = 0;" : "";
        var fetchedAdd = hasTop ? "\n                        fetched += items.Count;" : "";
        var capGuard = hasTop
            ? "\n                    if (this.IsParameterBound(nameof(Top)) && fetched >= Top) break;"
            : "";
        var receiver = $"client.{naming.BuilderExpression}";
        var continuationConfig = HeaderBindingsFor(naming.HeaderParams, extraIndent: "        ") + GenericHeadersBinding("        ");

        return $$"""
#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using {{ctx.ModelsNamespace}};
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}", DefaultParameterSetName = "DeltaSync")]
    [OutputType(typeof({{itemTypeName ?? call.ReturnTypeName}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming, "DeltaSync")}}

{{AccessTokenParamDecl()}}

{{queryParamDecls}}

        // Resumes a previous sync from the link that run published. Universal: every delta
        // request builder accepts a raw URL, whereas a token argument exists on only a few.
        [Parameter(Mandatory = true, ParameterSetName = "Resume")]
        public string DeltaLink { get; set; } = string.Empty;

        // Follows @odata.nextLink through the change set. Without it only the first page returns,
        // plus a warning when more pages exist.
        [Parameter(Mandatory = false)]
        public SwitchParameter All { get; set; }

        // Receives the @odata.deltaLink that terminates the change set, for the next sync round.
        // A named variable is how this SDK already returns a scalar alongside a pipeline
        // (-CountVariable on the published list cmdlets).
        [Parameter(Mandatory = false)]
        [Alias("DLV")]
        public string? DeltaLinkVariable { get; set; }
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}

        protected override void ProcessRecord()
        {
{{AuthBlock}}

            // Cleared before the request so a failed or interrupted run cannot leave the previous
            // run's link readable, which would silently resume from the wrong point.
            if (this.IsParameterBound(nameof(DeltaLinkVariable)))
                SessionState.PSVariable.Set(DeltaLinkVariable, null);

            {{call.ReturnTypeName}}? result;
            try
            {
                result = ParameterSetName == "Resume"
                    ? {{receiver}}.WithUrl(ValidateContinuationUrl(DeltaLink!, requestAdapter, nameof(DeltaLink))).{{call.MethodName}}(requestConfiguration =>
                        {{{continuationConfig}}
                        }).GetAwaiter().GetResult()
                    : {{EmitCallOn(receiver, naming, call.MethodName, null, queryBindings)}}.GetAwaiter().GetResult();
{{fetchedDecl}}
                while (true)
                {
                    if (result?.Value is { } items)
                    {
                        WriteObject(items, enumerateCollection: true);{{fetchedAdd}}
                    }

                    var nextLink = result?.OdataNextLink;
                    var deltaLink = result?.OdataDeltaLink;

                    // A response cannot be both continued and terminated; treating one as
                    // authoritative would silently drop pages or resume from a partial set.
                    if (!string.IsNullOrEmpty(nextLink) && !string.IsNullOrEmpty(deltaLink))
                    {
                        ThrowTerminatingError(new ErrorRecord(
                            new InvalidOperationException("The response carries both @odata.nextLink and @odata.deltaLink, which is not a valid delta response."),
                            "InvalidDeltaResponse", ErrorCategory.InvalidData, targetObject: null));
                        return;
                    }

                    if (!string.IsNullOrEmpty(deltaLink))
                    {
                        if (this.IsParameterBound(nameof(DeltaLinkVariable)))
                            SessionState.PSVariable.Set(DeltaLinkVariable, deltaLink);
                        break;
                    }

                    // No link of either kind: the change set ends here and there is nothing to
                    // publish for a next round.
                    if (string.IsNullOrEmpty(nextLink)) break;

                    if (!All.IsPresent)
                    {
                        WriteWarning("More results are available. Use -All to return all pages.");
                        break;
                    }

                    if (Stopping) break;{{capGuard}}

                    result = {{receiver}}.WithUrl(nextLink).{{call.MethodName}}(requestConfiguration =>
                    {{{continuationConfig}}
                    }).GetAwaiter().GetResult();
                }
            }
{{CatchBlock(TargetId(naming))}}
        }
    }
}

""";
    }

    // An OData /$value read: the raw bytes behind a resource (a photo, an uploaded file). Kiota
    // types it as Stream from a plain GetAsync on the Content builder. -OutFile matches the
    // published surface (Get-MgUserPhotoContent -OutFile <path>).
    public static string EmitContentGet(CmdletNaming naming, EmitContext ctx, string returnTypeName, bool returnsStream)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(returnTypeName);

        return $$"""
#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}")]
    [OutputType(typeof({{(returnsStream ? "byte[]" : returnTypeName)}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}

{{AccessTokenParamDecl()}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}
{{(returnsStream ? OutFileParamDecl() : "")}}

        protected override void ProcessRecord()
        {
{{AuthBlock}}

            {{returnTypeName}}? result;
            try
            {
                result = {{EmitCallOn($"client.{naming.BuilderExpression}", naming, "GetAsync", null)}}.GetAwaiter().GetResult();
            }
{{CatchBlock(TargetId(naming))}}
{{(returnsStream ? StreamOutputBlock : "\n            WriteObject(result);")}}
        }
    }
}

""";
    }

    // An OData /$value write: uploads the bytes behind a resource. Kiota's PutAsync takes a
    // Stream, so -InFile is read from disk — matching the published surface
    // (Set-MgUserPhotoContent -InFile <path>).
    public static string EmitContentSet(CmdletNaming naming, EmitContext ctx, string returnTypeName, bool returnsStream)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(returnTypeName);

        return $$"""
#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof({{(returnsStream ? "byte[]" : returnTypeName)}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}

                [Parameter(Mandatory = true,
                    HelpMessage = "Path to the file whose contents are uploaded.")]
                public string InFile { get; set; } = string.Empty;

{{AccessTokenParamDecl()}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}
{{(returnsStream ? OutFileParamDecl() : "")}}

        protected override void ProcessRecord()
        {
            if (!ShouldProcess({{TargetId(naming)}}, "{{naming.VerbName}}"))
                return;
{{AuthBlock}}

            {{returnTypeName}}? result;
            try
            {
                using var content = System.IO.File.OpenRead(InFile);
                result = {{EmitCallOn($"client.{naming.BuilderExpression}", naming, "PutAsync", "content")}}.GetAwaiter().GetResult();
            }
{{CatchBlock(TargetId(naming))}}
{{(returnsStream ? StreamOutputBlock : "\n            WriteObject(result);")}}
        }
    }
}

""";
    }

    // A GET whose response is a single scalar rather than a resource: /$count returns int, and a
    // single-valued navigation's /$ref returns the one reference URL as a string. Neither is an
    // entity read nor half of a list/item pair, so the CLR type is passed in.
    public static string EmitScalarGet(CmdletNaming naming, EmitContext ctx, string clrType, IReadOnlySet<string> queryParamNames)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(clrType);
        ArgumentNullException.ThrowIfNull(queryParamNames);

        // $count accepts $filter and $search only; kiota generates a property per declared
        // option, so binding one the operation does not declare would not compile.
        var applicable = CollectionQueryOptions
            .Where(o => o.ODataName is "$filter" or "$search" && queryParamNames.Contains(o.ODataName))
            .ToList();
        var queryParamDecls = string.Join("\n\n", applicable.Select(o => o.ParamDecl(null)));
        var queryBindings = string.Join("\n\n", applicable.Select(o => o.Binding));

        return $$"""
#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}")]
    [OutputType(typeof({{clrType}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}

{{AccessTokenParamDecl()}}

{{queryParamDecls}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}

        protected override void ProcessRecord()
        {
{{AuthBlock}}

            {{clrType}}? result;
            try
            {
                result = {{EmitCallOn($"client.{naming.BuilderExpression}", naming, "GetAsync", null, queryBindings)}}.GetAwaiter().GetResult();
            }
{{CatchBlock(TargetId(naming))}}

            if (result is not null)
                WriteObject(result);
        }
    }
}

""";
    }

    public static string EmitItemGet(CmdletNaming naming, EmitContext ctx, string entityType, IReadOnlySet<string> queryParamNames)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(queryParamNames);

        // Only what the operation declares: kiota omits query-parameter properties the doc
        // doesn't declare (subscribedSkus/{id} has $select but no $expand), so an
        // unconditional binding would not compile against the builder.
        var applicable = CollectionQueryOptions
            .Where(o => o.ODataName is "$select" or "$expand" && queryParamNames.Contains(o.ODataName))
            .ToList();
        var queryParamDecls = string.Join("\n", applicable.Select(o => o.ParamDecl(null)));
        var queryBindings = string.Join("\n\n", applicable.Select(o => o.Binding));

        return $$"""
#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using {{ctx.ModelsNamespace}};
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}")]
    [OutputType(typeof({{entityType}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}

{{AccessTokenParamDecl()}}

{{queryParamDecls}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}

        protected override void ProcessRecord()
        {
{{AuthBlock}}

            {{entityType}}? result;
            try
            {
                result = client.{{naming.BuilderExpression}}.GetAsync(requestConfiguration =>
                {
{{queryBindings}}
{{HeaderBindings(naming)}}
{{GenericHeadersBinding()}}
                }).GetAwaiter().GetResult();
            }
{{CatchBlock(TargetId(naming))}}

            WriteObject(result);
        }
    }
}

""";
    }

    // Collection GETs do not all support the same OData query options (GET /users has no $skip,
    // for example), so the emitted parameters follow what the operation declares, not a fixed
    // set. Primary names match the published SDK (Property, ExpandProperty, Sort); the
    // wrapper's original names stay as aliases so -Select/-Expand/-OrderBy keep working.
    //
    // ParamDecl takes the owning parameter-set name (null when the cmdlet has no sets) so the
    // dispatcher can derive its "List"-tagged declarations from this same table instead of
    // keeping a second copy that would drift.
    private static string ParamSetDecl(string? parameterSetName, string propertyDecl, string? alias = null)
    {
        var setAttr = parameterSetName is null ? "" : $", ParameterSetName = \"{parameterSetName}\"";
        var aliasLine = alias is null ? "" : $"\n        [Alias(\"{alias}\")]";
        return $"        [Parameter(Mandatory = false{setAttr})]{aliasLine}\n        {propertyDecl}";
    }

    private static readonly (string ODataName, string PsName, Func<string?, string> ParamDecl, string Binding)[] CollectionQueryOptions =
    [
        ("$filter", "Filter", ps => ParamSetDecl(ps, "public string? Filter { get; set; }"),
            "                    if (this.IsParameterBound(nameof(Filter)))\n                        requestConfiguration.QueryParameters.Filter = Filter;"),
        ("$select", "Property", ps => ParamSetDecl(ps, "public string[]? Property { get; set; }", alias: "Select"),
            "                    if (this.IsParameterBound(nameof(Property)))\n                        requestConfiguration.QueryParameters.Select = Property;"),
        ("$expand", "ExpandProperty", ps => ParamSetDecl(ps, "public string[]? ExpandProperty { get; set; }", alias: "Expand"),
            "                    if (this.IsParameterBound(nameof(ExpandProperty)))\n                        requestConfiguration.QueryParameters.Expand = ExpandProperty;"),
        ("$orderby", "Sort", ps => ParamSetDecl(ps, "public string[]? Sort { get; set; }", alias: "OrderBy"),
            "                    if (this.IsParameterBound(nameof(Sort)))\n                        requestConfiguration.QueryParameters.Orderby = Sort;"),
        ("$search", "Search", ps => ParamSetDecl(ps, "public string? Search { get; set; }"),
            "                    if (this.IsParameterBound(nameof(Search)))\n                        requestConfiguration.QueryParameters.Search = Search;"),
        ("$top", "Top", ps => ParamSetDecl(ps, "public int Top { get; set; }"),
            "                    if (this.IsParameterBound(nameof(Top)))\n                        requestConfiguration.QueryParameters.Top = Top;"),
        ("$skip", "Skip", ps => ParamSetDecl(ps, "public int Skip { get; set; }"),
            "                    if (this.IsParameterBound(nameof(Skip)))\n                        requestConfiguration.QueryParameters.Skip = Skip;"),
        ("$count", "Count", ps => ParamSetDecl(ps, "public SwitchParameter Count { get; set; }"),
            "                    if (Count.IsPresent)\n                        requestConfiguration.QueryParameters.Count = true;"),
    ];

    public static string EmitListGet(CmdletNaming naming, EmitContext ctx, string entityType, string collectionResponseType, IReadOnlySet<string> queryParamNames)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(queryParamNames);
        var applicable = CollectionQueryOptions.Where(o => queryParamNames.Contains(o.ODataName)).ToList();
        var paramDecls = string.Join("\n\n", applicable.Select(o => o.ParamDecl(null)));
        var bindings = string.Join("\n\n", applicable.Select(o => o.Binding));

        // -Top is a TOTAL cap under -All, at whole-page granularity - the published ListCmdlet's
        // semantics: limit = Top, iterate while fetched < limit, and whole final pages ship
        // because the overflow trimmer has zero call sites in current generated output (its
        // injection directive anchors on a callback name autorest no longer emits; evidence in
        // docs/pagination.md). The counter exists only when the operation declares $top; without
        // it the loop is uncapped and only nextLink exhaustion or a pipeline stop ends it.
        var hasTop = queryParamNames.Contains("$top");
        var fetchedInit = hasTop ? "\n                    var fetched = result?.Value?.Count ?? 0;" : "";
        var capCondition = hasTop ? " && (!this.IsParameterBound(nameof(Top)) || fetched < Top)" : "";
        var fetchedAdd = hasTop ? "\n                            fetched += page.Count;" : "";
        var continuationHeaders = HeaderBindingsFor(naming.HeaderParams, extraIndent: "        ") + GenericHeadersBinding("        ");

        return $$"""
#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using {{ctx.ModelsNamespace}};
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}")]
    [OutputType(typeof({{entityType}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}

{{AccessTokenParamDecl()}}

{{paramDecls}}

        // Follows every @odata.nextLink until the collection is exhausted (a bound -Top caps
        // the total). Without it only the first page returns, plus a truncation warning when
        // more pages existed.
        [Parameter(Mandatory = false)]
        public SwitchParameter All { get; set; }
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}

        protected override void ProcessRecord()
        {
{{AuthBlock}}

            {{collectionResponseType}}? result;
            try
            {
                result = client.{{naming.BuilderExpression}}.GetAsync(requestConfiguration =>
                {
{{bindings}}
{{HeaderBindings(naming)}}
{{GenericHeadersBinding()}}
                }).GetAwaiter().GetResult();

                // A collection response and its Value are both nullable on the kiota client; an
                // empty page writes nothing rather than dereferencing null. Each page streams to
                // the pipeline before the next request is issued, matching the published SDK.
                if (result?.Value is { } items)
                    WriteObject(items, enumerateCollection: true);

                if (All.IsPresent)
                {{{fetchedInit}}
                    var nextLink = result?.OdataNextLink;
                    while (!string.IsNullOrEmpty(nextLink) && !Stopping{{capCondition}})
                    {
                        // The nextLink already carries the original query state, and a raw-URL
                        // builder ignores templated query parameters anyway - so the continuation
                        // re-applies headers only; query bindings here would be dead code.
                        result = client.{{naming.BuilderExpression}}.WithUrl(nextLink).GetAsync(requestConfiguration =>
                        {{{continuationHeaders}}
                        }, StoppingToken).GetAwaiter().GetResult();
                        if (result?.Value is { } page)
                        {
                            WriteObject(page, enumerateCollection: true);{{fetchedAdd}}
                        }
                        nextLink = result?.OdataNextLink;
                    }
                }
                else if (!string.IsNullOrEmpty(result?.OdataNextLink))
                {
                    // Deliberately stronger than the published SDK, which truncates silently;
                    // approved in the design spec. One line, no extra request.
                    WriteWarning("More results are available. Use -All to return all pages.");
                }
            }
{{CatchBlock(TargetId(naming))}}
        }
    }
}

""";
    }

    // The dispatcher's list-only parameter declarations: CollectionQueryOptions minus
    // $select/$expand, which are declared separately per the sets that support them.
    // Declarations only; binding happens in the internal list cmdlet the dispatcher calls.
    private static IEnumerable<(string ODataName, string ParamDecl)> ListOnlyQueryOptionsForMerge() =>
        CollectionQueryOptions
            .Where(o => o.ODataName is not ("$select" or "$expand"))
            .Select(o => (o.ODataName, o.ParamDecl("List")));

    // Shared path params (-UserId on a nested list) carry no ParameterSetName, which PowerShell
    // treats as "all sets". The trailing item id (-MessageId) belongs to the "Get" set only and
    // continues the Position sequence where the shared ones left off.
    private static string PairedPathParams(IReadOnlyList<string> sharedNames, IReadOnlyList<string> getOnlyNames)
    {
        var parts = new List<string>();
        var sharedDecls = string.Join("\n", sharedNames.Select((name, i) => $$"""
                [Parameter(Mandatory = true, Position = {{i}})]
                public string {{name}} { get; set; } = string.Empty;
        """));
        if (sharedDecls.Length > 0)
            parts.Add(sharedDecls);

        var getOnlyDecls = string.Join("\n", getOnlyNames.Select((name, i) => $$"""
                [Parameter(Mandatory = true, ParameterSetName = "Get", Position = {{sharedNames.Count + i}})]
                public string {{name}} { get; set; } = string.Empty;
        """));
        if (getOnlyDecls.Length > 0)
            parts.Add(getOnlyDecls);

        return string.Join("\n", parts);
    }

    // The thin public cmdlet for a paired list/item GET. It presents the merged Get-MgX surface
    // the published SDK exposes ("List" as the default set, "Get" for item lookups) but makes no
    // HTTP call itself. Per the design spec's parameter-set decision, the real work stays in the
    // two internal cmdlets; ProcessRecord only picks one and forwards the bound parameters. The
    // forward goes through InvokeCommand.InvokeScript on the current runspace, so the nested
    // call shares the caller's session, including an active Connect-MgGraph.
    public static string EmitGetDispatcher(CmdletNaming listNaming, CmdletNaming itemNaming,
        CmdletNaming internalListNaming, CmdletNaming internalItemNaming, EmitContext ctx,
        string entityType, string collectionResponseType, IReadOnlySet<string> listQueryParamNames, IReadOnlySet<string> itemQueryParamNames)
    {
        ArgumentNullException.ThrowIfNull(listNaming);
        ArgumentNullException.ThrowIfNull(itemNaming);
        ArgumentNullException.ThrowIfNull(internalListNaming);
        ArgumentNullException.ThrowIfNull(internalItemNaming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(listQueryParamNames);
        ArgumentNullException.ThrowIfNull(itemQueryParamNames);

        var sharedPathParams = listNaming.PathParamNames;
        var getOnlyPathParams = itemNaming.PathParamNames.Skip(sharedPathParams.Count).ToList();

        var applicable = ListOnlyQueryOptionsForMerge().Where(o => listQueryParamNames.Contains(o.ODataName)).ToList();
        var listOnlyParamDecls = string.Join("\n\n", applicable.Select(o => o.ParamDecl));

        // $select/$expand support can differ between the two operations (subscribedSkus
        // declares $expand on the list but not the item), so each declaration is scoped to
        // the parameter set(s) whose worker actually binds it.
        var selectExpandDecls = string.Join("\n\n", new[] { "$select", "$expand" }
            .Select(od =>
            {
                var row = CollectionQueryOptions.First(o => o.ODataName == od);
                var inList = listQueryParamNames.Contains(od);
                var inItem = itemQueryParamNames.Contains(od);
                return inList && inItem ? row.ParamDecl(null)
                    : inList ? row.ParamDecl("List")
                    : inItem ? row.ParamDecl("Get")
                    : null;
            })
            .Where(static d => d is not null));

        var (sharedHeaders, listOnlyHeaders, getOnlyHeaders) = PartitionHeaderParams(listNaming, itemNaming);

        var internalListCmdletName = $"{internalListNaming.VerbName}-{internalListNaming.Noun}";
        var internalGetCmdletName = $"{internalItemNaming.VerbName}-{internalItemNaming.Noun}";

        return $$"""
#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ModelsNamespace}};

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(listNaming)}}
    [Cmdlet({{listNaming.VerbsClass}}.{{listNaming.VerbName}}, "{{EscapeLiteral(listNaming.Noun)}}", DefaultParameterSetName = "List")]
    [OutputType(typeof({{collectionResponseType}}), ParameterSetName = new[] { "List" })]
    [OutputType(typeof({{entityType}}), ParameterSetName = new[] { "Get" })]
    public class {{listNaming.ClassName}} : GraphClientCmdlet
    {
{{PairedPathParams(sharedPathParams, getOnlyPathParams)}}

{{AccessTokenParamDecl()}}

{{selectExpandDecls}}

{{listOnlyParamDecls}}

        // Declared here because the binder rejects a parameter the dispatcher does not accept
        // before ProcessRecord ever runs; once declared, the wholesale BoundParameters splat
        // forwards it to the list worker with no further plumbing.
        [Parameter(Mandatory = false, ParameterSetName = "List")]
        public SwitchParameter All { get; set; }
{{HeaderParamDeclsFor(sharedHeaders, parameterSetName: null)}}
{{HeaderParamDeclsFor(listOnlyHeaders, parameterSetName: "List")}}
{{HeaderParamDeclsFor(getOnlyHeaders, parameterSetName: "Get")}}
{{GenericHeadersParamDecl()}}

        // Delegates to {{internalGetCmdletName}} or {{internalListCmdletName}}, the two cmdlets
        // that actually call Graph.
        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName == "Get" ? "{{EscapeLiteral(internalGetCmdletName)}}" : "{{EscapeLiteral(internalListCmdletName)}}";
            try
            {
                InvokeCommand.InvokeScript(
                    "param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters",
                    false,
                    PipelineResultTypes.Output | PipelineResultTypes.Error,
                    null,
                    MyInvocation.BoundParameters, internalCmdletName);
            }
            // The workers signal failure via ThrowTerminatingError, which InvokeScript surfaces
            // as a RuntimeException carrying the worker's ErrorRecord. Rethrow that record
            // unchanged so the caller sees the worker's error identity (NoGraphSession,
            // GraphRequestFailed, ...) instead of every failure collapsing into a generic
            // dispatcher error. A pipeline stop is a RuntimeException too and must NOT be
            // rethrown as a terminating error - both filters here let it pass to the engine.
            catch (RuntimeException rex) when (rex is not PipelineStoppedException && rex.ErrorRecord is not null)
            {
                ThrowTerminatingError(rex.ErrorRecord);
                return;
            }
{{CatchBlock($"ParameterSetName == \"Get\" ? {TargetId(itemNaming)} : {TargetId(listNaming)}")}}
        }
    }
}

""";
    }

    public static string EmitNew(CmdletNaming naming, EmitContext ctx, string entityType, IReadOnlyList<CmdletProperty> properties, IReadOnlyList<ComplexParameter> complexProperties, IReadOnlyList<UntypedParameter> untypedProperties)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(complexProperties);
        ArgumentNullException.ThrowIfNull(untypedProperties);
        return $$"""
#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using {{ctx.ModelsNamespace}};
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof({{entityType}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}
{{EmitPropertyParameters(properties)}}
{{EmitComplexParameters(complexProperties)}}
{{EmitUntypedParameters(untypedProperties)}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}

{{AccessTokenParamDecl()}}

        protected override void ProcessRecord()
        {
            if (!ShouldProcess({{TargetId(naming)}}, "{{naming.VerbName}}"))
                return;

            var body = new {{entityType}}();
{{EmitPropertyAssignments(properties)}}
{{EmitComplexAssignments(complexProperties)}}
{{EmitUntypedAssignments(untypedProperties)}}
{{AuthBlock}}

            {{entityType}}? result;
            try
            {
                result = {{EmitCallWithOptionalHeaders(naming, "PostAsync", "body")}}.GetAwaiter().GetResult();
            }
{{CatchBlock("body")}}

            WriteObject(result);
        }
    }
}

""";
    }

    public static string EmitUpdate(CmdletNaming naming, EmitContext ctx, string entityType, IReadOnlyList<CmdletProperty> properties, IReadOnlyList<ComplexParameter> complexProperties, IReadOnlyList<UntypedParameter> untypedProperties, bool reFetchAfterUpdate = true, string httpMethodName = "PatchAsync")
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        ArgumentNullException.ThrowIfNull(properties);
        ArgumentNullException.ThrowIfNull(complexProperties);
        ArgumentNullException.ThrowIfNull(untypedProperties);
        return $$"""
#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using {{ctx.ModelsNamespace}};
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof({{entityType}}))]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}
{{EmitPropertyParameters(properties)}}
{{EmitComplexParameters(complexProperties)}}
{{EmitUntypedParameters(untypedProperties)}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}

{{AccessTokenParamDecl()}}

        protected override void ProcessRecord()
        {
            if (!ShouldProcess({{TargetId(naming)}}, "{{naming.VerbName}}"))
                return;

            var body = new {{entityType}}();
{{EmitPropertyAssignments(properties)}}
{{EmitComplexAssignments(complexProperties)}}
{{EmitUntypedAssignments(untypedProperties)}}
{{AuthBlock}}

            {{entityType}}? result;
            try
            {
                result = {{EmitCallWithOptionalHeaders(naming, httpMethodName, "body")}}.GetAwaiter().GetResult();
            }
{{CatchBlock(TargetId(naming))}}

{{(reFetchAfterUpdate ? ReFetchBlock(naming) : "")}}
            if (result is not null)
                WriteObject(result);
        }
    }
}

""";
    }

    public static string EmitRemove(CmdletNaming naming, EmitContext ctx)
    {
        ArgumentNullException.ThrowIfNull(naming);
        ArgumentNullException.ThrowIfNull(ctx);
        return $$"""
#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using {{ctx.ClientNamespace}};
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace {{ctx.CmdletNamespace}}
{
{{RouteAttr(naming)}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{PathParams(naming)}}
{{HeaderParamDecls(naming)}}
{{GenericHeadersParamDecl()}}

{{AccessTokenParamDecl()}}

        protected override void ProcessRecord()
        {
            if (!ShouldProcess({{TargetId(naming)}}, "{{naming.VerbName}}"))
                return;
{{AuthBlock}}

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                {{EmitCallWithOptionalHeaders(naming, "DeleteAsync", null)}}
                    .GetAwaiter().GetResult();
            }
{{CatchBlock(TargetId(naming))}}
        }
    }
}

""";
    }

    // Graph often answers a successful PATCH with 204 and no body (seen live on
    // schemaExtension update), so Update re-fetches to return the updated resource — but
    // only when the path actually has a GET (PATCH-only resources like /places/{id} have no
    // GetAsync on their builder; found by compiling the Calendar module).
    private static string ReFetchBlock(CmdletNaming naming) => $$"""

            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.{{naming.BuilderExpression}}.GetAsync().GetAwaiter().GetResult();
                }
{{CatchBlock(TargetId(naming), "    ")}}
            }
""";

    // ParameterName (not PascalName) names the parameter: it carries the "1" suffix when a
    // body property collides with a path id. The body assignment keeps PascalName — the
    // Kiota model property is unaffected by the parameter rename.
    private static string EmitPropertyParameters(IReadOnlyList<CmdletProperty> properties) =>
        string.Join("\n", properties.Select(p => $$"""

                [Parameter(Mandatory = false)]
                public {{p.PsTypeName}}? {{p.ParameterName}} { get; set; }
        """));

    private static string EmitPropertyAssignments(IReadOnlyList<CmdletProperty> properties) =>
        string.Join("\n", properties.Select(p => $$"""

            if (this.IsParameterBound(nameof({{p.ParameterName}})))
                body.{{p.PascalName}} = {{(p.IsArray ? $"{p.ParameterName}!.ToList()" : p.ParameterName)}};
        """));

    // A complex property binds as its kiota model type. PowerShell converts a hashtable to that
    // type on binding (the models have a parameterless constructor and settable properties), so
    // the caller writes -PasswordProfile @{ Password = '...' } without constructing the type.
    // TypeName is fully qualified: the models namespace is imported, but a model whose name
    // matches a cmdlet parameter or BCL type would otherwise bind to the wrong symbol.
    private static string EmitComplexParameters(IReadOnlyList<ComplexParameter> properties) =>
        string.Join("\n", properties.Select(p => $$"""

                [Parameter(Mandatory = false)]
                public {{p.ElementNullableTypeName}}? {{p.ParameterName}} { get; set; }
        """));

    private static string EmitComplexAssignments(IReadOnlyList<ComplexParameter> properties) =>
        string.Join("\n", properties.Select(p => $$"""

            if (this.IsParameterBound(nameof({{p.ParameterName}})))
                body.{{p.PascalName}} = {{(p.IsArray ? $"{p.ParameterName}!.ToList()" : p.ParameterName)}};
        """));

    // A schema-less property takes object and converts, so the caller can pass an ordinary
    // PowerShell value. A conversion result of null means "omit", which is why the assignment
    // is guarded on the converted value and not merely on the parameter being bound.
    private static string EmitUntypedParameters(IReadOnlyList<UntypedParameter> properties) =>
        string.Join("\n", properties.Select(p => $$"""

                [Parameter(Mandatory = false)]
                public object? {{p.ParameterName}} { get; set; }
        """));

    private static string EmitUntypedAssignments(IReadOnlyList<UntypedParameter> properties) =>
        string.Join("\n", properties.Select(p => $$"""

            if (this.IsParameterBound(nameof({{p.ParameterName}})))
            {
                var {{p.LocalName}} = UntypedValue.From({{p.ParameterName}});
                if ({{p.LocalName}} is not null)
                    body.{{p.PascalName}} = {{p.LocalName}};
            }
        """));
}
