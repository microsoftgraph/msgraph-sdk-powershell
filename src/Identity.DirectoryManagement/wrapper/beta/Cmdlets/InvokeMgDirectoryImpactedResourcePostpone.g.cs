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
    [GraphRoute("POST", "/directory/impactedResources/{impactedResource-id}/postpone")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDirectoryImpactedResourcePostpone", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ImpactedResource))]
    public class InvokeMgDirectoryImpactedResourcePostponeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ImpactedResourceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? PostponeUntilDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ImpactedResourceId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryNamespace.ImpactedResources.Item.Postpone.PostponePostRequestBody();

    if (this.IsParameterBound(nameof(PostponeUntilDateTime)))
        body.PostponeUntilDateTime = PostponeUntilDateTime;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ImpactedResource? result;
            try
            {
                result = client.Directory.ImpactedResources[ImpactedResourceId].Postpone.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ImpactedResourceId);
                return;
            }

            WriteObject(result);
        }
    }
}
