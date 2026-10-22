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

public sealed class MediaRouteTests
{
    private const string Singleton = "/users/{user-id}/photo/$value";
    private const string Photos = "/users/{user-id}/photos/{profilePhoto-id}/$value";
    private const string Client = "Microsoft.Graph.PowerShell.MediaRoutes.Client";

    [Fact]
    public void MediaPolicyIsAnInitOnlyOptInWithoutChangingPositionalConstructors()
    {
        var routes = new[] { new MultiRoute("GET", Singleton, "Singleton"), new MultiRoute("GET", Photos, "Photos") };
        var group = new MultiRouteGroup("beta", routes, "Singleton", null);

        Assert.False(group.AllowMediaRoutes);
        Assert.False(group.AllowReferenceDelete);
        Assert.Null(group.SelectorParameter);
        Assert.Equal(4, Assert.Single(typeof(MultiRouteGroup).GetConstructors()).GetParameters().Length);
        Assert.Equal(3, Assert.Single(typeof(MultiRoute).GetConstructors()).GetParameters().Length);
        Assert.NotNull(typeof(MultiRouteGroup).GetProperty(nameof(MultiRouteGroup.AllowMediaRoutes))!.SetMethod);
    }

    [Fact]
    public async Task ReviewedMediaReadsKeepOptionalOutFileAndTypedStreamWorkers()
    {
        var files = await Generate(Document("GET"), Group("GET"));

        Assert.Equal(3, files.Count);
        var dispatcher = files["GetMgUserPhotoContent.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"SingletonGet\"", dispatcher);
        Assert.Contains("[OutputType(typeof(byte[]), ParameterSetName = new[] { \"SingletonGet\" })]", dispatcher);
        Assert.Contains("[OutputType(typeof(byte[]), ParameterSetName = new[] { \"PhotosGet\" })]", dispatcher);
        Assert.Contains("public string? OutFile", dispatcher);
        Assert.Contains("[Parameter(Mandatory = false, ParameterSetName = \"SingletonGet\")]", dispatcher);
        Assert.Contains("[Parameter(Mandatory = false, ParameterSetName = \"PhotosGet\")]", dispatcher);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"PhotosGet\", Position = 1)]", dispatcher);
        Assert.Contains("public string ProfilePhotoId", dispatcher);
        Assert.DoesNotContain("public string Route", dispatcher);
        Assert.DoesNotContain("SupportsShouldProcess", dispatcher);
        Assert.DoesNotContain("ParameterSetName = \"SingletonGet\", Position = 1", dispatcher);
        Assert.Contains("new Dictionary<string, object>(MyInvocation.BoundParameters)", dispatcher);
        Assert.Contains("PipelineResultTypes.Output | PipelineResultTypes.Error", dispatcher);
        Assert.Contains("ThrowTerminatingError(rex.ErrorRecord)", dispatcher);
        foreach (var (index, builder) in new[]
        {
            (0, "client.Users[UserId].Photo.Content"),
            (1, "client.Users[UserId].Photos[ProfilePhotoId].Content"),
        })
        {
            var source = files[$"GetMgUserPhotoContent_Route{index}.g.cs"];
            Assert.Contains(builder + ".GetAsync(", source);
            Assert.Contains("}, StoppingToken)", source);
            Assert.Contains("[OutputType(typeof(byte[]))]", source);
            Assert.Contains("public string? OutFile", source);
            Assert.Contains("using (result)", source);
            Assert.Contains("System.IO.File.Create(OutFile!)", source);
            Assert.Contains("result.CopyTo(file)", source);
            Assert.Contains("WriteObject(buffer.ToArray())", source);
            Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", source);
            Assert.Contains("ex is not PipelineStoppedException && ex is not OperationCanceledException", source);
            Assert.DoesNotContain("QueryParameters", source);
            Assert.DoesNotContain("IfMatch", source);
        }
    }

    [Fact]
    public async Task ReviewedMediaDeletesKeepHeadersAndShouldProcessWithoutOutFile()
    {
        var files = await Generate(Document("DELETE"), Group("DELETE"));

        Assert.Equal(3, files.Count);
        var dispatcher = files["RemoveMgUserPhotoContent.g.cs"];
        Assert.Contains("DefaultParameterSetName = \"SingletonInvoke\"", dispatcher);
        Assert.Contains("[Parameter(Mandatory = true, ParameterSetName = \"PhotosInvoke\", Position = 1)]", dispatcher);
        Assert.Contains("public string ProfilePhotoId", dispatcher);
        Assert.Contains("public string? IfMatch", dispatcher);
        foreach (var source in files.Values)
        {
            Assert.Contains("SupportsShouldProcess = true", source);
            Assert.DoesNotContain("OutFile", source);
            Assert.DoesNotContain("OutputType", source);
            Assert.DoesNotContain("QueryParameters", source);
        }
        foreach (var (index, builder) in new[]
        {
            (0, "client.Users[UserId].Photo.Content"),
            (1, "client.Users[UserId].Photos[ProfilePhotoId].Content"),
        })
        {
            var source = files[$"RemoveMgUserPhotoContent_Route{index}.g.cs"];
            Assert.Contains(builder + ".DeleteAsync(", source);
            Assert.Contains("if (!ShouldProcess(", source);
            Assert.Contains("requestConfiguration.Headers.Add(\"If-Match\", IfMatch!)", source);
            Assert.Contains("AddRequestHeaders(requestConfiguration.Headers)", source);
            Assert.Contains("ThrowGraphRequestFailed(ex,", source);
        }
    }

    [Fact]
    public void ContentEmitterCancellationIsOptInAndLeavesTheOldSourceUnchangedByDefault()
    {
        var naming = Naming.Resolve(new OperationInfo(HttpMethod.Get, Singleton));
        var context = new EmitContext(Client);

        var baseline = CmdletEmitter.EmitContentGet(naming, context, "System.IO.Stream", true);
        var explicitBaseline = CmdletEmitter.EmitContentGet(naming, context, "System.IO.Stream", true, useStoppingToken: false);
        var cancellable = CmdletEmitter.EmitContentGet(naming, context, "System.IO.Stream", true, useStoppingToken: true);

        Assert.Equal(baseline, explicitBaseline);
        Assert.DoesNotContain("StoppingToken", baseline);
        Assert.Contains("}, StoppingToken)", cancellable);
        Assert.Contains("public string? OutFile", cancellable);
        Assert.Contains("WriteObject(buffer.ToArray())", cancellable);
    }

    [Theory]
    [InlineData("GET")]
    [InlineData("DELETE")]
    public async Task OriginalStrictPolicyStillRejectsMediaWithoutTheFlag(string method)
    {
        await Assert.ThrowsAsync<InvalidOperationException>(() =>
            Generate(Document(method), Group(method) with { AllowMediaRoutes = false }));
    }

    [Theory]
    [InlineData("GET", "query")]
    [InlineData("GET", "json-response")]
    [InlineData("GET", "body")]
    [InlineData("GET", "mismatched-header")]
    [InlineData("DELETE", "query")]
    [InlineData("DELETE", "body")]
    [InlineData("DELETE", "binary-response")]
    [InlineData("DELETE", "mismatched-header")]
    public async Task MediaPolicyRejectsUnsupportedOrIncompatibleActualShapes(string method, string difference)
    {
        var document = Document(method);
        var operation = document.Paths[Photos].Operations![new HttpMethod(method)];
        if (difference == "query")
            operation.Parameters!.Add(new OpenApiParameter
            {
                Name = "$select", In = ParameterLocation.Query,
                Schema = new OpenApiSchema { Type = JsonSchemaType.String },
            });
        else if (difference == "mismatched-header")
            operation.Parameters!.Add(new OpenApiParameter
            {
                Name = "Unexpected-Header", In = ParameterLocation.Header,
                Schema = new OpenApiSchema { Type = JsonSchemaType.String },
            });
        else if (difference == "body")
            operation.RequestBody = new OpenApiRequestBody
            {
                Content = new Dictionary<string, IOpenApiMediaType>
                {
                    ["application/octet-stream"] = new OpenApiMediaType
                    {
                        Schema = new OpenApiSchema { Type = JsonSchemaType.String, Format = "binary" },
                    },
                },
            };
        else if (difference == "json-response")
            operation.Responses = new OpenApiResponses
            {
                ["200"] = new OpenApiResponse
                {
                    Content = new Dictionary<string, IOpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema { Type = JsonSchemaType.Object },
                        },
                    },
                },
            };
        else
            operation.Responses = BinaryResponse();

        await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, Group(method)));
    }

    [Theory]
    [InlineData("GET", "$ref")]
    [InlineData("DELETE", "$ref")]
    [InlineData("GET", "content")]
    [InlineData("DELETE", "content")]
    [InlineData("PUT", "$value")]
    [InlineData("POST", "$value")]
    public async Task MediaFlagDoesNotAuthorizeReferenceOrOtherOperationKinds(string method, string segment)
    {
        var document = Document(method);
        var group = Group(method);
        foreach (var route in group.Routes)
        {
            var replacement = route.Path[..route.Path.LastIndexOf('/')] + "/" + segment;
            var operation = document.Paths[route.Path];
            document.Paths.Remove(route.Path);
            document.Paths[replacement] = operation;
        }
        group = group with
        {
            Routes = group.Routes.Select(route => route with
            {
                Path = route.Path[..route.Path.LastIndexOf('/')] + "/" + segment,
            }).ToArray(),
        };

        await Assert.ThrowsAsync<InvalidOperationException>(() => Generate(document, group));
    }

    private static MultiRouteGroup Group(string method) => new("beta",
    [
        new(method, Singleton, "Singleton"),
        new(method, Photos, "Photos"),
    ], "Singleton") { AllowMediaRoutes = true };

    private static OpenApiResponses BinaryResponse() => new()
    {
        ["2XX"] = new OpenApiResponse
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

    private static OpenApiDocument Document(string method)
    {
        var document = new OpenApiDocument { Paths = new OpenApiPaths() };
        foreach (var path in new[] { Singleton, Photos })
            document.Paths[path] = new OpenApiPathItem
            {
                Operations = new Dictionary<HttpMethod, OpenApiOperation>
                {
                    [new(method)] = new()
                    {
                        Parameters = method == "DELETE"
                            ? [new OpenApiParameter
                            {
                                Name = "If-Match", In = ParameterLocation.Header,
                                Schema = new OpenApiSchema { Type = JsonSchemaType.String },
                            }]
                            : [],
                        Responses = method == "GET" ? BinaryResponse()
                            : new OpenApiResponses { ["204"] = new OpenApiResponse() },
                    },
                },
            };
        return document;
    }

    private static async Task<Dictionary<string, string>> Generate(OpenApiDocument document, MultiRouteGroup group)
    {
        var output = Path.Combine(Directory.GetCurrentDirectory(), ".media-route-tests-" + Guid.NewGuid().ToString("N"));
        try
        {
            document.RegisterComponents();
            var config = new GeneratorConfig(Client, output, "beta", UseCollisionData: false, MultiRouteGroups: [group]);
            await new PowerShellWrapperGenerationService(document, config, NullLogger.Instance).GenerateAsync(CancellationToken.None);
            return Directory.GetFiles(output, "*.g.cs").ToDictionary(path => Path.GetFileName(path)!, File.ReadAllText);
        }
        finally
        {
            if (Directory.Exists(output))
                Directory.Delete(output, recursive: true);
        }
    }
}
