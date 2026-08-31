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
    [GraphRoute("PATCH", "/groups/{group-id}/sites/{site-id}/analytics")]
    [Cmdlet(VerbsData.Update, "MgGroupSiteAnalytic", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ItemAnalytics))]
    public class UpdateMgGroupSiteAnalyticCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SiteId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.ItemAnalytics();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ItemAnalytics? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Analytics.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SiteId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Sites[SiteId].Analytics.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SiteId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
