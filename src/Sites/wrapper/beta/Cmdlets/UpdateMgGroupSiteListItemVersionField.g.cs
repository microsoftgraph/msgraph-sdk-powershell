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
    [GraphRoute("PATCH", "/groups/{group-id}/sites/{site-id}/lists/{list-id}/items/{listItem-id}/versions/{listItemVersion-id}/fields")]
    [Cmdlet(VerbsData.Update, "MgGroupSiteListItemVersionField", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.FieldValueSet))]
    public class UpdateMgGroupSiteListItemVersionFieldCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string ListItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string ListItemVersionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ListItemVersionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.FieldValueSet();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.FieldValueSet? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Lists[ListId].Items[ListItemId].Versions[ListItemVersionId].Fields.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ListItemVersionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Sites[SiteId].Lists[ListId].Items[ListItemId].Versions[ListItemVersionId].Fields.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ListItemVersionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
