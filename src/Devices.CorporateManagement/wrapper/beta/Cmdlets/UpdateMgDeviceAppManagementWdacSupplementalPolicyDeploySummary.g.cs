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
    [GraphRoute("PATCH", "/deviceAppManagement/wdacSupplementalPolicies/{windowsDefenderApplicationControlSupplementalPolicy-id}/deploySummary")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementWdacSupplementalPolicyDeploySummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary))]
    public class UpdateMgDeviceAppManagementWdacSupplementalPolicyDeploySummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WindowsDefenderApplicationControlSupplementalPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? DeployedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? FailedDeviceCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsDefenderApplicationControlSupplementalPolicyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary();

    if (this.IsParameterBound(nameof(DeployedDeviceCount)))
        body.DeployedDeviceCount = DeployedDeviceCount;

    if (this.IsParameterBound(nameof(FailedDeviceCount)))
        body.FailedDeviceCount = FailedDeviceCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary? result;
            try
            {
                result = client.DeviceAppManagement.WdacSupplementalPolicies[WindowsDefenderApplicationControlSupplementalPolicyId].DeploySummary.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WindowsDefenderApplicationControlSupplementalPolicyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.WdacSupplementalPolicies[WindowsDefenderApplicationControlSupplementalPolicyId].DeploySummary.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WindowsDefenderApplicationControlSupplementalPolicyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
