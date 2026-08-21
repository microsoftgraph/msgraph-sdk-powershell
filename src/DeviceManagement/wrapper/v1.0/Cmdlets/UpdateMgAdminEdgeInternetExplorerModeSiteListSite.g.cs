#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("PATCH", "/admin/edge/internetExplorerMode/siteLists/{browserSiteList-id}/sites/{browserSite-id}")]
    [Cmdlet(VerbsData.Update, "MgAdminEdgeInternetExplorerModeSiteListSite", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSite))]
    public class UpdateMgAdminEdgeInternetExplorerModeSiteListSiteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BrowserSiteListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BrowserSiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AllowRedirect { get; set; }

        [Parameter(Mandatory = false)]
        public string? Comment { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSiteCompatibilityMode? CompatibilityMode { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSiteHistory[]? History { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSiteMergeType? MergeType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSiteStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSiteTargetEnvironment? TargetEnvironment { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BrowserSiteId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSite();

    if (this.IsParameterBound(nameof(AllowRedirect)))
        body.AllowRedirect = AllowRedirect;

    if (this.IsParameterBound(nameof(Comment)))
        body.Comment = Comment;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

    if (this.IsParameterBound(nameof(CompatibilityMode)))
        body.CompatibilityMode = CompatibilityMode;

    if (this.IsParameterBound(nameof(History)))
        body.History = History!.ToList();

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(MergeType)))
        body.MergeType = MergeType;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(TargetEnvironment)))
        body.TargetEnvironment = TargetEnvironment;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.BrowserSite? result;
            try
            {
                result = client.Admin.Edge.InternetExplorerMode.SiteLists[BrowserSiteListId].Sites[BrowserSiteId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, BrowserSiteId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.Edge.InternetExplorerMode.SiteLists[BrowserSiteListId].Sites[BrowserSiteId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, BrowserSiteId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
