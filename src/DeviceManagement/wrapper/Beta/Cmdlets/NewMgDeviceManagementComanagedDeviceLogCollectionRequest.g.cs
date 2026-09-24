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
    [GraphRoute("POST", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementComanagedDeviceLogCollectionRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceLogCollectionResponse))]
    public class NewMgDeviceManagementComanagedDeviceLogCollectionRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? EnrolledByUser { get; set; }

        [Parameter(Mandatory = false)]
        public long? ErrorCode { get; set; }

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
        public double? Size { get; set; }

        [Parameter(Mandatory = false)]
        public double? SizeInKB { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AppLogUploadState? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceLogCollectionResponse();

    if (this.IsParameterBound(nameof(EnrolledByUser)))
        body.EnrolledByUser = EnrolledByUser;

    if (this.IsParameterBound(nameof(ErrorCode)))
        body.ErrorCode = ErrorCode;

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

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;

    if (this.IsParameterBound(nameof(SizeInKB)))
        body.SizeInKB = SizeInKB;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceLogCollectionResponse? result;
            try
            {
                result = client.DeviceManagement.ComanagedDevices[ManagedDeviceId].LogCollectionRequests.PostAsync(body, requestConfiguration =>
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
