#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("PATCH", "/networkAccess/logs/remoteNetworks/{remoteNetworkHealthEvent-id}")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessLogRemoteNetwork", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.RemoteNetworkHealthEvent))]
    public class UpdateMgNetworkAccessLogRemoteNetworkCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteNetworkHealthEventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? BgpRoutesAdvertisedCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DestinationIp { get; set; }

        [Parameter(Mandatory = false)]
        public long? ReceivedBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemoteNetworkId { get; set; }

        [Parameter(Mandatory = false)]
        public long? SentBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? SourceIp { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.RemoteNetworkStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RemoteNetworkHealthEventId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.RemoteNetworkHealthEvent();

    if (this.IsParameterBound(nameof(BgpRoutesAdvertisedCount)))
        body.BgpRoutesAdvertisedCount = BgpRoutesAdvertisedCount;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DestinationIp)))
        body.DestinationIp = DestinationIp;

    if (this.IsParameterBound(nameof(ReceivedBytes)))
        body.ReceivedBytes = ReceivedBytes;

    if (this.IsParameterBound(nameof(RemoteNetworkId)))
        body.RemoteNetworkId = RemoteNetworkId;

    if (this.IsParameterBound(nameof(SentBytes)))
        body.SentBytes = SentBytes;

    if (this.IsParameterBound(nameof(SourceIp)))
        body.SourceIp = SourceIp;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.RemoteNetworkHealthEvent? result;
            try
            {
                result = client.NetworkAccess.Logs.RemoteNetworks[RemoteNetworkHealthEventId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RemoteNetworkHealthEventId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.Logs.RemoteNetworks[RemoteNetworkHealthEventId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, RemoteNetworkHealthEventId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
