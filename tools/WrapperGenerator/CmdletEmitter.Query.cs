using System;
using System.Collections.Generic;
using System.Linq;

namespace WrapperGenerator;

public static partial class CmdletEmitter
{
    private static IReadOnlyList<CmdletProperty> DeclaredQueries(CmdletNaming naming, EmitContext ctx)
    {
        var queries = ctx.RequiredQueries.Concat(ctx.RefetchRequiredQueries).ToArray();
        foreach (var group in queries.GroupBy(p => p.ParameterName, StringComparer.OrdinalIgnoreCase))
            if (group.Any(p => p.OpenApiName != group.First().OpenApiName || p.PsTypeName != group.First().PsTypeName))
                throw new InvalidOperationException($"Incompatible mutation/refetch required query '{group.Key}': {naming.SourceMethod} {naming.SourcePath}.");
        return queries.DistinctBy(p => p.ParameterName, StringComparer.OrdinalIgnoreCase).ToArray();
    }

    private static string RequiredQueryDeclarations(CmdletNaming naming, EmitContext ctx,
        string? parameterSetName = null, IEnumerable<string>? otherNames = null)
    {
        var queries = DeclaredQueries(naming, ctx);
        if (queries.Count == 0)
            return "";
        var taken = naming.PathParamNames.Concat(naming.FunctionParameters.Select(p => p.PsName))
            .Concat(naming.HeaderParams.Select(p => p.PsName)).Concat(otherNames ?? [])
            .Append(naming.ClassName).ToHashSet(StringComparer.OrdinalIgnoreCase);
        foreach (var query in queries)
            if (IsReservedParameterName(query.ParameterName) || !taken.Add(query.ParameterName))
                throw new InvalidOperationException(
                    $"Required query public parameter '{query.ParameterName}' conflicts with another parameter/member: {naming.SourceMethod} {naming.SourcePath}.");
        var set = parameterSetName is null ? "" : $", ParameterSetName = \"{parameterSetName}\"";
        return string.Concat(queries.Select((p, i) => $$"""

                [Parameter(Mandatory = true, Position = {{naming.PathParamNames.Count + naming.FunctionParameters.Count + i}}{{set}},
                    HelpMessage = "Value for the '{{EscapeLiteral(p.OpenApiName)}}' query parameter.")]
                [{{(p.PsTypeName == "string" || p.PsTypeName.EndsWith("[]", StringComparison.Ordinal) ? "ValidateNotNullOrEmpty" : "ValidateNotNull")}}]
                public {{p.PsTypeName}} {{p.ParameterName}} { get; set; }{{(p.PsTypeName == "string" ? " = string.Empty;" : p.PsTypeName.EndsWith("[]", StringComparison.Ordinal) ? " = default!;" : "")}}
        """));
    }

    private static string RequiredQueryBindings(IReadOnlyList<CmdletProperty> queries, string indent = "                    ") =>
        string.Concat(queries.Select(p => $"\n{indent}requestConfiguration.QueryParameters.{p.PascalName} = {p.ParameterName};"));

    private static CmdletProperty? RequiredTopParameter(CmdletNaming naming, EmitContext ctx)
    {
        var top = ctx.RequiredQueries.FirstOrDefault(p => p.OpenApiName == "$top");
        if (top is not null && top.PsTypeName is not ("int" or "long"))
            throw new InvalidOperationException($"Required query '$top' must be an integer for collection pagination: {naming.SourcePath}.");
        return top;
    }

    private static string PairedRequiredQueryDeclarations(CmdletNaming list, CmdletNaming item, EmitContext ctx,
        IReadOnlyList<CmdletProperty> listQueries, IReadOnlyList<CmdletProperty> itemQueries)
    {
        var otherNames = list.PathParamNames.Concat(item.PathParamNames)
            .Concat(list.HeaderParams.Select(h => h.PsName)).Concat(item.HeaderParams.Select(h => h.PsName)).Append("All");
        _ = RequiredQueryDeclarations(list, ctx with { RequiredQueries = listQueries, RefetchRequiredQueries = [] }, "List", otherNames);
        _ = RequiredQueryDeclarations(item, ctx with { RequiredQueries = itemQueries, RefetchRequiredQueries = [] }, "Get", otherNames);
        var declarations = new List<string>();
        foreach (var group in listQueries.Select((p, i) => (Parameter: p, Naming: list, Set: "List", Index: i))
            .Concat(itemQueries.Select((p, i) => (Parameter: p, Naming: item, Set: "Get", Index: i)))
            .GroupBy(p => p.Parameter.ParameterName, StringComparer.OrdinalIgnoreCase))
        {
            var first = group.First().Parameter;
            if (group.Any(p => p.Parameter.PsTypeName != first.PsTypeName || p.Parameter.OpenApiName != first.OpenApiName))
                throw new InvalidOperationException($"Incompatible paired GET required query parameter '{first.ParameterName}': {list.SourcePath}, {item.SourcePath}.");
            var attributes = string.Join("\n", group.Select(p =>
                $"        [Parameter(Mandatory = true, ParameterSetName = \"{p.Set}\", Position = {p.Naming.PathParamNames.Count + p.Index})]"));
            declarations.Add($$"""

        {{attributes}}
                [{{(first.PsTypeName == "string" || first.PsTypeName.EndsWith("[]", StringComparison.Ordinal) ? "ValidateNotNullOrEmpty" : "ValidateNotNull")}}]
                public {{first.PsTypeName}} {{first.ParameterName}} { get; set; }{{(first.PsTypeName == "string" ? " = string.Empty;" : first.PsTypeName.EndsWith("[]", StringComparison.Ordinal) ? " = default!;" : "")}}
        """);
        }
        return string.Join("\n", declarations);
    }

    private static IEnumerable<string> BodyParameterNames(IReadOnlyList<CmdletProperty> scalars,
        IReadOnlyList<ComplexParameter> complex, IReadOnlyList<UntypedParameter> untyped) =>
        scalars.Select(p => p.ParameterName).Concat(complex.Select(p => p.ParameterName)).Concat(untyped.Select(p => p.ParameterName));
}
