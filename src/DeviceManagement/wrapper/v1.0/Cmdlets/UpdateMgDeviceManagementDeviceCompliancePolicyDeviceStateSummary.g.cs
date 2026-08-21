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
    [GraphRoute("PATCH", "/deviceManagement/deviceCompliancePolicyDeviceStateSummary")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceCompliancePolicyDeviceStateSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicyDeviceStateSummary))]
    public class UpdateMgDeviceManagementDeviceCompliancePolicyDeviceStateSummaryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? CompliantDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ConfigManagerCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ConflictDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? InGracePeriodCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NonCompliantDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotApplicableDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? RemediatedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnknownDeviceCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicyDeviceStateSummary();

    if (this.IsParameterBound(nameof(CompliantDeviceCount)))
        body.CompliantDeviceCount = CompliantDeviceCount;

    if (this.IsParameterBound(nameof(ConfigManagerCount)))
        body.ConfigManagerCount = ConfigManagerCount;

    if (this.IsParameterBound(nameof(ConflictDeviceCount)))
        body.ConflictDeviceCount = ConflictDeviceCount;

    if (this.IsParameterBound(nameof(ErrorDeviceCount)))
        body.ErrorDeviceCount = ErrorDeviceCount;

    if (this.IsParameterBound(nameof(InGracePeriodCount)))
        body.InGracePeriodCount = InGracePeriodCount;

    if (this.IsParameterBound(nameof(NonCompliantDeviceCount)))
        body.NonCompliantDeviceCount = NonCompliantDeviceCount;

    if (this.IsParameterBound(nameof(NotApplicableDeviceCount)))
        body.NotApplicableDeviceCount = NotApplicableDeviceCount;

    if (this.IsParameterBound(nameof(RemediatedDeviceCount)))
        body.RemediatedDeviceCount = RemediatedDeviceCount;

    if (this.IsParameterBound(nameof(UnknownDeviceCount)))
        body.UnknownDeviceCount = UnknownDeviceCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicyDeviceStateSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceCompliancePolicyDeviceStateSummary.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
