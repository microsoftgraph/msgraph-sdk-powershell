#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("PATCH", "/deviceManagement/virtualEndpoint/deviceImages/{cloudPcDeviceImage-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementVirtualEndpointDeviceImage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcDeviceImage))]
    public class UpdateMgDeviceManagementVirtualEndpointDeviceImageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPcDeviceImageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? ExpirationDate { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OperatingSystem { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsBuildNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersionNumber { get; set; }

        [Parameter(Mandatory = false)]
        public int? SizeInGB { get; set; }

        [Parameter(Mandatory = false)]
        public string? SourceImageResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcDeviceImageErrorCode? ErrorCode { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcDeviceImageOsStatus? OsStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcDeviceImageStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPcDeviceImageId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcDeviceImage();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExpirationDate)))
        body.ExpirationDate = ExpirationDate;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(OperatingSystem)))
        body.OperatingSystem = OperatingSystem;

    if (this.IsParameterBound(nameof(OsBuildNumber)))
        body.OsBuildNumber = OsBuildNumber;

    if (this.IsParameterBound(nameof(OsVersionNumber)))
        body.OsVersionNumber = OsVersionNumber;

    if (this.IsParameterBound(nameof(SizeInGB)))
        body.SizeInGB = SizeInGB;

    if (this.IsParameterBound(nameof(SourceImageResourceId)))
        body.SourceImageResourceId = SourceImageResourceId;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(ErrorCode)))
        body.ErrorCode = ErrorCode;

    if (this.IsParameterBound(nameof(OsStatus)))
        body.OsStatus = OsStatus;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcDeviceImage? result;
            try
            {
                result = client.DeviceManagement.VirtualEndpoint.DeviceImages[CloudPcDeviceImageId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CloudPcDeviceImageId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.VirtualEndpoint.DeviceImages[CloudPcDeviceImageId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CloudPcDeviceImageId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
