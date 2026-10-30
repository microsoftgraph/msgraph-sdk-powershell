#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("POST", "/admin/windows/updates/products/{product-id}/knownIssues")]
    [Cmdlet(VerbsCommon.New, "MgWindowsUpdatesProductKnownIssue", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnownIssue))]
    public class NewMgWindowsUpdatesProductKnownIssueCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ProductId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ResolvedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int?[]? SafeguardHoldIds { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebViewUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnownIssueHistoryItem[]? KnownIssueHistories { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.WindowsReleaseHealthStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ProductId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnownIssue();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(ResolvedDateTime)))
        body.ResolvedDateTime = ResolvedDateTime;

    if (this.IsParameterBound(nameof(SafeguardHoldIds)))
        body.SafeguardHoldIds = SafeguardHoldIds!.ToList();

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(WebViewUrl)))
        body.WebViewUrl = WebViewUrl;

    if (this.IsParameterBound(nameof(KnownIssueHistories)))
        body.KnownIssueHistories = KnownIssueHistories!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.KnownIssue? result;
            try
            {
                result = client.Admin.Windows.Updates.Products[ProductId].KnownIssues.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
