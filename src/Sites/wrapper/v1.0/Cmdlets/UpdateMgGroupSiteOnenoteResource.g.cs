#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("PATCH", "/groups/{group-id}/sites/{site-id}/onenote/resources/{onenoteResource-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupSiteOnenoteResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.OnenoteResource))]
    public class UpdateMgGroupSiteOnenoteResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string OnenoteResourceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Self { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentUrl { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenoteResourceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.OnenoteResource();

    if (this.IsParameterBound(nameof(Self)))
        body.Self = Self;

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(ContentUrl)))
        body.ContentUrl = ContentUrl;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.OnenoteResource? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Onenote.Resources[OnenoteResourceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OnenoteResourceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Sites[SiteId].Onenote.Resources[OnenoteResourceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, OnenoteResourceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
