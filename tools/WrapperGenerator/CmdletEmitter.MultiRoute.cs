using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static WrapperGenerator.CmdletConfigurator;

namespace WrapperGenerator;

public static partial class CmdletEmitter
{
    public sealed record DispatchParameter(string Name, string Type, bool Mandatory = false, int? Position = null, string? Alias = null);

    public sealed record RouteWorker(CmdletNaming Naming, CmdletNaming InternalNaming, string RouteName,
        string Shape, IReadOnlyList<DispatchParameter> Parameters, string? OutputType);

    private static readonly HashSet<string> ReservedDispatchParameterNames = new(
        ["AccessToken", "Headers", "Verbose", "Debug", "ErrorAction", "WarningAction", "InformationAction",
         "ProgressAction", "ErrorVariable", "WarningVariable", "InformationVariable", "OutVariable",
         "OutBuffer", "PipelineVariable", "WhatIf", "Confirm", "ParameterSetName", "MyInvocation", "InvokeCommand",
         "ProcessRecord", "ShouldProcess", "WriteObject", "WriteVerbose", "ThrowTerminatingError",
         "ThrowGraphRequestFailed", "GetRequestAdapter", "AddRequestHeaders", "IsParameterBound", "UntypedValue", "Stopping", "StoppingToken",
         "vb", "db", "ea", "wa", "infa", "proga", "ev", "wv", "iv", "ov", "ob", "pv", "wi", "cf"],
        StringComparer.OrdinalIgnoreCase);

    internal static bool IsReservedParameterName(string name) => ReservedDispatchParameterNames.Contains(name);

    public static IReadOnlyList<DispatchParameter> GetDispatchParameters(
        CmdletNaming naming, string shape, IReadOnlySet<string> queryParams)
    {
        var parameters = naming.PathParamNames.Select((name, i) =>
            new DispatchParameter(name, "string", Mandatory: true, Position: i)).ToList();
        parameters.AddRange(naming.HeaderParams.Select(h => new DispatchParameter(h.PsName, "string?")));
        parameters.AddRange(CollectionQueryOptions.Where(q => queryParams.Contains(q.ODataName)
            && (shape == "List" || (shape == "Scalar" ? q.ODataName is "$filter" or "$search" : q.ODataName is "$select" or "$expand")))
            .Select(q => new DispatchParameter(q.PsName, q.ODataName switch
            {
                "$top" or "$skip" => "int",
                "$count" => "SwitchParameter",
                "$select" or "$expand" or "$orderby" => "string[]?",
                _ => "string?",
            }, Alias: q.ODataName switch { "$select" => "Select", "$expand" => "Expand", "$orderby" => "OrderBy", _ => null })));
        if (shape == "List")
            parameters.Add(new("All", "SwitchParameter"));
        return parameters;
    }

    internal static IReadOnlyList<DispatchParameter> GetBodyDispatchParameters(
        IReadOnlyList<CmdletProperty> properties, IReadOnlyList<ComplexParameter> complexProperties,
        IReadOnlyList<UntypedParameter> untypedProperties) =>
        [.. properties.Select(p => new DispatchParameter(p.ParameterName, p.PsTypeName + "?")),
         .. complexProperties.Select(p => new DispatchParameter(p.ParameterName, p.ElementNullableTypeName + "?")),
         .. untypedProperties.Select(p => new DispatchParameter(p.ParameterName, "object?"))];

    private static void ValidateRouteDispatch(OperationVariantGroup group, IReadOnlyList<RouteWorker> workers)
    {
        var isGet = workers.Count > 0 && workers[0].Naming.SourceMethod == "GET";
        if (workers.Count < 2 || workers.Count > 32
            || workers.Select(w => w.Naming.SourceMethod).Distinct(StringComparer.Ordinal).Count() != 1
            || workers.Select(w => w.Naming.Kind).Distinct().Count() != 1
            || workers.Any(w => isGet
                ? w.Naming.Kind != OperationKind.Resource || w.Shape is not ("List" or "Get" or "Scalar")
                : (w.Naming.SourceMethod, w.Naming.Kind, w.Shape) is not
                    (("POST", OperationKind.Resource, "New") or ("PATCH", OperationKind.Resource, "Update")
                    or ("PUT", OperationKind.Resource, "Set") or ("DELETE", OperationKind.Resource, "Remove")
                    or ("POST", OperationKind.Action, "Action")))
            || workers.Select(w => w.Naming.ClassName).Distinct(StringComparer.OrdinalIgnoreCase).Count() != 1
            || workers.Select(w => w.OutputType).Distinct(StringComparer.Ordinal).Count() != 1
            || workers.Select(w => w.Shape == "Scalar").Distinct().Count() != 1)
            throw new InvalidOperationException("Operation variants require one method, kind, public command and homogeneous output contract.");
        if (!isGet && workers.Select(w => string.Join("|", w.Parameters
            .Where(p => !w.Naming.PathParamNames.Contains(p.Name, StringComparer.OrdinalIgnoreCase))
            .OrderBy(p => p.Name, StringComparer.OrdinalIgnoreCase)
            .Select(p => $"{p.Name}:{p.Type}:{p.Mandatory}:{p.Alias}"))).Distinct(StringComparer.Ordinal).Count() != 1)
            throw new InvalidOperationException("Operation variants require identical public body and header parameters.");
        var defaults = workers.Where(w => w.RouteName == group.DefaultFamily).ToArray();
        if (defaults.Length == 0)
            throw new InvalidOperationException("Operation variants require an explicit root default family.");
        foreach (var family in workers.GroupBy(w => w.RouteName))
        {
            if (family.GroupBy(w => w.Shape).Any(s => s.Count() > 1)
                || (family.FirstOrDefault(w => w.Shape == "List") is { } list
                    && family.FirstOrDefault(w => w.Shape == "Get") is { } item
                    && !Naming.IsListItemPair(list.Naming, item.Naming)))
                throw new InvalidOperationException($"Operation family '{family.Key}' is not an unambiguous route or list/item pair.");
        }
        var defaultWorker = defaults.OrderBy(w => w.Shape == "List" ? 0 : 1).First();
        var defaultIds = defaultWorker.Naming.PathParamNames.ToHashSet(StringComparer.OrdinalIgnoreCase);
        for (var i = 0; i < workers.Count; i++)
        {
            var ids = workers[i].Naming.PathParamNames.ToHashSet(StringComparer.OrdinalIgnoreCase);
            if (workers.Take(i).Any(w => ids.SetEquals(w.Naming.PathParamNames)))
                throw new InvalidOperationException("Operation variants have identical mandatory path IDs; manually review distinguishing cmdlet nouns.");
            if (!defaultIds.IsSubsetOf(ids))
                throw new InvalidOperationException("Operation default must be the root path-ID set; a deeper default would shadow a route.");
            var parameters = workers[i].Parameters;
            if (!ids.SetEquals(parameters.Where(p => p.Mandatory).Select(p => p.Name))
                || parameters.GroupBy(p => p.Name, StringComparer.OrdinalIgnoreCase).Any(g => g.Count() > 1)
                || parameters.Any(p => !Regex.IsMatch(p.Name, "^[A-Za-z][A-Za-z0-9]*$", RegexOptions.CultureInvariant)
                    || ReservedDispatchParameterNames.Contains(p.Name)
                    || p.Name.Equals(workers[i].Naming.ClassName, StringComparison.OrdinalIgnoreCase)
                    || p.Name.Equals(workers[i].InternalNaming.ClassName, StringComparison.OrdinalIgnoreCase)
                    || (p.Alias is { } alias && ReservedDispatchParameterNames.Contains(alias))))
                throw new InvalidOperationException("Operation variant parameters must preserve distinct mandatory path IDs without name conflicts.");
        }
        var all = workers.SelectMany(w => w.Parameters).ToArray();
        var names = all.Select(p => p.Name).ToHashSet(StringComparer.OrdinalIgnoreCase);
        foreach (var alias in all.Where(p => p.Alias is not null).GroupBy(p => p.Alias!, StringComparer.OrdinalIgnoreCase))
            if (names.Contains(alias.Key) || alias.Select(p => p.Name).Distinct(StringComparer.OrdinalIgnoreCase).Count() != 1)
                throw new InvalidOperationException($"Operation variant alias '{alias.Key}' conflicts with a parameter.");
    }

    public static string EmitMultiRouteDispatcher(OperationVariantGroup group, IReadOnlyList<RouteWorker> workers, EmitContext ctx)
    {
        ValidateRouteDispatch(group, workers);
        static string SetName(RouteWorker worker) => worker.RouteName + worker.Shape;
        var naming = workers[0].Naming;
        var defaultWorker = workers.Where(w => w.RouteName == group.DefaultFamily).OrderBy(w => w.Shape == "List" ? 0 : 1).First();
        var declarations = new List<string>();
        foreach (var parameter in workers.SelectMany(w => w.Parameters).GroupBy(p => p.Name, StringComparer.OrdinalIgnoreCase))
        {
            var first = parameter.First();
            if (parameter.Any(p => p.Type != first.Type || p.Mandatory != first.Mandatory || p.Alias != first.Alias))
                throw new InvalidOperationException($"Incompatible operation variant parameter '{first.Name}'.");
            var attributes = workers.Where(w => w.Parameters.Any(p => p.Name.Equals(first.Name, StringComparison.OrdinalIgnoreCase)))
                .Select(w =>
                {
                    var p = w.Parameters.Single(p => p.Name.Equals(first.Name, StringComparison.OrdinalIgnoreCase));
                    var position = p.Position is { } i ? $", Position = {i}" : "";
                    return $"        [Parameter(Mandatory = {p.Mandatory.ToString().ToLowerInvariant()}, ParameterSetName = \"{SetName(w)}\"{position})]";
                });
            var alias = first.Alias is null ? "" : $"\n        [Alias(\"{EscapeLiteral(first.Alias)}\")]";
            var initializer = first.Type == "string" ? " = string.Empty;" : "";
            declarations.Add($"{string.Join("\n", attributes)}{alias}\n        public {first.Type} {first.Name} {{ get; set; }}{initializer}");
        }
        var mutation = naming.SourceMethod != "GET";
        var shouldProcess = mutation
            ? $", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.{(naming.SourceMethod == "DELETE" ? "High" : "Medium")}" : "";
        return $$"""
#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace {{ctx.CmdletNamespace}}
{
{{string.Join("\n", workers.Select(w => RouteAttr(w.Naming, SetName(w))))}}
    [Cmdlet({{naming.VerbsClass}}.{{naming.VerbName}}, "{{EscapeLiteral(naming.Noun)}}", DefaultParameterSetName = "{{SetName(defaultWorker)}}"{{shouldProcess}})]
{{string.Join("\n", workers.Where(w => w.OutputType is not null).Select(w => $"    [OutputType(typeof({w.OutputType}), ParameterSetName = new[] {{ \"{SetName(w)}\" }})]"))}}
    public class {{naming.ClassName}} : GraphClientCmdlet
    {
{{string.Join("\n\n", declarations)}}

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
{{string.Join("\n", workers.Select(w => $"                \"{SetName(w)}\" => \"{EscapeLiteral(w.InternalNaming.VerbName + "-" + w.InternalNaming.Noun)}\","))}}
                _ => throw new InvalidOperationException("Unsupported operation parameter set."),
            };
            try
            {
                InvokeCommand.InvokeScript(
                    "param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters",
                    false,
                    global::System.Management.Automation.Runspaces.PipelineResultTypes.Output | global::System.Management.Automation.Runspaces.PipelineResultTypes.Error,
                    null,
                    MyInvocation.BoundParameters, internalCmdletName);
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
