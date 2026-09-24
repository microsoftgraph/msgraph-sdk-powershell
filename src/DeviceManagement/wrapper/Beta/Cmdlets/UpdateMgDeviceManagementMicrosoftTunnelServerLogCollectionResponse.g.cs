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
    [GraphRoute("PATCH", "/deviceManagement/microsoftTunnelServerLogCollectionResponses/{microsoftTunnelServerLogCollectionResponse-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementMicrosoftTunnelServerLogCollectionResponse", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelServerLogCollectionResponse))]
    public class UpdateMgDeviceManagementMicrosoftTunnelServerLogCollectionResponseCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftTunnelServerLogCollectionResponseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpiryDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RequestDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServerId { get; set; }

        [Parameter(Mandatory = false)]
        public long? SizeInBytes { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelLogCollectionStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftTunnelServerLogCollectionResponseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelServerLogCollectionResponse();

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(ExpiryDateTime)))
        body.ExpiryDateTime = ExpiryDateTime;

    if (this.IsParameterBound(nameof(RequestDateTime)))
        body.RequestDateTime = RequestDateTime;

    if (this.IsParameterBound(nameof(ServerId)))
        body.ServerId = ServerId;

    if (this.IsParameterBound(nameof(SizeInBytes)))
        body.SizeInBytes = SizeInBytes;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelServerLogCollectionResponse? result;
            try
            {
                result = client.DeviceManagement.MicrosoftTunnelServerLogCollectionResponses[MicrosoftTunnelServerLogCollectionResponseId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MicrosoftTunnelServerLogCollectionResponseId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.MicrosoftTunnelServerLogCollectionResponses[MicrosoftTunnelServerLogCollectionResponseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MicrosoftTunnelServerLogCollectionResponseId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
