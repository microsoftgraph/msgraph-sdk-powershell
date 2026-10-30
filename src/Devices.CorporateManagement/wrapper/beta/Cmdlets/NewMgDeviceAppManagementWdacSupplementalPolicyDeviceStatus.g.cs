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
    [GraphRoute("POST", "/deviceAppManagement/wdacSupplementalPolicies/{windowsDefenderApplicationControlSupplementalPolicy-id}/deviceStatuses")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementWdacSupplementalPolicyDeviceStatus", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus))]
    public class NewMgDeviceAppManagementWdacSupplementalPolicyDeviceStatusCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WindowsDefenderApplicationControlSupplementalPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsDescription { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicyStatuses? DeploymentStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsDefenderApplicationControlSupplementalPolicyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus();

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(LastSyncDateTime)))
        body.LastSyncDateTime = LastSyncDateTime;

    if (this.IsParameterBound(nameof(OsDescription)))
        body.OsDescription = OsDescription;

    if (this.IsParameterBound(nameof(OsVersion)))
        body.OsVersion = OsVersion;

    if (this.IsParameterBound(nameof(PolicyVersion)))
        body.PolicyVersion = PolicyVersion;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(DeploymentStatus)))
        body.DeploymentStatus = DeploymentStatus;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus? result;
            try
            {
                result = client.DeviceAppManagement.WdacSupplementalPolicies[WindowsDefenderApplicationControlSupplementalPolicyId].DeviceStatuses.PostAsync(body, requestConfiguration =>
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
