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
    [GraphRoute("POST", "/sites/{site-id}/analytics/itemActivityStats")]
    [Cmdlet(VerbsCommon.New, "MgSiteAnalyticItemActivityStat", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActivityStat))]
    public class NewMgSiteAnalyticItemActivityStatCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTrending { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Access { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Create { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Delete { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Edit { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.IncompleteData? IncompleteData { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActionStat? Move { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SiteId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActivityStat();

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(IsTrending)))
        body.IsTrending = IsTrending;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Access)))
        body.Access = Access;

    if (this.IsParameterBound(nameof(Create)))
        body.Create = Create;

    if (this.IsParameterBound(nameof(Delete)))
        body.Delete = Delete;

    if (this.IsParameterBound(nameof(Edit)))
        body.Edit = Edit;

    if (this.IsParameterBound(nameof(IncompleteData)))
        body.IncompleteData = IncompleteData;

    if (this.IsParameterBound(nameof(Move)))
        body.Move = Move;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ItemActivityStat? result;
            try
            {
                result = client.Sites[SiteId].Analytics.ItemActivityStats.PostAsync(body, requestConfiguration =>
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
