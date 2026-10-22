using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OpenApi;

namespace WrapperGenerator;

public sealed partial class PowerShellWrapperGenerationService
{
    private static void ValidateMixedMediaReadPolicy(MultiRouteGroup group, IReadOnlyList<MultiRouteOperation> operations)
    {
        if (!group.ApiVersion.Equals("beta", StringComparison.OrdinalIgnoreCase)
            || group.SelectorParameter != "Route" || !group.RequireExplicitRoute || group.DefaultRoute.Length != 0
            || !group.AllowExplicitRouteSelection || !group.AllowAsymmetricRoutes || !group.AllowResponseUnion
            || group.AllowPublishedParameterInference || group.IncludeDerivedSuppressedRoutes
            || group.AllowZeroArgumentFunctions || group.AllowMixedReadOperations || group.AllowMediaRoutes
            || group.AllowRouteSpecificBodies || group.AllowReferenceDelete || group.Routes.Count != 3
            || operations.Any(o => o.Naming.Kind != OperationKind.Resource
                || !o.Naming.SourceMethod.Equals("GET", StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("Mixed-media reads require the reviewed beta-only three-resource-GET policy with mandatory Route and no default or Published inference.");

        foreach (var kind in new[] { MultiRouteReadKind.Binary, MultiRouteReadKind.List, MultiRouteReadKind.Item })
        {
            if (group.Routes.Count(r => r.ReadKind == kind) != 1)
                throw new InvalidOperationException("Mixed-media reads require one explicit Binary, List and Item read plan.");
        }
        for (var i = 0; i < group.Routes.Count; i++)
        {
            var route = group.Routes[i];
            var operation = operations[i];
            if ((operation.Operation.Parameters ?? []).Any(p => p.In is not (ParameterLocation.Path or ParameterLocation.Query))
                || operation.PathItemParameters.Any(p => p.In != ParameterLocation.Path))
                throw new InvalidOperationException($"Unsupported mixed-media parameter location: {route.Path}.");
            if (route.Name != (route.ReadKind == MultiRouteReadKind.Binary ? "Binary" : "Recordings")
                || route.QueryBindings.Count != 0 || operation.Naming.HeaderParams.Count != 0)
                throw new InvalidOperationException("Mixed-media roles must be Binary and Recordings with the reviewed operation query/header contracts.");
            var expectedQueries = route.ReadKind switch
            {
                MultiRouteReadKind.Binary => Array.Empty<string>(),
                MultiRouteReadKind.List => new[] { "$top", "$skip", "$search", "$filter", "$count", "$orderby", "$select", "$expand" },
                _ => new[] { "$select", "$expand" },
            };
            var queries = (operation.Operation.Parameters ?? []).Where(p => p.In == ParameterLocation.Query).ToArray();
            if (queries.Length != expectedQueries.Length
                || !expectedQueries.ToHashSet(StringComparer.Ordinal).SetEquals(queries.Select(p => p.Name!))
                || queries.Any(p => p.Required || !IsSupportedMixedMediaQuery(p)))
                throw new InvalidOperationException($"Unsupported mixed-media query contract: {route.Path}.");
            if (route.ReadKind == MultiRouteReadKind.List)
            {
                var response = TryGetSuccessJsonSchema(operation.Operation);
                if (response is null || !IsStringNextLinkSchema(FindProperty(response, "@odata.nextLink")))
                    throw new InvalidOperationException($"Mixed-media JSON list requires a string '@odata.nextLink' pagination member: {route.Path}.");
            }
        }

        var binary = operations[group.Routes.ToList().FindIndex(r => r.ReadKind == MultiRouteReadKind.Binary)];
        var list = operations[group.Routes.ToList().FindIndex(r => r.ReadKind == MultiRouteReadKind.List)];
        var item = operations[group.Routes.ToList().FindIndex(r => r.ReadKind == MultiRouteReadKind.Item)];
        if (!binary.Naming.PathParamNames.SequenceEqual(list.Naming.PathParamNames)
            || !Naming.IsListItemPair(list.Naming, item.Naming)
            || HasBinarySuccessContent(list.Operation) || HasBinarySuccessContent(item.Operation))
            throw new InvalidOperationException("Mixed-media reads require the common-parent binary route and its typed JSON list/item family.");
    }

    private static bool IsSupportedMixedMediaQuery(IOpenApiParameter parameter)
    {
        var schema = parameter.Schema;
        if (schema is null)
            return false;
        return parameter.Name switch
        {
            "$top" or "$skip" => schema.Type == JsonSchemaType.Integer && (schema.Format is null or "int32"),
            "$count" => schema.Type == JsonSchemaType.Boolean,
            "$select" or "$expand" or "$orderby" => schema.Type == JsonSchemaType.Array && schema.Items?.Type == JsonSchemaType.String,
            "$filter" or "$search" => IsPlainStringQuery(parameter),
            _ => false,
        };
    }
}
