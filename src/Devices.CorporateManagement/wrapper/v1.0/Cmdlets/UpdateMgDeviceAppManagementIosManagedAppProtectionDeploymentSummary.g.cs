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
    [GraphRoute("PATCH", "/deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtection-id}/deploymentSummary")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementiOSManagedAppProtectionDeploymentSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppPolicyDeploymentSummary))]
    public class UpdateMgDeviceAppManagementiOSManagedAppProtectionDeploymentSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IosManagedAppProtectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ConfigurationDeployedUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastRefreshTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppPolicyDeploymentSummaryPerApp[]? ConfigurationDeploymentSummaryPerApp { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IosManagedAppProtectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppPolicyDeploymentSummary();

    if (this.IsParameterBound(nameof(ConfigurationDeployedUserCount)))
        body.ConfigurationDeployedUserCount = ConfigurationDeployedUserCount;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastRefreshTime)))
        body.LastRefreshTime = LastRefreshTime;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(ConfigurationDeploymentSummaryPerApp)))
        body.ConfigurationDeploymentSummaryPerApp = ConfigurationDeploymentSummaryPerApp!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppPolicyDeploymentSummary? result;
            try
            {
                result = client.DeviceAppManagement.IosManagedAppProtections[IosManagedAppProtectionId].DeploymentSummary.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, IosManagedAppProtectionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.IosManagedAppProtections[IosManagedAppProtectionId].DeploymentSummary.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, IosManagedAppProtectionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
