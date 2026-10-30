#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/dataDiscovery/cloudAppDiscovery/uploadedStreams/{cloudAppDiscoveryReport-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityDataDiscoveryCloudAppDiscoveryUploadedStream", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.CloudAppDiscoveryReport))]
    public class UpdateMgSecurityDataDiscoveryCloudAppDiscoveryUploadedStreamCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudAppDiscoveryReportId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AnonymizeMachineData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AnonymizeUserData { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSnapshotReport { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastDataReceivedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? LogFileCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.LogDataProvider? LogDataProvider { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ReceiverProtocol? ReceiverProtocol { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.EntityType?[]? SupportedEntityTypes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.TrafficType?[]? SupportedTrafficTypes { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudAppDiscoveryReportId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.CloudAppDiscoveryReport();

    if (this.IsParameterBound(nameof(AnonymizeMachineData)))
        body.AnonymizeMachineData = AnonymizeMachineData;

    if (this.IsParameterBound(nameof(AnonymizeUserData)))
        body.AnonymizeUserData = AnonymizeUserData;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsSnapshotReport)))
        body.IsSnapshotReport = IsSnapshotReport;

    if (this.IsParameterBound(nameof(LastDataReceivedDateTime)))
        body.LastDataReceivedDateTime = LastDataReceivedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(LogFileCount)))
        body.LogFileCount = LogFileCount;

    if (this.IsParameterBound(nameof(LogDataProvider)))
        body.LogDataProvider = LogDataProvider;

    if (this.IsParameterBound(nameof(ReceiverProtocol)))
        body.ReceiverProtocol = ReceiverProtocol;

    if (this.IsParameterBound(nameof(SupportedEntityTypes)))
        body.SupportedEntityTypes = SupportedEntityTypes!.ToList();

    if (this.IsParameterBound(nameof(SupportedTrafficTypes)))
        body.SupportedTrafficTypes = SupportedTrafficTypes!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.CloudAppDiscoveryReport? result;
            try
            {
                result = client.Security.DataDiscovery.CloudAppDiscovery.UploadedStreams[CloudAppDiscoveryReportId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CloudAppDiscoveryReportId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.DataDiscovery.CloudAppDiscovery.UploadedStreams[CloudAppDiscoveryReportId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CloudAppDiscoveryReportId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
