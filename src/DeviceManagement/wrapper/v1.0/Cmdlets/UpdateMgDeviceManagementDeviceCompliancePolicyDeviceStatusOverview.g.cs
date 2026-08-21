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
    [GraphRoute("PATCH", "/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy-id}/deviceStatusOverview")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceCompliancePolicyDeviceStatusOverview", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceDeviceOverview))]
    public class UpdateMgDeviceManagementDeviceCompliancePolicyDeviceStatusOverviewCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceCompliancePolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ConfigurationVersion { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? FailedCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotApplicableCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? PendingCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? SuccessCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceCompliancePolicyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceDeviceOverview();

    if (this.IsParameterBound(nameof(ConfigurationVersion)))
        body.ConfigurationVersion = ConfigurationVersion;

    if (this.IsParameterBound(nameof(ErrorCount)))
        body.ErrorCount = ErrorCount;

    if (this.IsParameterBound(nameof(FailedCount)))
        body.FailedCount = FailedCount;

    if (this.IsParameterBound(nameof(LastUpdateDateTime)))
        body.LastUpdateDateTime = LastUpdateDateTime;

    if (this.IsParameterBound(nameof(NotApplicableCount)))
        body.NotApplicableCount = NotApplicableCount;

    if (this.IsParameterBound(nameof(PendingCount)))
        body.PendingCount = PendingCount;

    if (this.IsParameterBound(nameof(SuccessCount)))
        body.SuccessCount = SuccessCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceDeviceOverview? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].DeviceStatusOverview.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DeviceCompliancePolicyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].DeviceStatusOverview.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, DeviceCompliancePolicyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
