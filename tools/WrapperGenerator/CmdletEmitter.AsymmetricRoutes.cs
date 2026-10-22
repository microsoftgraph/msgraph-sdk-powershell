using System;
using System.Collections.Generic;
using System.Linq;

namespace WrapperGenerator;

public static partial class CmdletEmitter
{
    private static string AsymmetricRouteSelection(MultiRouteGroup group, IReadOnlyList<RouteWorker> workers)
    {
        static string Literal(string value) => $"\"{EscapeLiteral(value)}\"";
        static string Names(IEnumerable<string> names) =>
            "new string[] { " + string.Join(", ", names.Select(Literal)) + " }";

        var routes = workers.Select(w =>
            $"                ({Literal(w.RouteName)}, {Literal(group.SelectorParameter is null ? w.RouteName + w.Shape : w.Shape)}, "
            + $"{Literal(w.InternalNaming.VerbName + "-" + w.InternalNaming.Noun)}, "
            + $"{Names(w.Parameters.SelectMany(p => p.Alias is null ? new[] { p.Name } : new[] { p.Name, p.Alias! }))}, "
            + $"{Names(w.Parameters.Where(p => p.Mandatory).Select(p => p.Name))}),");
        var selector = group.SelectorParameter is { } name ? name : group.RequireExplicitRoute ? "\"\"" : "\"Published\"";
        var removeSelector = group.SelectorParameter is { } parameter
            ? $"\n            parameters.Remove({Literal(parameter)});"
            : "";
        var publishedCandidateFilter = group.RequireExplicitRoute ? "" : group.AllowExplicitRouteSelection
            ? group.AllowPublishedParameterInference
                ? "false"
                : $"!string.Equals(candidate.Label, {Literal(group.DefaultRoute)}, StringComparison.OrdinalIgnoreCase)"
            : "!string.Equals(candidate.Shape, ParameterSetName, StringComparison.OrdinalIgnoreCase)";
        var publishedDeclaration = group.RequireExplicitRoute ? "" :
            "\n            var publishedRoute = string.Equals(selectedRoute, \"Published\", StringComparison.OrdinalIgnoreCase);";
        var candidateFilter = group.RequireExplicitRoute
            ? "!string.Equals(candidate.Label, selectedRoute, StringComparison.OrdinalIgnoreCase)"
            : $"""
publishedRoute
                    ? {publishedCandidateFilter}
                    : !string.Equals(candidate.Label, selectedRoute, StringComparison.OrdinalIgnoreCase)
""";
        var defaultPreference = group.RequireExplicitRoute ? "" : $$"""
            if (publishedRoute)
            {
                var defaultRoutes = new List<int>();
                foreach (var routeIndex in compatibleRoutes)
                    if (string.Equals(routeCandidates[routeIndex].Label, {{Literal(group.DefaultRoute)}}, StringComparison.OrdinalIgnoreCase))
                        defaultRoutes.Add(routeIndex);
                if (defaultRoutes.Count > 0)
                    compatibleRoutes = defaultRoutes;
            }
""";

        return $$"""
            var parameters = new Dictionary<string, object>(MyInvocation.BoundParameters, StringComparer.OrdinalIgnoreCase);{{removeSelector}}
            var selectedRoute = {{selector}};{{publishedDeclaration}}
            var routeCandidates = new (string Label, string Shape, string Command, string[] Allowed, string[] Required)[]
            {
{{string.Join("\n", routes)}}
            };
            var ignoredRouteParameters = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                "Headers", "AccessToken", "Verbose", "Debug", "ErrorAction", "WarningAction",
                "InformationAction", "ProgressAction", "ErrorVariable", "WarningVariable",
                "InformationVariable", "OutVariable", "OutBuffer", "PipelineVariable", "WhatIf", "Confirm",
            };
            var compatibleRoutes = new List<int>();
            var routeDiagnostics = new List<string>();
            for (var routeIndex = 0; routeIndex < routeCandidates.Length; routeIndex++)
            {
                var candidate = routeCandidates[routeIndex];
                if ({{candidateFilter}})
                    continue;
                var allowed = new HashSet<string>(candidate.Allowed, StringComparer.OrdinalIgnoreCase);
                var missing = new List<string>();
                var unsupported = new List<string>();
                foreach (var requiredParameter in candidate.Required)
                    if (!parameters.ContainsKey(requiredParameter))
                        missing.Add(requiredParameter);
                foreach (var boundParameter in parameters.Keys)
                    if (!ignoredRouteParameters.Contains(boundParameter) && !allowed.Contains(boundParameter))
                        unsupported.Add(boundParameter);
                routeDiagnostics.Add(candidate.Label + "/" + candidate.Shape
                    + " (missing: " + (missing.Count == 0 ? "none" : string.Join(", ", missing))
                    + "; unsupported: " + (unsupported.Count == 0 ? "none" : string.Join(", ", unsupported)) + ")");
                if (missing.Count == 0 && unsupported.Count == 0)
                    compatibleRoutes.Add(routeIndex);
            }
{{defaultPreference}}
            if (compatibleRoutes.Count != 1)
            {
                var message = "Cannot select a unique Graph route for '" + selectedRoute
                    + "' (parameter set '" + ParameterSetName + "'). "
                    + (compatibleRoutes.Count == 0 ? "No compatible route. " : "Multiple compatible routes. ")
                    + string.Join("; ", routeDiagnostics);
                ThrowTerminatingError(new ErrorRecord(new ArgumentException(message),
                    "InvalidGraphRouteParameters", ErrorCategory.InvalidArgument, selectedRoute));
                return;
            }
            var internalCmdletName = routeCandidates[compatibleRoutes[0]].Command;
""";
    }
}
