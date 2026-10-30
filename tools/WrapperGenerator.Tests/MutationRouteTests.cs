using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using WrapperGenerator;
using Xunit;
using static WrapperGenerator.CmdletConfigurator;

namespace WrapperGenerator.Tests;

public sealed class MutationRouteTests
{
    private const string Client = "Microsoft.Graph.PowerShell.Test.Client";
    private const string Entity = Client + ".Models.Widget";
    private const string Detail = Client + ".Models.Detail";
    private const string Root = "/profiles/{profile-id}/widgets";
    private const string Parent = Root + "/{parent-id}/widgets";

    [Theory]
    [InlineData("New", false)]
    [InlineData("New", true)]
    [InlineData("Update", false)]
    [InlineData("Update", true)]
    [InlineData("Set", false)]
    [InlineData("Set", true)]
    [InlineData("Remove", false)]
    [InlineData("Remove", true)]
    [InlineData("ActionEntity", false)]
    [InlineData("ActionEntity", true)]
    [InlineData("ActionVoid", false)]
    [InlineData("ActionVoid", true)]
    public async Task NaturalMutationFamiliesKeepExactMetadataTypedWorkersAndOneUnchangedSplat(
        string family, bool pathItemParameters)
    {
        var fixture = Create(family, pathItemParameters);
        var files = await Generate(fixture.Document, [fixture.Group]);
        var source = files[fixture.Stem + ".g.cs"];
        var shape = SetShape(family);
        var impact = family == "Remove" ? "High" : "Medium";
        var output = family is not ("Remove" or "ActionVoid");

        Assert.Equal(3, files.Count);
        Assert.Contains($"DefaultParameterSetName = \"Root{shape}\"", source);
        Assert.Contains("SupportsShouldProcess = true", source);
        Assert.Contains("ConfirmImpact = ConfirmImpact." + impact, source);
        Assert.DoesNotContain("ShouldProcess(", source);
        AssertForwarding(source);
        AssertNoSelectors(source);
        Assert.DoesNotContain("new " + Entity, source);
        Assert.DoesNotContain("PostRequestBody", source);
        Assert.Single(Regex.Matches(source, @"InvokeCommand\.InvokeScript\("));
        for (var i = 0; i < fixture.Group.Routes.Count; i++)
        {
            var route = fixture.Group.Routes[i];
            var set = route.FamilyName + shape;
            var worker = files[$"{fixture.Stem}_Route{i}.g.cs"];
            Assert.Contains($"[GraphRoute(\"{fixture.Method}\", \"{route.Path}\", ParameterSetName = \"{set}\")]", source);
            Assert.Contains($"\"{set}\" => \"{fixture.Verb}-{fixture.Noun}_Route{i}\"", source);
            Assert.Contains($"[GraphRoute(\"{fixture.Method}\", \"{route.Path}\")]", worker);
            Assert.DoesNotContain("ParameterSetName =", worker);
            Assert.Contains("SupportsShouldProcess = true", worker);
            Assert.Contains("ConfirmImpact = ConfirmImpact." + impact, worker);
            Assert.Single(Regex.Matches(worker, @"ShouldProcess\("));
            Assert.DoesNotContain("InvokeCommand.InvokeScript", worker);
            var builder = i == 0 ? "client.Profiles[ProfileId].Widgets"
                : "client.Profiles[ProfileId].Widgets[ParentId].Widgets";
            if (family != "New")
                builder += "[WidgetId]";
            if (family.StartsWith("Action", StringComparison.Ordinal))
                builder += ".Promote";
            Assert.Contains(builder + "." + MethodCall(family) + "(", worker);
            AssertMandatory(source, "ProfileId", set);
            if (family != "New")
                AssertMandatory(source, "WidgetId", set);
            if (i == 1)
                AssertMandatory(source, "ParentId", set);
            Assert.Contains("public string? ConsistencyLevel", source);
            Assert.Contains("requestConfiguration.Headers.Add(\"ConsistencyLevel\", ConsistencyLevel!)", worker);
            Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", worker);
            AssertCatchFilters(worker);
            if (output)
            {
                Assert.Contains($"[OutputType(typeof({Entity}), ParameterSetName = new[] {{ \"{set}\" }})]", source);
                Assert.Contains($"[OutputType(typeof({Entity}))]", worker);
            }
            else
            {
                Assert.DoesNotContain("[OutputType(", source);
                Assert.DoesNotContain("[OutputType(", worker);
                Assert.DoesNotContain("WriteObject(", worker);
            }
            if (family != "Remove")
            {
                AssertBodyParameters(source, set);
                AssertBodyAssignments(worker);
                if (family.StartsWith("Action", StringComparison.Ordinal))
                {
                    var typeNamespace = i == 0 ? "Profiles.Item.Widgets.Item.Promote"
                        : "Profiles.Item.Widgets.Item.Widgets.Item.Promote";
                    Assert.Contains($"new global::{Client}.{typeNamespace}.PromotePostRequestBody()", worker);
                }
                else
                    Assert.Contains("new " + Entity + "()", worker);
            }
            Assert.DoesNotContain(".GetAsync(", worker);
        }
        AssertCatchFilters(source, dispatcher: true);
    }

    [Theory]
    [InlineData("New")]
    [InlineData("Update")]
    [InlineData("Set")]
    [InlineData("Remove")]
    [InlineData("ActionEntity")]
    [InlineData("ActionVoid")]
    public async Task SameMutationConfigurationAppliesToBothIngestingProfiles(string family)
    {
        var fixture = Create(family);
        foreach (var profile in new[] { "v1.0", "beta" })
        {
            var files = await Generate(fixture.Document, [fixture.Group], apiVersion: profile);
            Assert.Equal(3, files.Count);
            Assert.Contains(fixture.Stem + ".g.cs", files.Keys);
        }
        Assert.Equal(3, typeof(OperationVariant).GetConstructors().Single(c => c.IsPublic).GetParameters().Length);
        Assert.Equal(2, typeof(OperationVariantGroup).GetConstructors().Single(c => c.IsPublic).GetParameters().Length);
    }

    [Theory]
    [InlineData("Update", true, false)]
    [InlineData("Update", false, true)]
    [InlineData("Update", true, true)]
    [InlineData("Update", false, false)]
    [InlineData("Set", true, false)]
    [InlineData("Set", false, true)]
    [InlineData("Set", true, true)]
    public async Task PatchRefetchUsesOnlyTheSelectedRoutesGetAndPutNeverFallsBack(
        string family, bool rootGet, bool parentGet)
    {
        var fixture = Create(family);
        foreach (var route in fixture.Group.Routes.Where((_, i) => i == 0 ? rootGet : parentGet))
            Add(fixture.Document, "GET", route.Path, new OpenApiOperation { Responses = JsonResponse(Reference(fixture.Document)) });

        var files = await Generate(fixture.Document, [fixture.Group]);

        for (var i = 0; i < 2; i++)
        {
            var source = files[$"{fixture.Stem}_Route{i}.g.cs"];
            var expected = family == "Update" && (i == 0 ? rootGet : parentGet);
            Assert.Equal(expected, source.Contains(".GetAsync()", StringComparison.Ordinal));
            Assert.Equal(expected, source.Contains("re-fetching the updated resource", StringComparison.Ordinal));
            Assert.Contains("." + MethodCall(family) + "(body,", source);
        }
        Assert.DoesNotContain(".GetAsync(", files[fixture.Stem + ".g.cs"]);
    }

    [Theory]
    [InlineData("New", "scalar")]
    [InlineData("Update", "scalar")]
    [InlineData("Set", "scalar")]
    [InlineData("ActionEntity", "scalar")]
    [InlineData("New", "complex")]
    [InlineData("Update", "complex")]
    [InlineData("Set", "complex")]
    [InlineData("ActionVoid", "complex")]
    [InlineData("New", "untyped")]
    [InlineData("Update", "untyped")]
    [InlineData("Set", "untyped")]
    [InlineData("ActionEntity", "untyped")]
    public async Task SharedPathBodyCollisionsKeepTheSameOptionalSuffixedPublicContract(string family, string kind)
    {
        var fixture = Create(family);
        foreach (var body in fixture.Bodies)
            body.Properties!["profileId"] = kind switch
            {
                "complex" => new OpenApiSchemaReference("microsoft.graph.detail", fixture.Document),
                "untyped" => new OpenApiSchema(),
                _ => new OpenApiSchema { Type = JsonSchemaType.String },
            };
        var files = await Generate(fixture.Document, [fixture.Group]);
        var source = files[fixture.Stem + ".g.cs"];
        var type = kind == "complex" ? Detail + "?" : kind == "untyped" ? "object?" : "string?";

        Assert.Single(Regex.Matches(source, @"public " + Regex.Escape(type) + @" ProfileId1 \{"));
        AssertMandatory(source, "ProfileId", "Root" + SetShape(family));
        AssertMandatory(source, "ProfileId", "Parent" + SetShape(family));
        foreach (var set in new[] { "Root", "Parent" })
            AssertOptional(source, "ProfileId1", type, set + SetShape(family));
        foreach (var i in new[] { 0, 1 })
        {
            var worker = files[$"{fixture.Stem}_Route{i}.g.cs"];
            Assert.Contains("body.ProfileId = " + (kind == "untyped" ? "untypedProfileId1" : "ProfileId1") + ";", worker);
            if (kind == "untyped")
                Assert.Contains("UntypedValue.From(ProfileId1)", worker);
            Assert.Contains("this.IsParameterBound(nameof(ProfileId1))", worker);
            Assert.DoesNotContain("public string? ProfileId ", worker);
        }
    }

    [Theory]
    [InlineData("ActionEntity", false)]
    [InlineData("ActionEntity", true)]
    [InlineData("ActionVoid", false)]
    [InlineData("ActionVoid", true)]
    public async Task BodylessActionsKeepOnlyNaturalPathIdsAndTheCorrectOutput(
        string family, bool pathItemParameters)
    {
        var fixture = Create(family, pathItemParameters);
        foreach (var route in fixture.Group.Routes)
            fixture.Document.Paths[route.Path].Operations![HttpMethod.Post].RequestBody = null;

        var files = await Generate(fixture.Document, [fixture.Group]);
        var source = files[fixture.Stem + ".g.cs"];

        AssertNoSelectors(source);
        AssertForwarding(source);
        Assert.DoesNotContain("ShouldProcess(", source);
        Assert.DoesNotContain("DisplayName", source);
        Assert.Equal(family == "ActionEntity", source.Contains("[OutputType(", StringComparison.Ordinal));
        foreach (var i in new[] { 0, 1 })
        {
            var worker = files[$"{fixture.Stem}_Route{i}.g.cs"];
            Assert.Contains(".PostAsync(requestConfiguration =>", worker);
            Assert.DoesNotContain("PostRequestBody", worker);
            Assert.DoesNotContain("var body", worker);
        }
    }

    [Theory]
    [InlineData("New", "201", false)]
    [InlineData("New", "2XX", true)]
    [InlineData("Update", "201", false)]
    [InlineData("Update", "2XX", true)]
    [InlineData("Set", "201", false)]
    [InlineData("Set", "2XX", true)]
    public async Task ResourceMutationsAcceptOrdinaryNamedEntitySuccessShapesAndOptionalNoContent(
        string family, string responseCode, bool includeNoContent)
    {
        var fixture = Create(family);
        foreach (var route in fixture.Group.Routes)
        {
            var operation = fixture.Document.Paths[route.Path].Operations![new HttpMethod(fixture.Method)];
            operation.Responses![responseCode] = operation.Responses["200"];
            operation.Responses.Remove("200");
            if (includeNoContent)
                operation.Responses["204"] = NoContent()["204"];
        }

        var files = await Generate(fixture.Document, [fixture.Group]);

        Assert.Equal(3, files.Count);
        Assert.Contains("[OutputType(typeof(" + Entity + ")", files[fixture.Stem + ".g.cs"]);
        foreach (var i in new[] { 0, 1 })
            Assert.Contains("." + MethodCall(family) + "(body,", files[$"{fixture.Stem}_Route{i}.g.cs"]);
    }

    [Theory]
    [InlineData("New", "void")]
    [InlineData("Update", "void")]
    [InlineData("Set", "void")]
    [InlineData("New", "inline-body")]
    [InlineData("Update", "inline-body")]
    [InlineData("Set", "inline-body")]
    public async Task UnsupportedHomogeneousResourceShapesDoNotInventNewOrdinaryEmitterForms(
        string family, string shape)
    {
        var fixture = Create(family);
        foreach (var route in fixture.Group.Routes)
        {
            var operation = fixture.Document.Paths[route.Path].Operations![new HttpMethod(fixture.Method)];
            if (shape == "void")
                operation.Responses = NoContent();
            else
                SetBody(operation, Body(fixture.Document));
        }

        await RejectBeforeWrites(fixture.Document, [fixture.Group]);
    }

    [Theory]
    [InlineData("body")]
    [InlineData("response")]
    public async Task ResponseUnionsAreKiotaOwnedWhileExpandedRequestBodiesStillRequireBindableProperties(string location)
    {
        var fixture = Create(location == "body" ? "New" : "ActionEntity");
        var inheritedUnion = new OpenApiSchema
        {
            OneOf =
            [
                new OpenApiSchemaReference("microsoft.graph.detail", fixture.Document),
                new OpenApiSchemaReference("microsoft.graph.otherDetail", fixture.Document),
            ],
        };
        if (location == "body")
            fixture.Bodies[0].AllOf = [inheritedUnion];
        else
        {
            fixture.Document.Components!.Schemas!["microsoft.graph.unionResult"] = new OpenApiSchema
            {
                Type = JsonSchemaType.Object, AllOf = [inheritedUnion],
            };
            foreach (var route in fixture.Group.Routes)
                fixture.Document.Paths[route.Path].Operations![HttpMethod.Post].Responses =
                    JsonResponse(new OpenApiSchemaReference("microsoft.graph.unionResult", fixture.Document));
        }

        if (location == "body")
            await RejectBeforeWrites(fixture.Document, [fixture.Group]);
        else
        {
            var files = await Generate(fixture.Document, [fixture.Group]);
            Assert.Equal(3, files.Count);
            Assert.Contains("[OutputType(typeof(object)", files[fixture.Stem + ".g.cs"]);
            Assert.Contains("object? result;", files[fixture.Stem + "_Route0.g.cs"]);
            Assert.Contains(".PostAsync(", files[fixture.Stem + "_Route0.g.cs"]);
            Assert.Contains("WriteObject(result);", files[fixture.Stem + "_Route0.g.cs"]);
        }
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(false, true)]
    [InlineData(true, false)]
    [InlineData(true, true)]
    public async Task NamedAndInlineActionResponseUnionsArePassedThroughToKiota(bool named, bool anyOf)
    {
        var fixture = Create("ActionEntity");
        var response = Choice(fixture.Document);
        if (anyOf)
        {
            response.AnyOf = response.OneOf;
            response.OneOf = null;
        }
        fixture.Document.Components!.Schemas!["microsoft.graph.unionResult"] = response;
        foreach (var route in fixture.Group.Routes)
            fixture.Document.Paths[route.Path].Operations![HttpMethod.Post].Responses = JsonResponse(named
                ? new OpenApiSchemaReference("microsoft.graph.unionResult", fixture.Document) : response);

        var files = await Generate(fixture.Document, [fixture.Group]);

        Assert.Equal(3, files.Count);
        Assert.Contains("[OutputType(typeof(object)", files[fixture.Stem + ".g.cs"]);
        foreach (var worker in files.Where(file => file.Key.Contains("_Route", StringComparison.Ordinal)))
        {
            Assert.Contains("object? result;", worker.Value);
            Assert.Contains(".PostAsync(", worker.Value);
            Assert.Contains("WriteObject(result);", worker.Value);
        }
    }

    [Theory]
    [InlineData("New")]
    [InlineData("Update")]
    [InlineData("Set")]
    [InlineData("Remove")]
    [InlineData("ActionVoid")]
    public async Task LowercaseConfiguredMethodsPreserveTheSameTypedSources(string family)
    {
        var fixture = Create(family);
        var expected = await Generate(fixture.Document, [fixture.Group]);
        var lowercase = fixture.Group with
        {
            Routes = fixture.Group.Routes.Select(route => route with { Method = route.Method.ToLowerInvariant() }).ToArray(),
        };

        var actual = await Generate(fixture.Document, [lowercase]);

        Assert.Equal(expected.Keys.Order(StringComparer.Ordinal), actual.Keys.Order(StringComparer.Ordinal));
        foreach (var file in expected)
            Assert.Equal(file.Value, actual[file.Key]);
    }

    [Theory]
    [InlineData("scalar", "New")]
    [InlineData("scalar", "Update")]
    [InlineData("scalar", "Set")]
    [InlineData("scalar", "ActionEntity")]
    [InlineData("complex", "New")]
    [InlineData("complex", "ActionVoid")]
    [InlineData("untyped", "Set")]
    [InlineData("untyped", "ActionEntity")]
    public async Task RouteUniqueBodyCollisionsCannotChangeAPublicNameOrType(string kind, string family)
    {
        var fixture = Create(family);
        foreach (var body in fixture.Bodies)
            body.Properties!["parentId"] = kind switch
            {
                "complex" => new OpenApiSchemaReference("microsoft.graph.detail", fixture.Document),
                "untyped" => new OpenApiSchema(),
                _ => new OpenApiSchema { Type = JsonSchemaType.String },
            };

        await RejectBeforeWrites(fixture.Document, [fixture.Group]);
    }

    [Theory]
    [InlineData("missing")]
    [InlineData("filtered")]
    [InlineData("wrong-method")]
    [InlineData("mixed-method")]
    [InlineData("mixed-kind")]
    [InlineData("mixed-function")]
    [InlineData("single")]
    [InlineData("empty")]
    [InlineData("duplicate")]
    [InlineData("duplicate-group")]
    [InlineData("invalid-label")]
    [InlineData("label-case")]
    [InlineData("missing-default")]
    [InlineData("nested-default")]
    [InlineData("identical-mandatory")]
    [InlineData("shadowed-mandatory")]
    [InlineData("different-noun")]
    [InlineData("wildcard")]
    [InlineData("empty-placeholder")]
    public async Task InvalidAndIncompleteMutationGroupsFailBeforeServiceOrCliOutput(string scenario)
    {
        var fixture = Create("Update");
        var document = fixture.Document;
        var group = fixture.Group;
        var right = Operation(fixture, 1);
        switch (scenario)
        {
            case "missing":
                document.Paths.Remove(group.Routes[1].Path);
                break;
            case "filtered":
                IncludePathFilter.Apply(document, [group.Routes[0].Path + "#PATCH"]);
                break;
            case "wrong-method":
                document.Paths[group.Routes[1].Path].Operations!.Remove(HttpMethod.Patch);
                Add(document, "POST", group.Routes[1].Path, right);
                break;
            case "mixed-method":
                document.Paths[group.Routes[1].Path].Operations!.Remove(HttpMethod.Patch);
                Add(document, "PUT", group.Routes[1].Path, right);
                group = group with { Routes = [group.Routes[0], group.Routes[1] with { Method = "PUT" }] };
                break;
            case "mixed-kind":
            case "mixed-function":
                right.Extensions = OperationType(scenario == "mixed-kind" ? "action" : "function");
                break;
            case "single":
                group = group with { Routes = [group.Routes[0]] };
                break;
            case "empty":
                group = group with { Routes = [] };
                break;
            case "duplicate":
                group = group with { Routes = [group.Routes[0], group.Routes[0] with { FamilyName = "Parent" }] };
                break;
            case "invalid-label":
                group = group with { Routes = [group.Routes[0], group.Routes[1] with { FamilyName = "not-a-label" }] };
                break;
            case "label-case":
                group = group with { Routes = [group.Routes[0], group.Routes[1] with { FamilyName = "rOoT" }] };
                break;
            case "missing-default":
                group = group with { DefaultFamily = "Missing" };
                break;
            case "nested-default":
                group = group with { DefaultFamily = "Parent" };
                break;
            case "identical-mandatory":
                group = MoveRight(fixture, Root + "/widgets/{widget-id}");
                break;
            case "shadowed-mandatory":
                group = MoveRight(fixture, "/profiles/{other-id}/widgets/{parent-id}/widgets/{widget-id}");
                break;
            case "different-noun":
                group = MoveRight(fixture, "/profiles/{profile-id}/otherResources/{widget-id}");
                break;
            case "wildcard":
                group = group with { Routes = [group.Routes[0], group.Routes[1] with { Path = Parent + "/*" }] };
                break;
            case "empty-placeholder":
                group = group with { Routes = [group.Routes[0], group.Routes[1] with { Path = Parent + "/{}" }] };
                break;
        }
        await RejectBeforeWrites(document, scenario == "duplicate-group" ? [group, group] : [group]);
    }

    [Fact]
    public async Task SuppressedMutationMemberCannotBeSilentlySkipped()
    {
        var fixture = Create("Update");
        const string suppressed = "/users/{user-id}/calendar";
        Assert.True(CmdletConfigurator.IsSuppressed(HttpMethod.Patch, suppressed));
        var group = MoveRight(fixture, suppressed);

        await RejectBeforeWrites(fixture.Document, [group]);
    }

    [Theory]
    [InlineData("body-required")]
    [InlineData("property-required")]
    [InlineData("property-type")]
    [InlineData("property-format")]
    [InlineData("property-name")]
    [InlineData("property-missing")]
    [InlineData("complex-type")]
    [InlineData("array-item-type")]
    [InlineData("untyped-to-string")]
    [InlineData("body-model")]
    [InlineData("missing-body")]
    [InlineData("body-union")]
    [InlineData("property-union")]
    [InlineData("body-media")]
    [InlineData("body-extra-media")]
    [InlineData("response-void")]
    [InlineData("response-model")]
    [InlineData("response-code")]
    [InlineData("response-union")]
    [InlineData("response-media")]
    [InlineData("response-primitive")]
    [InlineData("response-inline")]
    [InlineData("response-collection")]
    [InlineData("query")]
    [InlineData("query-mismatch")]
    [InlineData("cookie")]
    [InlineData("required-header")]
    [InlineData("header-type")]
    [InlineData("header-mismatch")]
    [InlineData("path-type")]
    [InlineData("path-not-required")]
    [InlineData("path-undeclared")]
    [InlineData("path-item-query")]
    [InlineData("path-item-header")]
    [InlineData("reference")]
    [InlineData("media-path")]
    [InlineData("function-path")]
    public async Task IncompatibleMutationBodyResponseAndBindingContractsAreRejected(string scenario)
    {
        var fixture = Create(scenario is "property-required" or "property-type" or "property-format"
            or "property-name" or "property-missing" or "complex-type" or "array-item-type"
            or "untyped-to-string" or "property-union" ? "ActionEntity" : "New");
        var right = Operation(fixture, 1);
        var body = fixture.Bodies[1];
        switch (scenario)
        {
            case "body-required":
                ((OpenApiRequestBody)right.RequestBody!).Required = false;
                break;
            case "property-required":
                body.Required = new HashSet<string> { "displayName", "enabled" };
                break;
            case "property-type":
                body.Properties!["displayName"] = new OpenApiSchema { Type = JsonSchemaType.Integer };
                break;
            case "property-format":
                body.Properties!["displayName"] = new OpenApiSchema { Type = JsonSchemaType.String, Format = "uuid" };
                break;
            case "property-name":
                body.Properties!["renamed"] = body.Properties["displayName"];
                body.Properties.Remove("displayName");
                break;
            case "property-missing":
                body.Properties!.Remove("payload");
                break;
            case "complex-type":
                body.Properties!["detail"] = new OpenApiSchemaReference("microsoft.graph.otherDetail", fixture.Document);
                break;
            case "array-item-type":
                body.Properties!["tags"] = new OpenApiSchema
                {
                    Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.Integer },
                };
                break;
            case "untyped-to-string":
                body.Properties!["payload"] = new OpenApiSchema { Type = JsonSchemaType.String };
                break;
            case "body-model":
                SetBody(right, Reference(fixture.Document, "microsoft.graph.otherWidget"));
                break;
            case "missing-body":
                right.RequestBody = null;
                break;
            case "body-union":
                SetBody(right, Choice(fixture.Document));
                break;
            case "property-union":
                body.Properties!["payload"] = Choice(fixture.Document);
                break;
            case "body-media":
                SetBody(right, new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" }, "application/octet-stream");
                break;
            case "body-extra-media":
                ((OpenApiRequestBody)right.RequestBody!).Content!["text/plain"] = new OpenApiMediaType
                {
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                };
                break;
            case "response-void":
                right.Responses = NoContent();
                break;
            case "response-model":
                right.Responses = JsonResponse(Reference(fixture.Document, "microsoft.graph.otherWidget"));
                break;
            case "response-code":
                right.Responses!["201"] = right.Responses["200"];
                right.Responses.Remove("200");
                break;
            case "response-union":
                right.Responses = JsonResponse(Choice(fixture.Document));
                break;
            case "response-media":
                right.Responses!["200"].Content!["application/octet-stream"] = new OpenApiMediaType
                {
                    Schema = new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" },
                };
                break;
            case "response-primitive":
                right.Responses = JsonResponse(new OpenApiSchema { Type = JsonSchemaType.String });
                break;
            case "response-inline":
                right.Responses = JsonResponse(new OpenApiSchema { Type = JsonSchemaType.Object });
                break;
            case "response-collection":
                right.Responses = JsonResponse(new OpenApiSchema
                {
                    Type = JsonSchemaType.Object,
                    Properties = new Dictionary<string, IOpenApiSchema>
                    {
                        ["value"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = Reference(fixture.Document) },
                    },
                });
                break;
            case "query":
                Operation(fixture, 0).Parameters!.Add(Parameter("$select", ParameterLocation.Query,
                    new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.String } }));
                right.Parameters!.Add(Parameter("$select", ParameterLocation.Query,
                    new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.String } }));
                break;
            case "query-mismatch":
                right.Parameters!.Add(Parameter("$filter", ParameterLocation.Query));
                break;
            case "cookie":
                right.Parameters!.Add(Parameter("session", ParameterLocation.Cookie));
                break;
            case "required-header":
                right.Parameters!.Add(Parameter("If-Match", ParameterLocation.Header, required: true));
                break;
            case "header-type":
                right.Parameters!.Add(Parameter("If-Match", ParameterLocation.Header,
                    new OpenApiSchema { Type = JsonSchemaType.Integer }));
                break;
            case "header-mismatch":
                right.Parameters!.Add(Parameter("If-Match", ParameterLocation.Header));
                break;
            case "path-type":
                right.Parameters!.Add(Parameter("parent-id", ParameterLocation.Path,
                    new OpenApiSchema { Type = JsonSchemaType.Integer }, required: true));
                break;
            case "path-not-required":
                right.Parameters!.Add(Parameter("parent-id", ParameterLocation.Path));
                break;
            case "path-undeclared":
                right.Parameters!.Add(Parameter("missing-id", ParameterLocation.Path, required: true));
                break;
            case "path-item-query":
            case "path-item-header":
                ((OpenApiPathItem)fixture.Document.Paths[fixture.Group.Routes[1].Path]).Parameters =
                    [Parameter("x-option", scenario == "path-item-query" ? ParameterLocation.Query : ParameterLocation.Header)];
                break;
            case "reference":
            case "media-path":
            case "function-path":
                var suffix = scenario == "reference" ? "/$ref" : scenario == "media-path" ? "/$value" : "/run()";
                fixture = fixture with { Group = MoveRight(fixture, fixture.Group.Routes[1].Path + suffix) };
                break;
        }
        await RejectBeforeWrites(fixture.Document, [fixture.Group]);
    }

    [Theory]
    [InlineData("ActionEntity", "void")]
    [InlineData("ActionVoid", "entity")]
    [InlineData("ActionEntity", "union")]
    [InlineData("ActionVoid", "media")]
    [InlineData("ActionEntity", "body-required")]
    [InlineData("ActionVoid", "property-required")]
    [InlineData("ActionEntity", "property-type")]
    [InlineData("ActionVoid", "property-missing")]
    [InlineData("ActionEntity", "body-union")]
    [InlineData("Remove", "entity")]
    [InlineData("Remove", "body")]
    [InlineData("Set", "void")]
    [InlineData("Update", "other-entity")]
    public async Task ActionsAndDeletesCannotHideHeterogeneousOutputOrBodyContracts(string family, string scenario)
    {
        var fixture = Create(family);
        var right = Operation(fixture, 1);
        switch (scenario)
        {
            case "void":
                right.Responses = NoContent();
                break;
            case "entity":
                right.Responses = JsonResponse(Reference(fixture.Document));
                break;
            case "other-entity":
                right.Responses = JsonResponse(Reference(fixture.Document, "microsoft.graph.otherWidget"));
                break;
            case "union":
                right.Responses = JsonResponse(Choice(fixture.Document));
                break;
            case "media":
                right.Responses = new OpenApiResponses
                {
                    ["200"] = new OpenApiResponse
                    {
                        Content = new Dictionary<string, IOpenApiMediaType>
                        {
                            ["application/octet-stream"] = new OpenApiMediaType
                            {
                                Schema = new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" },
                            },
                        },
                    },
                };
                break;
            case "body-required":
                ((OpenApiRequestBody)right.RequestBody!).Required = false;
                break;
            case "property-required":
                fixture.Bodies[1].Required = new HashSet<string> { "enabled" };
                break;
            case "property-type":
                fixture.Bodies[1].Properties!["enabled"] = new OpenApiSchema { Type = JsonSchemaType.String };
                break;
            case "property-missing":
                fixture.Bodies[1].Properties!.Remove("detail");
                break;
            case "body-union":
                SetBody(right, Choice(fixture.Document));
                break;
            case "body":
                SetBody(right, Reference(fixture.Document));
                break;
        }
        await RejectBeforeWrites(fixture.Document, [fixture.Group]);
    }

    [Theory]
    [InlineData("ParameterSetName", "body")]
    [InlineData("MyInvocation", "body")]
    [InlineData("InvokeCommand", "body")]
    [InlineData("ShouldProcess", "body")]
    [InlineData("UntypedValue", "body")]
    [InlineData("NewMgProfileWidgetCommand", "body")]
    [InlineData("newmgprofilewidgetcommand", "body")]
    [InlineData("OutBuffer", "body")]
    [InlineData("PipelineVariable", "body")]
    [InlineData("ob", "body")]
    [InlineData("pv", "body")]
    [InlineData("ParameterSetName", "path")]
    [InlineData("MyInvocation", "path")]
    [InlineData("InvokeCommand", "path")]
    [InlineData("ShouldProcess", "path")]
    [InlineData("UntypedValue", "path")]
    [InlineData("OutBuffer", "path")]
    [InlineData("PipelineVariable", "path")]
    [InlineData("ParameterSetName", "header")]
    [InlineData("MyInvocation", "header")]
    [InlineData("InvokeCommand", "header")]
    [InlineData("ShouldProcess", "header")]
    [InlineData("UntypedValue", "header")]
    [InlineData("NewMgProfileWidgetCommand", "header")]
    [InlineData("newmgprofilewidgetcommand", "header")]
    [InlineData("OutBuffer", "header")]
    [InlineData("PipelineVariable", "header")]
    [InlineData("ob", "header")]
    [InlineData("pv", "header")]
    [InlineData("1invalid", "body")]
    [InlineData("invalid.name", "header")]
    public async Task ReservedDispatcherMembersCommonParametersAliasesAndInvalidNamesRejectBeforeWrites(
        string name, string location)
    {
        var fixture = Create("New");
        if (location == "body")
        {
            foreach (var body in fixture.Bodies)
                body.Properties![name] = new OpenApiSchema { Type = JsonSchemaType.String };
        }
        else if (location == "header")
        {
            foreach (var route in fixture.Group.Routes)
                fixture.Document.Paths[route.Path].Operations![HttpMethod.Post].Parameters!.Add(
                    Parameter(name, ParameterLocation.Header));
        }
        else
        {
            var routes = fixture.Group.Routes.Select(route => route with
            {
                Path = route.Path.Replace("{profile-id}", "{" + name + "}", StringComparison.Ordinal),
            }).ToArray();
            for (var i = 0; i < routes.Length; i++)
            {
                var operation = Operation(fixture, i);
                operation.Parameters = [Parameter(name, ParameterLocation.Path, required: true), Parameter("ConsistencyLevel", ParameterLocation.Header)];
                fixture.Document.Paths.Remove(fixture.Group.Routes[i].Path);
                Add(fixture.Document, "POST", routes[i].Path, operation);
            }
            fixture = fixture with { Group = fixture.Group with { Routes = routes } };
        }
        await RejectBeforeWrites(fixture.Document, [fixture.Group]);
    }

    [Fact]
    public async Task EveryGroupIsPreflightedBeforeAnEarlierValidMutationGroupOrOrdinaryOperationWrites()
    {
        var first = Create("New");
        var second = Create("ActionVoid");
        foreach (var path in second.Document.Paths)
            first.Document.Paths.Add(path.Key, path.Value);
        var invalid = second.Group with { Routes = [second.Group.Routes[0], second.Group.Routes[1] with { Method = "DELETE" }] };
        Add(first.Document, "GET", "/otherResources/{otherResource-id}",
            new OpenApiOperation { Responses = JsonResponse(Reference(first.Document)) });

        await RejectBeforeWrites(first.Document, [first.Group, invalid]);
    }

    [Theory]
    [InlineData("New")]
    [InlineData("Update")]
    [InlineData("Set")]
    [InlineData("Remove")]
    [InlineData("ActionEntity")]
    [InlineData("ActionVoid")]
    public async Task OrdinaryStandaloneEmittersAndUnoptedCollisionsRemainUnchanged(string family)
    {
        var fixture = Create(family);
        var grouped = await Generate(fixture.Document, [fixture.Group]);
        var collision = await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(fixture.Document, useCollisionData: true));
        Assert.Contains("collision", collision.Message, StringComparison.OrdinalIgnoreCase);
        fixture.Document.Paths.Remove(fixture.Group.Routes[1].Path);

        var ordinary = await Generate(fixture.Document);

        Assert.Single(ordinary);
        var source = ordinary[fixture.Stem + ".g.cs"];
        Assert.Equal(source, grouped[fixture.Stem + "_Route0.g.cs"].Replace("_Route0", "", StringComparison.Ordinal));
        Assert.DoesNotContain("InvokeCommand.InvokeScript", source);
        Assert.DoesNotContain("DefaultParameterSetName", source);
        Assert.DoesNotContain("_Route", source);
        Assert.Contains("." + MethodCall(family) + "(", source);
    }

    [Fact]
    public async Task AbsentMutationGroupsAreANoOpInUnrelatedModules()
    {
        var fixture = Create("New");
        fixture.Document.Paths.Clear();
        Add(fixture.Document, "GET", "/otherResources/{otherResource-id}",
            new OpenApiOperation { Responses = JsonResponse(Reference(fixture.Document)) });

        var files = await Generate(fixture.Document, [fixture.Group]);

        Assert.Single(files);
        Assert.Contains("GetMgOtherResource.g.cs", files.Keys);
    }

    [Fact]
    public async Task OrdinaryCliCollisionStillWritesItsSpecMarkerBeforeFailure()
    {
        var fixture = Create("New");
        var output = OutputPath();
        var spec = Path.Combine(Directory.GetCurrentDirectory(), "ordinary-mutation-spec.yml");
        try
        {
            fixture.Document.RegisterComponents();
            var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => WrapperGenerator.Program.GenerateAsync(
                fixture.Document, new GeneratorConfig(Client, output, UseCollisionData: true),
                spec, NullLogger.Instance, CancellationToken.None));
            Assert.Contains("collision", ex.Message, StringComparison.OrdinalIgnoreCase);
            using var json = JsonDocument.Parse(File.ReadAllText(Path.Combine(output, "kiota-lock.json")));
            Assert.Equal(Path.GetRelativePath(output, spec).Replace('\\', '/'),
                json.RootElement.GetProperty("descriptionLocation").GetString());
            Assert.NotEmpty(Directory.GetFiles(output, "*.g.cs"));
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    [Theory]
    [InlineData("New", false)]
    [InlineData("New", true)]
    [InlineData("Update", false)]
    [InlineData("Update", true)]
    [InlineData("Set", false)]
    [InlineData("Set", true)]
    [InlineData("Remove", false)]
    [InlineData("Remove", true)]
    [InlineData("ActionEntity", false)]
    [InlineData("ActionEntity", true)]
    [InlineData("ActionVoid", false)]
    [InlineData("ActionVoid", true)]
    public async Task UngroupedMutationCannotOccupyAVariantDispatcherFilename(string family, bool collisionData)
    {
        var fixture = Create(family);
        var path = Root + "/{other-id}/widgets" + (family == "New" ? "" : "/{widget-id}")
            + (family.StartsWith("Action", StringComparison.Ordinal) ? "/promote" : "");
        var operation = Operation(fixture, 0);
        Add(fixture.Document, fixture.Method, path, operation);
        var kind = family.StartsWith("Action", StringComparison.Ordinal) ? OperationKind.Action : OperationKind.Resource;
        var naming = Naming.Resolve(new OperationInfo(new HttpMethod(fixture.Method), path, Kind: kind),
            new GeneratorConfig(Client, ".", UseCollisionData: collisionData));
        Assert.Equal(fixture.Stem + "Command", naming.ClassName);

        await RejectBeforeWrites(fixture.Document, [fixture.Group], collisionData);
    }

    private sealed record Fixture(OpenApiDocument Document, OperationVariantGroup Group,
        OpenApiSchema[] Bodies, string Family, string Method, string Verb, string Noun)
    {
        public string Stem => Verb + Noun;
    }

    private static Fixture Create(string family, bool pathItemParameters = false)
    {
        var document = new OpenApiDocument
        {
            Paths = new OpenApiPaths(),
            Components = new OpenApiComponents { Schemas = new Dictionary<string, IOpenApiSchema>() },
        };
        var bodies = new[] { Body(document), Body(document) };
        document.Components.Schemas!["microsoft.graph.widget"] = bodies[0];
        document.Components.Schemas["microsoft.graph.otherWidget"] = bodies[1];
        document.Components.Schemas["microsoft.graph.detail"] = new OpenApiSchema { Type = JsonSchemaType.Object };
        document.Components.Schemas["microsoft.graph.otherDetail"] = new OpenApiSchema { Type = JsonSchemaType.Object };
        var method = family switch
        {
            "Update" => "PATCH", "Set" => "PUT", "Remove" => "DELETE", _ => "POST",
        };
        var action = family.StartsWith("Action", StringComparison.Ordinal);
        var verb = action ? "Invoke" : family;
        var noun = "MgProfileWidget" + (action ? "Promote" : "");
        var paths = new[] { Root, Parent }.Select(path => path + (family == "New" ? "" : "/{widget-id}")
            + (action ? "/promote" : "")).ToArray();
        for (var i = 0; i < paths.Length; i++)
        {
            var operation = new OpenApiOperation
            {
                Responses = family is "Remove" or "ActionVoid" ? NoContent() : JsonResponse(Reference(document)),
                Parameters = [Parameter("ConsistencyLevel", ParameterLocation.Header)],
                Extensions = action ? OperationType("action") : pathItemParameters ? OperationType("operation") : null,
            };
            if (family != "Remove")
                SetBody(operation, action ? bodies[i] : Reference(document));
            var ids = Regex.Matches(paths[i], @"\{([^}]+)\}")
                .Select(match => (IOpenApiParameter)Parameter(match.Groups[1].Value, ParameterLocation.Path, required: true)).ToList();
            Add(document, method, paths[i], operation);
            if (pathItemParameters)
                ((OpenApiPathItem)document.Paths[paths[i]]).Parameters = ids;
            else
                foreach (var id in ids)
                    operation.Parameters.Add(id);
        }
        if (!action && family != "Remove")
            bodies[1] = bodies[0];
        return new(document, new([new(method, paths[0], "Root"), new(method, paths[1], "Parent")], "Root"),
            bodies, family, method, verb, noun);
    }

    private static OpenApiSchema Body(OpenApiDocument document) => new()
    {
        Type = JsonSchemaType.Object,
        Required = new HashSet<string> { "displayName" },
        Properties = new Dictionary<string, IOpenApiSchema>
        {
            ["id"] = new OpenApiSchema { Type = JsonSchemaType.String },
            ["displayName"] = new OpenApiSchema { Type = JsonSchemaType.String },
            ["profileId"] = new OpenApiSchema { Type = JsonSchemaType.String },
            ["enabled"] = new OpenApiSchema { Type = JsonSchemaType.Boolean },
            ["tags"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.String } },
            ["detail"] = new OpenApiSchemaReference("microsoft.graph.detail", document),
            ["details"] = new OpenApiSchema
            {
                Type = JsonSchemaType.Array, Items = new OpenApiSchemaReference("microsoft.graph.detail", document),
            },
            ["payload"] = new OpenApiSchema(),
        },
    };

    private static void AssertBodyParameters(string source, string set)
    {
        foreach (var (name, type) in new[]
        {
            ("DisplayName", "string?"), ("ProfileId1", "string?"), ("Enabled", "bool?"),
            ("Tags", "string[]?"), ("Detail", Detail + "?"), ("Details", Detail + "[]?"), ("Payload", "object?"),
        })
            AssertOptional(source, name, type, set);
        Assert.DoesNotContain("public string? Id ", source);
    }

    private static void AssertBodyAssignments(string source)
    {
        foreach (var assignment in new[]
        {
            "body.DisplayName = DisplayName;", "body.ProfileId = ProfileId1;", "body.Enabled = Enabled;",
            "body.Tags = Tags!.ToList();", "body.Detail = Detail;", "body.Details = Details!.ToList();",
            "UntypedValue.From(Payload)", "body.Payload = untypedPayload;",
        })
            Assert.Contains(assignment, source);
    }

    private static void AssertMandatory(string source, string parameter, string set) =>
        Assert.Contains($"[Parameter(Mandatory = true, ParameterSetName = \"{set}\"", Attributes(source, parameter, "string"));

    private static void AssertOptional(string source, string parameter, string type, string set) =>
        Assert.Contains($"[Parameter(Mandatory = false, ParameterSetName = \"{set}\"", Attributes(source, parameter, type));

    private static string Attributes(string source, string parameter, string type)
    {
        var declaration = source.IndexOf($"public {type} {parameter} ", StringComparison.Ordinal);
        Assert.True(declaration >= 0, $"Missing {type} parameter {parameter}.");
        var previous = source.LastIndexOf("public ", declaration - 1, StringComparison.Ordinal);
        return source[(previous < 0 ? 0 : previous)..declaration];
    }

    private static void AssertForwarding(string source)
    {
        Assert.Contains("& $CmdletName @BoundParameters", source);
        Assert.Contains("global::System.Management.Automation.Runspaces.PipelineResultTypes.Output | " +
            "global::System.Management.Automation.Runspaces.PipelineResultTypes.Error", source);
        Assert.Contains("MyInvocation.BoundParameters, internalCmdletName", source);
        Assert.DoesNotContain(".Remove(", source);
        Assert.DoesNotContain(".Add(", source);
    }

    private static void AssertNoSelectors(string source)
    {
        foreach (var parameter in new[] { "Route", "Published", "Root", "Parent", "BodyParameter" })
            Assert.DoesNotMatch(@"\bpublic\s+\S+\s+" + parameter + @"\s*\{", source);
        Assert.DoesNotContain("ValidateSet(", source);
        Assert.DoesNotContain("QueryParameters.", source);
    }

    private static void AssertCatchFilters(string source, bool dispatcher = false)
    {
        Assert.Contains("catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)", source);
        if (dispatcher)
        {
            Assert.Contains("catch (RuntimeException rex) when (rex is not PipelineStoppedException && rex.ErrorRecord is not null)", source);
            Assert.Contains("ThrowTerminatingError(rex.ErrorRecord)", source);
        }
    }

    private static string SetShape(string family) => family.StartsWith("Action", StringComparison.Ordinal) ? "Action" : family;

    private static string MethodCall(string family) => family switch
    {
        "Update" => "PatchAsync", "Set" => "PutAsync", "Remove" => "DeleteAsync", _ => "PostAsync",
    };

    private static Dictionary<string, IOpenApiExtension> OperationType(string type) =>
        new() { ["x-ms-docs-operation-type"] = new JsonNodeExtension(type) };

    private static OpenApiParameter Parameter(string name, ParameterLocation location,
        IOpenApiSchema? schema = null, bool required = false) => new()
    {
        Name = name, In = location, Required = required,
        Schema = schema ?? new OpenApiSchema { Type = JsonSchemaType.String },
    };

    private static IOpenApiSchema Reference(OpenApiDocument document, string name = "microsoft.graph.widget") =>
        new OpenApiSchemaReference(name, document);

    private static OpenApiSchema Choice(OpenApiDocument document) => new()
    {
        OneOf = [Reference(document), Reference(document, "microsoft.graph.otherWidget")],
    };

    private static OpenApiResponses JsonResponse(IOpenApiSchema schema) => new()
    {
        ["200"] = new OpenApiResponse
        {
            Content = new Dictionary<string, IOpenApiMediaType>
            {
                ["application/json"] = new OpenApiMediaType { Schema = schema },
            },
        },
    };

    private static OpenApiResponses NoContent() => new()
    {
        ["204"] = new OpenApiResponse { Description = "Success" },
    };

    private static void SetBody(OpenApiOperation operation, IOpenApiSchema schema, string contentType = "application/json") =>
        operation.RequestBody = new OpenApiRequestBody
        {
            Required = true,
            Content = new Dictionary<string, IOpenApiMediaType>
            {
                [contentType] = new OpenApiMediaType { Schema = schema },
            },
        };

    private static OpenApiOperation Operation(Fixture fixture, int index) =>
        fixture.Document.Paths[fixture.Group.Routes[index].Path].Operations![new HttpMethod(fixture.Method)];

    private static OperationVariantGroup MoveRight(Fixture fixture, string path)
    {
        var operation = Operation(fixture, 1);
        operation.Parameters = [Parameter("ConsistencyLevel", ParameterLocation.Header)];
        fixture.Document.Paths.Remove(fixture.Group.Routes[1].Path);
        Add(fixture.Document, fixture.Method, path, operation);
        return fixture.Group with { Routes = [fixture.Group.Routes[0], fixture.Group.Routes[1] with { Path = path }] };
    }

    private static void Add(OpenApiDocument document, string method, string path, OpenApiOperation operation)
    {
        if (!document.Paths.TryGetValue(path, out var item))
            document.Paths[path] = item = new OpenApiPathItem { Operations = new Dictionary<HttpMethod, OpenApiOperation>() };
        item.Operations![new HttpMethod(method)] = operation;
    }

    private static string OutputPath() =>
        Path.Combine(Directory.GetCurrentDirectory(), ".mutation-route-tests-" + Guid.NewGuid().ToString("N"));

    private static async Task<Dictionary<string, string>> Generate(OpenApiDocument document,
        IReadOnlyList<OperationVariantGroup>? groups = null, string apiVersion = "v1.0", bool useCollisionData = false)
    {
        var output = OutputPath();
        try
        {
            await GenerateAt(document, groups, output, apiVersion, useCollisionData);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(path => Path.GetFileName(path)!, File.ReadAllText);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }

    private static Task GenerateAt(OpenApiDocument document, IReadOnlyList<OperationVariantGroup>? groups, string output,
        string apiVersion = "v1.0", bool useCollisionData = false)
    {
        document.RegisterComponents();
        return new PowerShellWrapperGenerationService(document,
            new GeneratorConfig(Client, output, useCollisionData), NullLogger.Instance, apiVersion, RegisterGroups(groups))
            .GenerateAsync(CancellationToken.None);
    }

    private static async Task RejectBeforeWrites(OpenApiDocument document, IReadOnlyList<OperationVariantGroup> groups,
        bool collisionData = false)
    {
        document.RegisterComponents();
        foreach (var cli in new[] { false, true })
        foreach (var existing in new[] { false, true })
        {
            var output = OutputPath();
            const string generated = "Existing generated mutation source must survive.\r\n";
            const string marker = "{\"descriptionLocation\":\"original-spec.yml\"}\r\n";
            if (existing)
            {
                Directory.CreateDirectory(output);
                File.WriteAllText(Path.Combine(output, "Sentinel.g.cs"), generated);
                File.WriteAllText(Path.Combine(output, "kiota-lock.json"), marker);
                File.WriteAllText(Path.Combine(output, "keep.txt"), "unrelated");
            }
            try
            {
                var config = new GeneratorConfig(Client, output, UseCollisionData: collisionData);
                var entries = RegisterGroups(groups);
                var ex = await Assert.ThrowsAsync<InvalidOperationException>(() => cli
                    ? WrapperGenerator.Program.GenerateAsync(document, config,
                        Path.Combine(Directory.GetCurrentDirectory(), "mutation-spec.yml"), NullLogger.Instance, CancellationToken.None,
                        configurationEntries: entries)
                    : new PowerShellWrapperGenerationService(document, config, NullLogger.Instance, "v1.0", entries)
                        .GenerateAsync(CancellationToken.None));
                Assert.False(string.IsNullOrWhiteSpace(ex.Message));
                if (existing)
                {
                    Assert.Equal(generated, File.ReadAllText(Path.Combine(output, "Sentinel.g.cs")));
                    Assert.Equal(marker, File.ReadAllText(Path.Combine(output, "kiota-lock.json")));
                    Assert.Equal("unrelated", File.ReadAllText(Path.Combine(output, "keep.txt")));
                    Assert.Equal(3, Directory.GetFiles(output, "*", SearchOption.AllDirectories).Length);
                }
                else
                    Assert.False(Directory.Exists(output), "Group preflight must precede directory creation, stale cleanup and the CLI marker.");
            }
            finally
            {
                if (Directory.Exists(output))
                    Directory.Delete(output, recursive: true);
            }
        }
    }

    private static Entry[]? RegisterGroups(IReadOnlyList<OperationVariantGroup>? groups) =>
        groups?.Select(group => GroupVariants(group, "Isolated fixture registration")).ToArray();
}
