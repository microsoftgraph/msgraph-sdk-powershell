#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directory/recommendations/{recommendation-id}/impactedResources/addTag")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDirectoryRecommendationImpactedResourceAddTagByResourceId", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryNamespace.Recommendations.Item.ImpactedResources.AddTag.AddTagPostResponse))]
    public class InvokeMgDirectoryRecommendationImpactedResourceAddTagByResourceIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RecommendationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? ResourceIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RecommendationId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryNamespace.Recommendations.Item.ImpactedResources.AddTag.AddTagPostRequestBody();

    if (this.IsParameterBound(nameof(ResourceIds)))
        body.ResourceIds = ResourceIds!.ToList();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryNamespace.Recommendations.Item.ImpactedResources.AddTag.AddTagPostResponse? result;
            try
            {
                result = client.Directory.Recommendations[RecommendationId].ImpactedResources.AddTag.PostAsAddTagPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RecommendationId);
                return;
            }

            WriteObject(result);
        }
    }
}
