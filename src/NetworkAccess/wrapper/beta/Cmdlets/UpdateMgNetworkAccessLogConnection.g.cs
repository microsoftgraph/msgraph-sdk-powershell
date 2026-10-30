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
    [GraphRoute("PATCH", "/networkAccess/logs/connections/{connection-id}")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessLogConnection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Connection))]
    public class UpdateMgNetworkAccessLogConnectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ConnectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AgentVersion { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DestinationFqdn { get; set; }

        [Parameter(Mandatory = false)]
        public string? DestinationIp { get; set; }

        [Parameter(Mandatory = false)]
        public int? DestinationPort { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceOperatingSystem { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceOperatingSystemVersion { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? HomeTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? InitiatingProcessName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PopProcessingRegion { get; set; }

        [Parameter(Mandatory = false)]
        public long? ReceivedBytes { get; set; }

        [Parameter(Mandatory = false)]
        public long? SentBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? SourceIp { get; set; }

        [Parameter(Mandatory = false)]
        public int? SourcePort { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public int? TransactionBlockCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? TransactionCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ApplicationSnapshot? ApplicationSnapshot { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.CrossTenantAccessType? CrossTenantAccessType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.DeviceCategory? DeviceCategory { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.DeviceJoinType? DeviceJoinType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.NetworkingProtocol? NetworkProtocol { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.PrivateAccessDetails? PrivateAccessDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ConnectionStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.TrafficType? TrafficType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.NetworkingProtocol? TransportProtocol { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ConnectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Connection();

    if (this.IsParameterBound(nameof(AgentVersion)))
        body.AgentVersion = AgentVersion;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DestinationFqdn)))
        body.DestinationFqdn = DestinationFqdn;

    if (this.IsParameterBound(nameof(DestinationIp)))
        body.DestinationIp = DestinationIp;

    if (this.IsParameterBound(nameof(DestinationPort)))
        body.DestinationPort = DestinationPort;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceOperatingSystem)))
        body.DeviceOperatingSystem = DeviceOperatingSystem;

    if (this.IsParameterBound(nameof(DeviceOperatingSystemVersion)))
        body.DeviceOperatingSystemVersion = DeviceOperatingSystemVersion;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(HomeTenantId)))
        body.HomeTenantId = HomeTenantId;

    if (this.IsParameterBound(nameof(InitiatingProcessName)))
        body.InitiatingProcessName = InitiatingProcessName;

    if (this.IsParameterBound(nameof(LastUpdateDateTime)))
        body.LastUpdateDateTime = LastUpdateDateTime;

    if (this.IsParameterBound(nameof(PopProcessingRegion)))
        body.PopProcessingRegion = PopProcessingRegion;

    if (this.IsParameterBound(nameof(ReceivedBytes)))
        body.ReceivedBytes = ReceivedBytes;

    if (this.IsParameterBound(nameof(SentBytes)))
        body.SentBytes = SentBytes;

    if (this.IsParameterBound(nameof(SourceIp)))
        body.SourceIp = SourceIp;

    if (this.IsParameterBound(nameof(SourcePort)))
        body.SourcePort = SourcePort;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(TransactionBlockCount)))
        body.TransactionBlockCount = TransactionBlockCount;

    if (this.IsParameterBound(nameof(TransactionCount)))
        body.TransactionCount = TransactionCount;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(ApplicationSnapshot)))
        body.ApplicationSnapshot = ApplicationSnapshot;

    if (this.IsParameterBound(nameof(CrossTenantAccessType)))
        body.CrossTenantAccessType = CrossTenantAccessType;

    if (this.IsParameterBound(nameof(DeviceCategory)))
        body.DeviceCategory = DeviceCategory;

    if (this.IsParameterBound(nameof(DeviceJoinType)))
        body.DeviceJoinType = DeviceJoinType;

    if (this.IsParameterBound(nameof(NetworkProtocol)))
        body.NetworkProtocol = NetworkProtocol;

    if (this.IsParameterBound(nameof(PrivateAccessDetails)))
        body.PrivateAccessDetails = PrivateAccessDetails;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(TrafficType)))
        body.TrafficType = TrafficType;

    if (this.IsParameterBound(nameof(TransportProtocol)))
        body.TransportProtocol = TransportProtocol;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Connection? result;
            try
            {
                result = client.NetworkAccess.Logs.Connections[ConnectionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ConnectionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.Logs.Connections[ConnectionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ConnectionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
