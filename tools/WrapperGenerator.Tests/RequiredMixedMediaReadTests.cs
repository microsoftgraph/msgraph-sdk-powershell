using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.OpenApi;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class RequiredMixedMediaReadTests
{
    private const string Client = "Microsoft.Graph.PowerShell.RequiredMixedMedia.Client";
    private const string Communications = "/communications/onlineMeetings/{onlineMeeting-id}";
    private const string Users = "/users/{user-id}/onlineMeetings/{onlineMeeting-id}";
    private static readonly string[] ListQueries = ["$top", "$skip", "$search", "$filter", "$count", "$orderby", "$select", "$expand"];

    [Fact]
    public void MixedMediaAndRequiredSelectionAreInitOnlyOptInsWithUnchangedPositionalRecords()
    {
        var route = new MultiRoute("GET", Communications + "/recording", "Binary");
        var group = new MultiRouteGroup("beta", [route], "Binary", "Route");
        var (method, path, name) = route;
        var (version, routes, defaultRoute, selector) = group;

        Assert.Equal(MultiRouteReadKind.Auto, route.ReadKind);
        Assert.False(group.AllowMixedMediaReads);
        Assert.False(group.RequireExplicitRoute);
        Assert.Equal(("GET", Communications + "/recording", "Binary"), (method, path, name));
        Assert.Equal(("beta", "Binary", "Route"), (version, defaultRoute, selector));
        Assert.Same(group.Routes, routes);
        Assert.Empty(route.QueryBindings);
        Assert.Equal(3, Assert.Single(typeof(MultiRoute).GetConstructors()).GetParameters().Length);
        Assert.Equal(4, Assert.Single(typeof(MultiRouteGroup).GetConstructors()).GetParameters().Length);
    }

    [Theory]
    [InlineData(false, "GetMgCommunicationOnlineMeetingRecording")]
    [InlineData(true, "GetMgUserOnlineMeetingRecording")]
    public async Task RequiredCloudRoutesKeepBinaryAndPagedJsonWorkersBehindOneMandatorySelector(bool userScoped, string stem)
    {
        var (document, group) = Fixture(userScoped);
        Assert.Empty(group.DefaultRoute);
        foreach (var route in group.Routes)
            Assert.Equal(stem, "Get" + Naming.Resolve(new OperationInfo(HttpMethod.Get, route.Path)).Noun);

        var files = await Generate(document, group);

        Assert.Equal(4, files.Count);
        var source = files[stem + ".g.cs"];
        Assert.Contains("DefaultParameterSetName = \"Route\"", source);
        Assert.Contains("[ValidateSet(\"Binary\", \"Recordings\")]", source);
        AssertParameter(source, "Route", mandatory: true);
        var selector = Declaration(source, "Route");
        foreach (var illegalDefault in new[] { "\"Published\"", "\"Binary\"", "\"Recordings\"" })
            Assert.DoesNotContain(illegalDefault, selector);
        Assert.DoesNotContain("[ValidateSet(\"Published\"", source);
        Assert.DoesNotContain("\"Published\"", source);
        Assert.DoesNotContain("defaultRoutes", source);
        var parentIds = userScoped ? new[] { "UserId", "OnlineMeetingId" } : ["OnlineMeetingId"];
        foreach (var id in parentIds)
            AssertParameter(source, id, mandatory: true);
        AssertParameter(source, "CallRecordingId", mandatory: false);
        AssertParameter(source, "OutFile", mandatory: false);
        AssertParameter(source, "All", mandatory: false);
        foreach (var name in new[] { "Property", "ExpandProperty", "Filter", "Search", "Sort", "Top", "Skip", "Count" })
            AssertParameter(source, name, mandatory: false);
        foreach (var alias in new[] { "Select", "Expand", "OrderBy" })
            Assert.Contains($"[Alias(\"{alias}\")]", source);
        Assert.Contains("[OutputType(typeof(byte[]), ParameterSetName = new[] { \"Route\" })]", source);
        Assert.Contains($"[OutputType(typeof({Client}.Models.CallRecording), ParameterSetName = new[] {{ \"Route\" }})]", source);
        foreach (var route in group.Routes)
            Assert.Contains($"[GraphRoute(\"GET\", \"{route.Path}\", ParameterSetName = \"Route\")]", source);
        Assert.DoesNotContain("SupportsShouldProcess", source);
        Assert.Contains("parameters.Remove(\"Route\")", source);
        Assert.DoesNotContain("parameters.Remove(\"OutFile\")", source);
        Assert.Contains("\"param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters\"", source);
        Assert.Contains("parameters, internalCmdletName", source);
        Assert.Contains("candidate.Required", source);
        Assert.Contains("candidate.Allowed", source);
        Assert.Contains("InvalidGraphRouteParameters", source);

        var binary = files[stem + "_Route0.g.cs"];
        var list = files[stem + "_Route1.g.cs"];
        var item = files[stem + "_Route2.g.cs"];
        var builder = userScoped ? "client.Users[UserId].OnlineMeetings[OnlineMeetingId]" : "client.Communications.OnlineMeetings[OnlineMeetingId]";
        Assert.Contains(builder + ".Recording.GetAsync(", binary);
        Assert.Contains("[OutputType(typeof(byte[]))]", binary);
        Assert.Contains("public string? OutFile", binary);
        Assert.Contains("}, StoppingToken)", binary);
        Assert.Contains("using (result)", binary);
        Assert.Contains("System.IO.File.Create(OutFile!)", binary);
        Assert.Contains("result.CopyTo(file)", binary);
        Assert.Contains("WriteObject(buffer.ToArray())", binary);
        Assert.DoesNotContain("public SwitchParameter All", binary);
        Assert.DoesNotContain("public string CallRecordingId", binary);

        Assert.Contains(builder + ".Recordings.GetAsync(", list);
        Assert.Contains($"[OutputType(typeof({Client}.Models.CallRecording))]", list);
        Assert.Contains(Client + ".Models.CallRecordingCollectionResponse? result", list);
        Assert.Contains("public SwitchParameter All", list);
        Assert.Contains("All.IsPresent", list);
        Assert.Contains(".WithUrl(nextLink)", list);
        Assert.Contains("WriteObject(items, enumerateCollection: true)", list);
        Assert.DoesNotContain("public string? OutFile", list);
        Assert.DoesNotContain("public string CallRecordingId", list);
        Assert.Contains(builder + ".Recordings[CallRecordingId].GetAsync(", item);
        Assert.Contains($"[OutputType(typeof({Client}.Models.CallRecording))]", item);
        AssertWorkerPathParameter(item, "CallRecordingId", parentIds.Length);
        Assert.DoesNotContain("public SwitchParameter All", item);
        Assert.DoesNotContain("public string? OutFile", item);
        for (var i = 0; i < parentIds.Length; i++)
            foreach (var worker in new[] { binary, list, item })
                AssertWorkerPathParameter(worker, parentIds[i], i);
        for (var i = 0; i < group.Routes.Count; i++)
            Assert.Contains($"[GraphRoute(\"GET\", \"{group.Routes[i].Path}\")]", files[stem + $"_Route{i}.g.cs"]);

        var binaryCandidate = Candidate(source, stem, 0);
        var listCandidate = Candidate(source, stem, 1);
        var itemCandidate = Candidate(source, stem, 2);
        Assert.Contains("\"OutFile\"", binaryCandidate);
        Assert.DoesNotContain("\"All\"", binaryCandidate);
        Assert.DoesNotContain("\"CallRecordingId\"", binaryCandidate);
        Assert.Contains("\"All\"", listCandidate);
        Assert.DoesNotContain("\"OutFile\"", listCandidate);
        Assert.Contains("\"CallRecordingId\"", itemCandidate);
        Assert.DoesNotContain("\"OutFile\"", itemCandidate);
        Assert.EndsWith(RequiredNames(parentIds), binaryCandidate);
        Assert.EndsWith(RequiredNames(parentIds), listCandidate);
        Assert.EndsWith(RequiredNames([.. parentIds, "CallRecordingId"]), itemCandidate);
        foreach (var generated in files.Values)
        {
            Assert.DoesNotContain("dynamic", generated);
            Assert.DoesNotContain("System.Reflection", generated);
        }
    }

    [Theory]
    [InlineData("mixed-media")]
    [InlineData("required-selector")]
    [InlineData("asymmetric")]
    [InlineData("explicit")]
    [InlineData("response-union")]
    [InlineData("selector")]
    public async Task EveryRequiredMixedMediaAuthorizationMustBePresent(string missing)
    {
        var (document, group) = Fixture();
        group = missing switch
        {
            "mixed-media" => group with { AllowMixedMediaReads = false },
            "required-selector" => group with { RequireExplicitRoute = false },
            "asymmetric" => group with { AllowAsymmetricRoutes = false },
            "explicit" => group with { AllowExplicitRouteSelection = false },
            "response-union" => group with { AllowResponseUnion = false },
            _ => group with { SelectorParameter = null },
        };

        await Reject(document, group);
    }

    [Theory]
    [InlineData("zero-argument")]
    [InlineData("route-bodies")]
    [InlineData("reference")]
    [InlineData("media")]
    [InlineData("mixed-function")]
    [InlineData("published-inference")]
    [InlineData("derived-suppression")]
    public async Task RequiredMixedMediaDoesNotAuthorizeOtherExtensionPolicies(string policy)
    {
        var (document, group) = Fixture();
        group = policy switch
        {
            "zero-argument" => group with { AllowZeroArgumentFunctions = true },
            "route-bodies" => group with { AllowRouteSpecificBodies = true },
            "reference" => group with { AllowReferenceDelete = true },
            "media" => group with { AllowMediaRoutes = true },
            "mixed-function" => group with { AllowMixedReadOperations = true },
            "published-inference" => group with { AllowPublishedParameterInference = true },
            _ => group with { IncludeDerivedSuppressedRoutes = true },
        };

        await Reject(document, group);
    }

    [Theory]
    [InlineData("Published")]
    [InlineData("Binary")]
    [InlineData("Recordings")]
    public async Task RequiredModeCannotHaveAnyDefaultRoute(string defaultRoute)
    {
        var (document, group) = Fixture();

        await Reject(document, group with { DefaultRoute = defaultRoute });
    }

    [Fact]
    public async Task RequiredMixedMediaPolicyIsBetaOnly()
    {
        var (document, group) = Fixture();

        await Reject(document, group with { ApiVersion = "v1.0" }, "v1.0");
    }

    [Fact]
    public async Task RequiredMixedMediaDoesNotAllowAnAlternativeSelectorName()
    {
        var (document, group) = Fixture();

        await Reject(document, group with { SelectorParameter = "Format" });
    }

    [Fact]
    public async Task RequiredMixedMediaCannotOmitTheJsonItemRole()
    {
        var (document, group) = Fixture();
        document.Paths.Remove(group.Routes[2].Path);

        await Reject(document, group with { Routes = group.Routes.Take(2).ToArray() });
    }

    [Fact]
    public async Task RequiredMixedMediaDoesNotAuthorizeResourceMutations()
    {
        var (document, group) = Fixture();
        var routes = group.Routes.Select(route => route with { Method = "PATCH" }).ToArray();
        foreach (var route in routes)
        {
            var operation = document.Paths[route.Path].Operations![HttpMethod.Get];
            ((OpenApiPathItem)document.Paths[route.Path]).Operations =
                new Dictionary<HttpMethod, OpenApiOperation> { [HttpMethod.Patch] = operation };
        }

        await Reject(document, group with { Routes = routes });
    }

    [Theory]
    [InlineData("binary-label")]
    [InlineData("recordings-label")]
    [InlineData("item-label")]
    [InlineData("binary-auto")]
    [InlineData("list-auto")]
    [InlineData("item-auto")]
    [InlineData("wrong-read-kind")]
    [InlineData("unknown-read-kind")]
    public async Task RequiredMixedMediaUsesOnlyTheReviewedLabelsAndReadKinds(string difference)
    {
        var (document, group) = Fixture();
        var routes = group.Routes.ToArray();
        switch (difference)
        {
            case "binary-label": routes[0] = routes[0] with { Name = "Content" }; break;
            case "recordings-label":
                routes[1] = routes[1] with { Name = "Json" };
                routes[2] = routes[2] with { Name = "Json" };
                break;
            case "item-label": routes[2] = routes[2] with { Name = "Item" }; break;
            case "binary-auto": routes[0] = routes[0] with { ReadKind = MultiRouteReadKind.Auto }; break;
            case "list-auto": routes[1] = routes[1] with { ReadKind = MultiRouteReadKind.Auto }; break;
            case "item-auto": routes[2] = routes[2] with { ReadKind = MultiRouteReadKind.Auto }; break;
            case "wrong-read-kind": routes[0] = routes[0] with { ReadKind = MultiRouteReadKind.Item }; break;
            default: routes[0] = routes[0] with { ReadKind = (MultiRouteReadKind)99 }; break;
        }

        await Reject(document, group with { Routes = routes });
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public async Task RequiredMixedMediaDoesNotPermitExplicitQueryBindingsOnAnyRole(int index)
    {
        var (document, group) = Fixture();
        var routes = group.Routes.ToArray();
        routes[index] = routes[index] with { QueryBindings = [new("extra", "Extra")] };

        await Reject(document, group with { Routes = routes });
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public async Task RequiredMixedMediaRejectsRequiredCookiesOnEveryRole(int index)
    {
        var (document, group) = Fixture();
        var cookie = Parameter("sessionCookie", ParameterLocation.Cookie);
        cookie.Required = true;
        var operation = Operation(document, group.Routes[index]);
        operation.Parameters ??= new List<IOpenApiParameter>();
        operation.Parameters.Add(cookie);

        await Reject(document, group);
    }

    [Theory]
    [InlineData(null)]
    [InlineData((ParameterLocation)99)]
    public async Task RequiredMixedMediaRejectsUnspecifiedOrUnknownOperationParameterLocations(ParameterLocation? location)
    {
        var (document, group) = Fixture();
        Operation(document, group.Routes[1]).Parameters!.Add(new OpenApiParameter
        {
            Name = "unboundParameter",
            In = location,
            Required = true,
            Schema = new OpenApiSchema { Type = JsonSchemaType.String },
        });

        await Reject(document, group);
    }

    [Theory]
    [InlineData(ParameterLocation.Cookie)]
    [InlineData(null)]
    [InlineData((ParameterLocation)99)]
    public async Task RequiredMixedMediaRejectsInheritedNonPathParameterLocations(ParameterLocation? location)
    {
        var (document, group) = Fixture();
        ((OpenApiPathItem)document.Paths[group.Routes[2].Path]).Parameters =
        [
            new OpenApiParameter
            {
                Name = "unboundInheritedParameter",
                In = location,
                Required = true,
                Schema = new OpenApiSchema { Type = JsonSchemaType.String },
            },
        ];

        await Reject(document, group);
    }

    [Theory]
    [InlineData("function")]
    [InlineData("binary-query")]
    [InlineData("list-query-missing")]
    [InlineData("item-query-missing")]
    [InlineData("query-type")]
    [InlineData("list-select-scalar")]
    [InlineData("item-select-scalar")]
    [InlineData("query-addition")]
    [InlineData("required-query")]
    [InlineData("binary-json")]
    [InlineData("list-binary")]
    [InlineData("item-binary")]
    [InlineData("list-entity")]
    [InlineData("item-collection")]
    [InlineData("body")]
    [InlineData("empty-body")]
    [InlineData("header-drift")]
    [InlineData("path-item-query")]
    [InlineData("path-item-header")]
    public async Task ExplicitReadKindsDoNotOverrideIncompatibleOperationContracts(string difference)
    {
        var (document, group) = Fixture();
        var binary = Operation(document, group.Routes[0]);
        var list = Operation(document, group.Routes[1]);
        var item = Operation(document, group.Routes[2]);
        switch (difference)
        {
            case "function":
                binary.Extensions = new Dictionary<string, IOpenApiExtension> { ["x-ms-docs-operation-type"] = new JsonNodeExtension("function") };
                break;
            case "binary-query": binary.Parameters = [Parameter("$select", ParameterLocation.Query)]; break;
            case "list-query-missing": list.Parameters!.RemoveAt(0); break;
            case "item-query-missing": item.Parameters!.RemoveAt(0); break;
            case "query-type":
                ((OpenApiParameter)list.Parameters!.Single(parameter => parameter.Name == "$top")).Schema =
                    new OpenApiSchema { Type = JsonSchemaType.String };
                break;
            case "list-select-scalar":
            case "item-select-scalar":
                ((OpenApiParameter)(difference == "list-select-scalar" ? list : item).Parameters!
                    .Single(parameter => parameter.Name == "$select")).Schema = new OpenApiSchema { Type = JsonSchemaType.String };
                break;
            case "query-addition": list.Parameters!.Add(Parameter("model", ParameterLocation.Query)); break;
            case "required-query": ((OpenApiParameter)list.Parameters![0]).Required = true; break;
            case "binary-json": binary.Responses = JsonResponse(new OpenApiSchemaReference("microsoft.graph.callRecording", document)); break;
            case "list-binary": list.Responses = binary.Responses; break;
            case "item-binary": item.Responses = binary.Responses; break;
            case "list-entity": list.Responses = JsonResponse(new OpenApiSchemaReference("microsoft.graph.callRecording", document)); break;
            case "item-collection": item.Responses = JsonResponse(Collection(document)); break;
            case "body":
                item.RequestBody = new OpenApiRequestBody
                {
                    Required = true,
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["text/plain"] = new OpenApiMediaType { Schema = new OpenApiSchema { Type = JsonSchemaType.String } },
                    },
                };
                break;
            case "empty-body": item.RequestBody = new OpenApiRequestBody(); break;
            case "header-drift": item.Parameters = [Parameter("ConsistencyLevel", ParameterLocation.Header)]; break;
            default:
                ((OpenApiPathItem)document.Paths[group.Routes[2].Path]).Parameters =
                    [Parameter("inherited", difference == "path-item-query" ? ParameterLocation.Query : ParameterLocation.Header)];
                break;
        }

        await Reject(document, group);
    }

    [Fact]
    public async Task MixedMediaCannotUnifyDriftingParentIdBindings()
    {
        var (document, group) = Fixture();
        var binary = group.Routes[0];
        var changed = binary with { Path = binary.Path.Replace("{onlineMeeting-id}", "{meeting-id}", StringComparison.Ordinal) };
        var operation = Operation(document, binary);
        document.Paths.Remove(binary.Path);
        Add(document, changed.Path, operation);

        await Reject(document, group with { Routes = [changed, group.Routes[1], group.Routes[2]] });
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task MixedMediaListRequiresAnActualStringPaginationMember(bool wrongType)
    {
        var (document, group) = Fixture();
        var response = (OpenApiSchema)Operation(document, group.Routes[1]).Responses!["200"].Content!["application/json"].Schema!;
        if (wrongType)
            response.Properties!["@odata.nextLink"] = new OpenApiSchema { Type = JsonSchemaType.Integer };
        else
            response.Properties!.Remove("@odata.nextLink");

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("@odata.nextLink", error.Message);
        Assert.Contains("pagination", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task MixedMediaListAcceptsNullableStringPagination()
    {
        var (document, group) = Fixture();
        var response = (OpenApiSchema)Operation(document, group.Routes[1]).Responses!["200"].Content!["application/json"].Schema!;
        response.Properties!["@odata.nextLink"] = new OpenApiSchema { Type = JsonSchemaType.String | JsonSchemaType.Null };

        var files = await Generate(document, group);

        Assert.Equal(4, files.Count);
        Assert.Contains(".WithUrl(nextLink)", files["GetMgCommunicationOnlineMeetingRecording_Route1.g.cs"]);
    }

    [Fact]
    public async Task BinaryResponseUnionDoesNotAuthorizeDifferentJsonListAndItemEntities()
    {
        var (document, group) = Fixture();
        document.Components!.Schemas!["microsoft.graph.otherRecording"] = new OpenApiSchema { Type = JsonSchemaType.Object };
        Operation(document, group.Routes[2]).Responses = JsonResponse(new OpenApiSchemaReference("microsoft.graph.otherRecording", document));

        var error = await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));

        Assert.Contains("same recording entity type", error.Message, StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public async Task RequiredMixedMediaRetainsOnlyTheSixReviewedPathsWithoutRestoringAggregateAliases()
    {
        var (document, communications) = Fixture();
        var (userDocument, users) = Fixture(userScoped: true);
        foreach (var path in userDocument.Paths)
            document.Paths[path.Key] = path.Value;
        foreach (var root in new[] { "/communications/onlineMeetings", "/users/{user-id}/onlineMeetings" })
        {
            var alias = root + "/getAllRecordings(meetingOrganizerUserId='@meetingOrganizerUserId',startDateTime=@startDateTime,endDateTime=@endDateTime)";
            Add(document, alias, new OpenApiOperation
            {
                Extensions = new Dictionary<string, IOpenApiExtension> { ["x-ms-docs-operation-type"] = new JsonNodeExtension("function") },
                Responses = JsonResponse(Collection(document)),
            });
        }

        var files = await Generate(document, new[] { communications, users });

        Assert.Equal(8, files.Count);
        var sources = string.Join("\n", files.Values);
        Assert.DoesNotContain("getAllRecordings", sources, StringComparison.OrdinalIgnoreCase);
        Assert.Equal(12, sources.Split("[GraphRoute(", StringSplitOptions.None).Length - 1);
        foreach (var route in communications.Routes.Concat(users.Routes))
            Assert.Equal(2, files.Values.Count(source => source.Contains($"[GraphRoute(\"GET\", \"{route.Path}\"", StringComparison.Ordinal)));
    }

    [Fact]
    public async Task AnUnreviewedAutoRecordingReadKeepsItsOriginalTypedItemSurface()
    {
        var (document, group) = Fixture();
        document.Paths.Remove(group.Routes[0].Path);
        document.Paths.Remove(group.Routes[1].Path);

        var files = await Generate(document, Array.Empty<MultiRouteGroup>());

        var source = Assert.Single(files).Value;
        Assert.Contains($"[GraphRoute(\"GET\", \"{group.Routes[2].Path}\")]", source);
        Assert.Contains($"[OutputType(typeof({Client}.Models.CallRecording))]", source);
        AssertWorkerPathParameter(source, "OnlineMeetingId", 0);
        AssertWorkerPathParameter(source, "CallRecordingId", 1);
        Assert.DoesNotContain("public string Route", source);
        Assert.DoesNotContain("public string? OutFile", source);
        Assert.DoesNotContain("CallRecordingCollectionResponse", source);
    }

    private static (OpenApiDocument Document, MultiRouteGroup Group) Fixture(bool userScoped = false)
    {
        var root = userScoped ? Users : Communications;
        var routes = new[]
        {
            new MultiRoute("GET", root + "/recording", "Binary") { ReadKind = MultiRouteReadKind.Binary },
            new MultiRoute("GET", root + "/recordings", "Recordings") { ReadKind = MultiRouteReadKind.List },
            new MultiRoute("GET", root + "/recordings/{callRecording-id}", "Recordings") { ReadKind = MultiRouteReadKind.Item },
        };
        var document = new OpenApiDocument
        {
            Paths = new OpenApiPaths(),
            Components = new OpenApiComponents
            {
                Schemas = new Dictionary<string, IOpenApiSchema>
                {
                    ["microsoft.graph.callRecording"] = new OpenApiSchema
                    {
                        Type = JsonSchemaType.Object,
                        Properties = new Dictionary<string, IOpenApiSchema> { ["id"] = new OpenApiSchema { Type = JsonSchemaType.String } },
                    },
                },
            },
        };
        Add(document, routes[0].Path, new OpenApiOperation
        {
            Responses = new OpenApiResponses
            {
                ["200"] = new OpenApiResponse
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["application/octet-stream"] = new OpenApiMediaType { Schema = new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" } },
                    },
                },
            },
        });
        Add(document, routes[1].Path, new OpenApiOperation { Responses = JsonResponse(Collection(document)), Parameters = Queries(ListQueries) });
        Add(document, routes[2].Path, new OpenApiOperation
        {
            Responses = JsonResponse(new OpenApiSchemaReference("microsoft.graph.callRecording", document)),
            Parameters = Queries("$select", "$expand"),
        });
        return (document, new MultiRouteGroup("beta", routes, "", "Route")
        {
            AllowMixedMediaReads = true,
            RequireExplicitRoute = true,
            AllowAsymmetricRoutes = true,
            AllowExplicitRouteSelection = true,
            AllowResponseUnion = true,
        });
    }

    private static OpenApiSchema Collection(OpenApiDocument document) => new()
    {
        Type = JsonSchemaType.Object,
        Properties = new Dictionary<string, IOpenApiSchema>
        {
            ["value"] = new OpenApiSchema { Type = JsonSchemaType.Array, Items = new OpenApiSchemaReference("microsoft.graph.callRecording", document) },
            ["@odata.nextLink"] = new OpenApiSchema { Type = JsonSchemaType.String },
        },
    };

    private static OpenApiResponses JsonResponse(IOpenApiSchema schema) => new()
    {
        ["200"] = new OpenApiResponse
        {
            Content = new Dictionary<string, IOpenApiMediaType> { ["application/json"] = new OpenApiMediaType { Schema = schema } },
        },
    };

    private static OpenApiParameter Parameter(string name, ParameterLocation location) => new()
    {
        Name = name, In = location, Schema = new OpenApiSchema { Type = JsonSchemaType.String },
    };

    private static List<IOpenApiParameter> Queries(params string[] names) => names.Select(name => (IOpenApiParameter)new OpenApiParameter
    {
        Name = name,
        In = ParameterLocation.Query,
        Schema = name switch
        {
            "$top" or "$skip" => new OpenApiSchema { Type = JsonSchemaType.Integer, Format = "int32" },
            "$count" => new OpenApiSchema { Type = JsonSchemaType.Boolean },
            "$select" or "$expand" or "$orderby" => new OpenApiSchema
            {
                Type = JsonSchemaType.Array, Items = new OpenApiSchema { Type = JsonSchemaType.String },
            },
            _ => new OpenApiSchema { Type = JsonSchemaType.String },
        },
    }).ToList();

    private static OpenApiOperation Operation(OpenApiDocument document, MultiRoute route) =>
        document.Paths[route.Path].Operations![HttpMethod.Get];

    private static void Add(OpenApiDocument document, string path, OpenApiOperation operation) =>
        document.Paths[path] = new OpenApiPathItem
        {
            Operations = new Dictionary<HttpMethod, OpenApiOperation> { [HttpMethod.Get] = operation },
        };

    private static string Declaration(string source, string name) =>
        Assert.Single(source.ReplaceLineEndings("\n").Split('\n'), line => line.Contains(" " + name + " { get; set; }", StringComparison.Ordinal));

    private static void AssertParameter(string source, string name, bool mandatory)
    {
        var lines = source.ReplaceLineEndings("\n").Split('\n');
        var index = Array.FindIndex(lines, line => line.Contains(" " + name + " { get; set; }", StringComparison.Ordinal));
        Assert.True(index > 0, "Missing public parameter " + name);
        var attributes = new List<string>();
        for (var i = index - 1; i >= 0 && lines[i].TrimStart().StartsWith('['); i--)
            attributes.Add(lines[i]);
        Assert.Contains(attributes, attribute => attribute.Contains("Mandatory = " + mandatory.ToString().ToLowerInvariant(), StringComparison.Ordinal));
    }

    private static void AssertWorkerPathParameter(string source, string name, int position)
    {
        var lines = source.ReplaceLineEndings("\n").Split('\n');
        var index = Array.FindIndex(lines, line => line.Contains("public string " + name + " { get; set; }", StringComparison.Ordinal));
        Assert.True(index > 0, "Missing worker path parameter " + name);
        Assert.Contains("Mandatory = true", lines[index - 1]);
        Assert.Contains("Position = " + position, lines[index - 1]);
    }

    private static string Candidate(string source, string stem, int index) =>
        Assert.Single(source.ReplaceLineEndings("\n").Split('\n'),
            line => line.TrimStart().StartsWith("(\"", StringComparison.Ordinal)
                && line.Contains("\"Get-" + stem[3..] + "_Route" + index + "\"", StringComparison.Ordinal)).Trim();

    private static string RequiredNames(string[] names) =>
        "new string[] { " + string.Join(", ", names.Select(name => "\"" + name + "\"")) + " }),";

    private static async Task Reject(OpenApiDocument document, MultiRouteGroup group, string apiVersion = "beta") =>
        await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group, apiVersion));

    private static Task<Dictionary<string, string>> Generate(OpenApiDocument document, MultiRouteGroup group, string apiVersion = "beta") =>
        Generate(document, new[] { group }, apiVersion);

    private static async Task<Dictionary<string, string>> Generate(
        OpenApiDocument document, IReadOnlyList<MultiRouteGroup> groups, string apiVersion = "beta")
    {
        var output = Path.Combine(Directory.GetCurrentDirectory(), ".required-mixed-media-tests-" + Guid.NewGuid().ToString("N"));
        try
        {
            document.RegisterComponents();
            var config = new GeneratorConfig(Client, output, ApiVersion: apiVersion, UseCollisionData: false, MultiRouteGroups: groups);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance).GenerateAsync(CancellationToken.None);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(path => Path.GetFileName(path), File.ReadAllText);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }
}
