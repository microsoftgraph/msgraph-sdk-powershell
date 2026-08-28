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
    [GraphRoute("PATCH", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementManagedDeviceLogCollectionRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceLogCollectionResponse))]
    public class UpdateMgDeviceManagementManagedDeviceLogCollectionRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceLogCollectionResponseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? EnrolledByUser { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTimeUTC { get; set; }

        [Parameter(Mandatory = false)]
        public string? InitiatedByUserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? ManagedDeviceId1 { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReceivedDateTimeUTC { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RequestedDateTimeUTC { get; set; }

        [Parameter(Mandatory = false)]
        public double? SizeInKB { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AppLogUploadState? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceLogCollectionResponseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceLogCollectionResponse();

    if (this.IsParameterBound(nameof(EnrolledByUser)))
        body.EnrolledByUser = EnrolledByUser;

    if (this.IsParameterBound(nameof(ExpirationDateTimeUTC)))
        body.ExpirationDateTimeUTC = ExpirationDateTimeUTC;

    if (this.IsParameterBound(nameof(InitiatedByUserPrincipalName)))
        body.InitiatedByUserPrincipalName = InitiatedByUserPrincipalName;

    if (this.IsParameterBound(nameof(ManagedDeviceId1)))
        body.ManagedDeviceId = ManagedDeviceId1;

    if (this.IsParameterBound(nameof(ReceivedDateTimeUTC)))
        body.ReceivedDateTimeUTC = ReceivedDateTimeUTC;

    if (this.IsParameterBound(nameof(RequestedDateTimeUTC)))
        body.RequestedDateTimeUTC = RequestedDateTimeUTC;

    if (this.IsParameterBound(nameof(SizeInKB)))
        body.SizeInKB = SizeInKB;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceLogCollectionResponse? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].LogCollectionRequests[DeviceLogCollectionResponseId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceLogCollectionResponseId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].LogCollectionRequests[DeviceLogCollectionResponseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceLogCollectionResponseId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
