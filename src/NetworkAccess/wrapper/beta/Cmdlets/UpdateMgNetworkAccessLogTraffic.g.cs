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
    [GraphRoute("PATCH", "/networkAccess/logs/traffic/{networkAccessTraffic-transactionId}")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessLogTraffic", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.NetworkAccessTraffic))]
    public class UpdateMgNetworkAccessLogTrafficCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string NetworkAccessTrafficTransactionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AgentVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? ConnectionId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DestinationFQDN { get; set; }

        [Parameter(Mandatory = false)]
        public string? DestinationIp { get; set; }

        [Parameter(Mandatory = false)]
        public int? DestinationPort { get; set; }

        [Parameter(Mandatory = false)]
        public string? DestinationUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceOperatingSystem { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceOperatingSystemVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? FilteringProfileId { get; set; }

        [Parameter(Mandatory = false)]
        public string? FilteringProfileName { get; set; }

        [Parameter(Mandatory = false)]
        public string? InitiatingProcessName { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyRuleId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyRuleName { get; set; }

        [Parameter(Mandatory = false)]
        public string? PopProcessingRegion { get; set; }

        [Parameter(Mandatory = false)]
        public long? ReceivedBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemoteNetworkId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public int? ResponseCode { get; set; }

        [Parameter(Mandatory = false)]
        public long? SentBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? SessionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SourceIp { get; set; }

        [Parameter(Mandatory = false)]
        public int? SourcePort { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ThreatType { get; set; }

        [Parameter(Mandatory = false)]
        public string? TransactionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? VendorNames { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.FilteringPolicyAction? Action { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ApplicationSnapshot? ApplicationSnapshot { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.CloudApplicationMetadata? CloudApplicationMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.WebCategory? DestinationWebCategory { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.DeviceCategory? DeviceCategory { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Headers? Headers { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.HttpMethod? HttpMethod { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.NetworkingProtocol? NetworkProtocol { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.NetworkTrafficOperationStatus? OperationStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.PrivateAccessDetails? PrivateAccessDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.TrafficType? TrafficType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.NetworkingProtocol? TransportProtocol { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(NetworkAccessTrafficTransactionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.NetworkAccessTraffic();

    if (this.IsParameterBound(nameof(AgentVersion)))
        body.AgentVersion = AgentVersion;

    if (this.IsParameterBound(nameof(ConnectionId)))
        body.ConnectionId = ConnectionId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DestinationFQDN)))
        body.DestinationFQDN = DestinationFQDN;

    if (this.IsParameterBound(nameof(DestinationIp)))
        body.DestinationIp = DestinationIp;

    if (this.IsParameterBound(nameof(DestinationPort)))
        body.DestinationPort = DestinationPort;

    if (this.IsParameterBound(nameof(DestinationUrl)))
        body.DestinationUrl = DestinationUrl;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceOperatingSystem)))
        body.DeviceOperatingSystem = DeviceOperatingSystem;

    if (this.IsParameterBound(nameof(DeviceOperatingSystemVersion)))
        body.DeviceOperatingSystemVersion = DeviceOperatingSystemVersion;

    if (this.IsParameterBound(nameof(FilteringProfileId)))
        body.FilteringProfileId = FilteringProfileId;

    if (this.IsParameterBound(nameof(FilteringProfileName)))
        body.FilteringProfileName = FilteringProfileName;

    if (this.IsParameterBound(nameof(InitiatingProcessName)))
        body.InitiatingProcessName = InitiatingProcessName;

    if (this.IsParameterBound(nameof(PolicyId)))
        body.PolicyId = PolicyId;

    if (this.IsParameterBound(nameof(PolicyName)))
        body.PolicyName = PolicyName;

    if (this.IsParameterBound(nameof(PolicyRuleId)))
        body.PolicyRuleId = PolicyRuleId;

    if (this.IsParameterBound(nameof(PolicyRuleName)))
        body.PolicyRuleName = PolicyRuleName;

    if (this.IsParameterBound(nameof(PopProcessingRegion)))
        body.PopProcessingRegion = PopProcessingRegion;

    if (this.IsParameterBound(nameof(ReceivedBytes)))
        body.ReceivedBytes = ReceivedBytes;

    if (this.IsParameterBound(nameof(RemoteNetworkId)))
        body.RemoteNetworkId = RemoteNetworkId;

    if (this.IsParameterBound(nameof(ResourceTenantId)))
        body.ResourceTenantId = ResourceTenantId;

    if (this.IsParameterBound(nameof(ResponseCode)))
        body.ResponseCode = ResponseCode;

    if (this.IsParameterBound(nameof(SentBytes)))
        body.SentBytes = SentBytes;

    if (this.IsParameterBound(nameof(SessionId)))
        body.SessionId = SessionId;

    if (this.IsParameterBound(nameof(SourceIp)))
        body.SourceIp = SourceIp;

    if (this.IsParameterBound(nameof(SourcePort)))
        body.SourcePort = SourcePort;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(ThreatType)))
        body.ThreatType = ThreatType;

    if (this.IsParameterBound(nameof(TransactionId)))
        body.TransactionId = TransactionId;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(VendorNames)))
        body.VendorNames = VendorNames!.ToList();

    if (this.IsParameterBound(nameof(Action)))
        body.Action = Action;

    if (this.IsParameterBound(nameof(ApplicationSnapshot)))
        body.ApplicationSnapshot = ApplicationSnapshot;

    if (this.IsParameterBound(nameof(CloudApplicationMetadata)))
        body.CloudApplicationMetadata = CloudApplicationMetadata;

    if (this.IsParameterBound(nameof(DestinationWebCategory)))
        body.DestinationWebCategory = DestinationWebCategory;

    if (this.IsParameterBound(nameof(DeviceCategory)))
        body.DeviceCategory = DeviceCategory;

    if (this.IsParameterBound(nameof(Headers)))
        body.Headers = Headers;

    if (this.IsParameterBound(nameof(HttpMethod)))
        body.HttpMethod = HttpMethod;

    if (this.IsParameterBound(nameof(NetworkProtocol)))
        body.NetworkProtocol = NetworkProtocol;

    if (this.IsParameterBound(nameof(OperationStatus)))
        body.OperationStatus = OperationStatus;

    if (this.IsParameterBound(nameof(PrivateAccessDetails)))
        body.PrivateAccessDetails = PrivateAccessDetails;

    if (this.IsParameterBound(nameof(TrafficType)))
        body.TrafficType = TrafficType;

    if (this.IsParameterBound(nameof(TransportProtocol)))
        body.TransportProtocol = TransportProtocol;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.NetworkAccessTraffic? result;
            try
            {
                result = client.NetworkAccess.Logs.Traffic[NetworkAccessTrafficTransactionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, NetworkAccessTrafficTransactionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.Logs.Traffic[NetworkAccessTrafficTransactionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, NetworkAccessTrafficTransactionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
