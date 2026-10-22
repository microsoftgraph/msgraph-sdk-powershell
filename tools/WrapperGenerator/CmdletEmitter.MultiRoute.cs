using System;
using System.Collections.Generic;
using System.Linq;

namespace WrapperGenerator;

public static partial class CmdletEmitter
{
    public sealed record StringQueryParameter(string Name, string PsName, bool Required)
    {
        public string BuilderPropertyName { get; init; } = PsName;
    }

    private static string ExtraQueryDeclarations(IReadOnlyList<StringQueryParameter>? parameters) =>
        parameters is not { Count: > 0 } ? "" : "\n" + string.Join("\n", parameters.Select(p =>
            $"        [Parameter(Mandatory = {p.Required.ToString().ToLowerInvariant()})]\n"
            + $"        public string{(p.Required ? "" : "?")} {p.PsName} {{ get; set; }}{(p.Required ? " = string.Empty;" : "")}"));

    private static string ExtraQueryBindings(IReadOnlyList<StringQueryParameter>? parameters) =>
        parameters is not { Count: > 0 } ? "" : "\n" + string.Join("\n", parameters.Select(p =>
            $"                    if (this.IsParameterBound(nameof({p.PsName})))\n"
            + $"                        requestConfiguration.QueryParameters.{p.BuilderPropertyName} = {p.PsName};"));

    public sealed record DispatchParameter(string Name, string Type, bool Mandatory = false, int? Position = null, string? Alias = null);

    public sealed record RouteWorker(CmdletNaming Naming, CmdletNaming InternalNaming, string RouteName,
        string Shape, IReadOnlyList<DispatchParameter> Parameters, string? OutputType);

    private static readonly HashSet<string> ReservedDispatchParameterNames = new(
        ["AccessToken", "Headers", "Verbose", "Debug", "ErrorAction", "WarningAction", "InformationAction",
         "ProgressAction", "ErrorVariable", "WarningVariable", "InformationVariable", "OutVariable",
         "OutBuffer", "PipelineVariable", "WhatIf", "Confirm",
         "vb", "db", "ea", "wa", "infa", "proga", "ev", "wv", "iv", "ov", "ob", "pv", "wi", "cf"],
        StringComparer.OrdinalIgnoreCase);

    internal static bool IsReservedDispatchParameterName(string name) => ReservedDispatchParameterNames.Contains(name);

    private static void ValidateMultiRouteBinding(MultiRouteGroup group, IReadOnlyList<RouteWorker> workers)
    {
        if ((group.AllowAsymmetricRoutes || group.AllowExplicitRouteSelection) && group.SelectorParameter is null)
            throw new InvalidOperationException("Asymmetric or explicit multi-route groups require an explicit selector parameter.");
        if (group.AllowPublishedParameterInference && !group.AllowExplicitRouteSelection)
            throw new InvalidOperationException("Published parameter inference requires the explicit per-route parameter policy.");
        var parameters = workers.SelectMany(w => w.Parameters).ToArray();
        var names = parameters.Select(p => p.Name).ToHashSet(StringComparer.OrdinalIgnoreCase);
        if (group.AllowExplicitRouteSelection)
        {
            var positions = new Dictionary<int, string>();
            foreach (var parameter in parameters.GroupBy(p => p.Name, StringComparer.OrdinalIgnoreCase))
            {
                var declaredPositions = parameter.Select(p => p.Position).Distinct().ToArray();
                if (declaredPositions.Length > 1)
                    throw new InvalidOperationException($"Explicit route parameter '{parameter.Key}' has incompatible positional contracts.");
                if (declaredPositions[0] is { } position)
                {
                    if (positions.TryGetValue(position, out var previous) && !previous.Equals(parameter.Key, StringComparison.OrdinalIgnoreCase))
                        throw new InvalidOperationException($"Explicit route parameters '{previous}' and '{parameter.Key}' share position {position}.");
                    positions[position] = parameter.Key;
                }
            }
        }
        if (parameters.Any(p => IsReservedDispatchParameterName(p.Name)
            || (p.Alias is { } alias && IsReservedDispatchParameterName(alias))))
            throw new InvalidOperationException("Multi-route parameter or alias conflicts with a runtime or PowerShell common parameter.");
        if (group.SelectorParameter is { } selector)
        {
            if (IsReservedDispatchParameterName(selector) || parameters.Any(p =>
                p.Name.Equals(selector, StringComparison.OrdinalIgnoreCase)
                || string.Equals(p.Alias, selector, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException($"Multi-route selector '{selector}' conflicts with an existing parameter or alias.");
        }
        var aliasOwners = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var parameter in parameters.Where(p => p.Alias is not null))
        {
            var alias = parameter.Alias!;
            if (names.Contains(alias) || (aliasOwners.TryGetValue(alias, out var owner)
                && !owner.Equals(parameter.Name, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException($"Multi-route parameter alias '{alias}' conflicts with another parameter or alias.");
            aliasOwners[alias] = parameter.Name;
        }

        var defaultWorker = workers.Where(w => w.RouteName == group.DefaultRoute)
            .OrderBy(w => w.Shape == "List" ? 0 : 1).First();
        // The selector discriminates route labels, not List/Get within one label. Required
        // queries participate in PowerShell binding just like path IDs.
        foreach (var partition in workers.GroupBy(w => group.SelectorParameter is null ? "" : w.RouteName))
        {
            var peers = partition.ToArray();
            var mandatory = peers.Select(w => w.Parameters.Where(p => p.Mandatory)
                .Select(p => p.Name).ToHashSet(StringComparer.OrdinalIgnoreCase)).ToArray();
            var partitionDefault = group.SelectorParameter is null ? defaultWorker
                : peers.FirstOrDefault(w => w.Shape == defaultWorker.Shape);
            var defaultMandatory = partitionDefault?.Parameters.Where(p => p.Mandatory)
                .Select(p => p.Name).ToHashSet(StringComparer.OrdinalIgnoreCase);
            for (var i = 0; i < peers.Length; i++)
            {
                if (mandatory.Take(i).Any(previous => previous.SetEquals(mandatory[i])))
                    throw new InvalidOperationException("Multi-route parameter sets have identical mandatory parameters and cannot be selected unambiguously.");
                if (defaultMandatory is not null && mandatory[i].IsProperSubsetOf(defaultMandatory))
                    throw new InvalidOperationException("Multi-route default parameter set shadows a route with fewer mandatory parameters; choose a shallower default or an explicit selector.");
            }
        }
        if (group.SelectorParameter is not null && !group.AllowExplicitRouteSelection && workers.GroupBy(w => w.Shape)
            .Any(shape => shape.Skip(1).Any(w => !shape.First().Parameters.SequenceEqual(w.Parameters))))
            throw new InvalidOperationException("Selected multi-route operations require identical public parameters.");
    }

    public static IReadOnlyList<DispatchParameter> BodyDispatchParameters(
        IReadOnlyList<CmdletProperty> scalars, IReadOnlyList<ComplexParameter> complex,
        IReadOnlyList<UntypedParameter> untyped) =>
        [.. scalars.Select(p => new DispatchParameter(p.ParameterName, p.PsTypeName + "?")),
         .. complex.Select(p => new DispatchParameter(p.ParameterName, p.ElementNullableTypeName + "?")),
         .. untyped.Select(p => new DispatchParameter(p.ParameterName, "object?"))];

    public static IReadOnlyList<DispatchParameter> GetDispatchParameters(
        CmdletNaming naming, string shape, IReadOnlySet<string> queryParams,
        IReadOnlyList<DispatchParameter> bodyParameters,
        IReadOnlyList<StringQueryParameter>? extraQueryParameters = null)
    {
        var parameters = naming.PathParamNames.Select((name, i) =>
            new DispatchParameter(name, "string", Mandatory: true, Position: i)).ToList();
        parameters.AddRange(bodyParameters);
        parameters.AddRange(naming.HeaderParams.Select(h => new DispatchParameter(h.PsName, "string?")));
        parameters.AddRange((extraQueryParameters ?? []).Select(p =>
            new DispatchParameter(p.PsName, p.Required ? "string" : "string?", p.Required)));
        if (shape is "List" or "Get" or "Scalar")
        {
            parameters.AddRange(CollectionQueryOptions
                .Where(q => queryParams.Contains(q.ODataName)
                    && (shape == "List" || (shape == "Scalar" ? q.ODataName is "$filter" or "$search" : q.ODataName is "$select" or "$expand")))
                .Select(q => new DispatchParameter(q.PsName,
                    q.ODataName switch
                    {
                        "$top" or "$skip" => "int",
                        "$count" => "SwitchParameter",
                        "$select" or "$expand" or "$orderby" => "string[]?",
                        _ => "string?",
                    }, Alias: q.ODataName switch { "$select" => "Select", "$expand" => "Expand", "$orderby" => "OrderBy", _ => null })));
            if (shape == "List")
                parameters.Add(new("All", "SwitchParameter"));
        }
        if (parameters.GroupBy(p => p.Name, StringComparer.OrdinalIgnoreCase).Any(g => g.Count() > 1))
            throw new InvalidOperationException($"Multi-route parameter name conflict at {naming.SourcePath}.");
        return parameters;
    }

    public static string EmitMultiRouteDispatcher(MultiRouteGroup group, IReadOnlyList<RouteWorker> workers, EmitContext ctx)
    {
        ValidateMultiRouteBinding(group, workers);
        var naming = workers[0].Naming;
        string SetName(RouteWorker worker) => group.AllowExplicitRouteSelection ? "Route"
            : group.SelectorParameter is null ? worker.RouteName + worker.Shape : worker.Shape;
        var defaultWorker = workers.Where(w => w.RouteName == group.DefaultRoute).OrderBy(w => w.Shape == "List" ? 0 : 1).First();
        var declarations = new List<string>();
        foreach (var parameter in workers.SelectMany(w => w.Parameters).GroupBy(p => p.Name, StringComparer.OrdinalIgnoreCase))
        {
            var first = parameter.First();
            if (parameter.Any(p => p.Type != first.Type
                || (!group.AllowExplicitRouteSelection && p.Mandatory != first.Mandatory) || p.Alias != first.Alias))
                throw new InvalidOperationException($"Incompatible multi-route parameter {first.Name}.");
            var attributes = workers.Where(w => w.Parameters.Any(p => p.Name.Equals(first.Name, StringComparison.OrdinalIgnoreCase)))
                .GroupBy(SetName).Select(s =>
                {
                    var p = s.First().Parameters.Single(p => p.Name.Equals(first.Name, StringComparison.OrdinalIgnoreCase));
                    var mandatory = p.Mandatory && (!group.AllowExplicitRouteSelection || workers.All(w =>
                        w.Parameters.Any(other => other.Name.Equals(p.Name, StringComparison.OrdinalIgnoreCase) && other.Mandatory)));
                    var position = p.Position is { } i ? $", Position = {i}" : "";
                    return $"        [Parameter(Mandatory = {mandatory.ToString().ToLowerInvariant()}, ParameterSetName = \"{s.Key}\"{position})]";
                });
            var initializer = first.Type == "string" ? " = string.Empty;" : "";
            var aliasAttribute = first.Alias is null ? "" : $"\n        [Alias(\"{first.Alias}\")]";
            declarations.Add($"{string.Join("\n", attributes)}{aliasAttribute}\n        public {first.Type} {first.Name} {{ get; set; }}{initializer}");
        }

        var labels = workers.Select(w => w.RouteName).Distinct(StringComparer.Ordinal).ToArray();
        var selector = group.SelectorParameter is { } selectorName
            ? $$"""
        [Parameter]
        [ValidateSet("Published", {{string.Join(", ", labels.Select(l => $"\"{l}\""))}})]
        public string {{selectorName}} { get; set; } = "Published";
"""
            : "";
        var routeExpression = group.SelectorParameter is null ? "\"\"" :
            $"{group.SelectorParameter}.Equals(\"Published\", StringComparison.OrdinalIgnoreCase) ? \"{group.DefaultRoute.ToUpperInvariant()}\" : {group.SelectorParameter}.ToUpperInvariant()";
        var cases = workers.Select(w =>
            $"                ({(group.SelectorParameter is null ? "\"\"" : $"\"{w.RouteName.ToUpperInvariant()}\"")}, \"{SetName(w)}\") => \"{w.InternalNaming.VerbName}-{w.InternalNaming.Noun}\",");
        var removeSelector = group.SelectorParameter is null ? "" : $"\n            parameters.Remove(\"{group.SelectorParameter}\");";
        var supportsShouldProcess = naming.SourceMethod.Equals("GET", StringComparison.OrdinalIgnoreCase) ? "" :
            $", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.{(naming.SourceMethod.Equals("DELETE", StringComparison.OrdinalIgnoreCase) ? "High" : "Medium")}";
        var outputs = workers.Where(w => w.OutputType is not null).Select(w =>
            $"    [OutputType(typeof({w.OutputType}), ParameterSetName = new[] {{ \"{SetName(w)}\" }})]").Distinct();
        var dispatchSelection = group.AllowAsymmetricRoutes || group.AllowExplicitRouteSelection
            ? AsymmetricRouteSelection(group, workers) : $$"""
            var route = {{routeExpression}};
            var internalCmdletName = (route, ParameterSetName) switch
            {
{{string.Join("\n", cases)}}
                _ => throw new InvalidOperationException("Unsupported route and parameter set combination."),
            };
            var parameters = new Dictionary<string, object>(MyInvocation.BoundParameters);{{removeSelector}}
""";
        return $$"""
#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace {{ctx.CmdletNamespace}}
{
{{string.Join("\n", workers.Select(w => RouteAttr(w.Naming, SetName(w))))}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}", DefaultParameterSetName = "{{SetName(defaultWorker)}}"{{supportsShouldProcess}})]
{{string.Join("\n", outputs)}}
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{string.Join("\n\n", declarations)}}
{{selector}}
        protected override void ProcessRecord()
        {
{{dispatchSelection}}
            try
            {
                InvokeCommand.InvokeScript(
                    "param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters",
                    false,
                    PipelineResultTypes.Output | PipelineResultTypes.Error,
                    null,
                    parameters, internalCmdletName);
            }
            catch (RuntimeException rex) when (rex is not PipelineStoppedException && rex.ErrorRecord is not null)
            {
                ThrowTerminatingError(rex.ErrorRecord);
                return;
            }
{{CatchBlock("null")}}
        }
    }
}

""";
    }
}
