#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/analytics/itemActivityStats/{itemActivityStat-id}")]
    [Cmdlet(VerbsData.Update, "MgDriveItemAnalyticItemActivityStat", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.ItemActivityStat))]
    public class UpdateMgDriveItemAnalyticItemActivityStatCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ItemActivityStatId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTrending { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ItemActionStat? Access { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ItemActionStat? Create { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ItemActionStat? Delete { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ItemActionStat? Edit { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.IncompleteData? IncompleteData { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ItemActionStat? Move { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ItemActivityStatId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.ItemActivityStat();

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

            Microsoft.Graph.PowerShell.Files.Client.Models.ItemActivityStat? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Analytics.ItemActivityStats[ItemActivityStatId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ItemActivityStatId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].Items[DriveItemId].Analytics.ItemActivityStats[ItemActivityStatId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, ItemActivityStatId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
