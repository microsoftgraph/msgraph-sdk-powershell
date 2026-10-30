#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/managedEBooks/{managedEBook-id}/deviceStates")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementManagedEBookDeviceState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceInstallState))]
    public class NewMgDeviceAppManagementManagedEBookDeviceStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedEBookId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ErrorCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsDescription { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.InstallState? InstallState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedEBookId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceInstallState();

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(ErrorCode)))
        body.ErrorCode = ErrorCode;

    if (this.IsParameterBound(nameof(LastSyncDateTime)))
        body.LastSyncDateTime = LastSyncDateTime;

    if (this.IsParameterBound(nameof(OsDescription)))
        body.OsDescription = OsDescription;

    if (this.IsParameterBound(nameof(OsVersion)))
        body.OsVersion = OsVersion;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;

    if (this.IsParameterBound(nameof(InstallState)))
        body.InstallState = InstallState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceInstallState? result;
            try
            {
                result = client.DeviceAppManagement.ManagedEBooks[ManagedEBookId].DeviceStates.PostAsync(body, requestConfiguration =>
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
