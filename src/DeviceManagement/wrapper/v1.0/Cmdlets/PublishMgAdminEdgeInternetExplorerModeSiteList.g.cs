#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/admin/edge/internetExplorerMode/siteLists/{browserSiteList-id}/publish")]
    [Cmdlet(VerbsData.Publish, "MgAdminEdgeInternetExplorerModeSiteList", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSiteList))]
    public class PublishMgAdminEdgeInternetExplorerModeSiteListCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BrowserSiteListId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Revision { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSite[]? Sites { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSharedCookie[]? SharedCookies { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BrowserSiteListId, "Publish"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.Admin.Edge.InternetExplorerMode.SiteLists.Item.Publish.PublishPostRequestBody();

    if (this.IsParameterBound(nameof(Revision)))
        body.Revision = Revision;
    if (this.IsParameterBound(nameof(Sites)))
        body.Sites = Sites!.ToList();

    if (this.IsParameterBound(nameof(SharedCookies)))
        body.SharedCookies = SharedCookies!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSiteList? result;
            try
            {
                result = client.Admin.Edge.InternetExplorerMode.SiteLists[BrowserSiteListId].Publish.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, BrowserSiteListId);
                return;
            }

            WriteObject(result);
        }
    }
}
