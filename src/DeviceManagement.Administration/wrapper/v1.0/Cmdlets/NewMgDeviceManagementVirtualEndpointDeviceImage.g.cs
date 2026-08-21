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
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/deviceImages")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementVirtualEndpointDeviceImage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcDeviceImage))]
    public class NewMgDeviceManagementVirtualEndpointDeviceImageCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.DeviceManagement.VirtualEndpoint.DeviceImages.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
