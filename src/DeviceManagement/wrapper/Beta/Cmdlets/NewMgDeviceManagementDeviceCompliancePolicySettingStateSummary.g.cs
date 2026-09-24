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
    [GraphRoute("POST", "/deviceManagement/deviceCompliancePolicySettingStateSummaries")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementDeviceCompliancePolicySettingStateSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicySettingStateSummary))]
    public class NewMgDeviceManagementDeviceCompliancePolicySettingStateSummaryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? CompliantDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ConflictDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NonCompliantDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotApplicableDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? RemediatedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? Setting { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingName { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnknownDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.PolicyPlatformType? PlatformType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicySettingStateSummary();

    if (this.IsParameterBound(nameof(CompliantDeviceCount)))
        body.CompliantDeviceCount = CompliantDeviceCount;

    if (this.IsParameterBound(nameof(ConflictDeviceCount)))
        body.ConflictDeviceCount = ConflictDeviceCount;

    if (this.IsParameterBound(nameof(ErrorDeviceCount)))
        body.ErrorDeviceCount = ErrorDeviceCount;

    if (this.IsParameterBound(nameof(NonCompliantDeviceCount)))
        body.NonCompliantDeviceCount = NonCompliantDeviceCount;

    if (this.IsParameterBound(nameof(NotApplicableDeviceCount)))
        body.NotApplicableDeviceCount = NotApplicableDeviceCount;

    if (this.IsParameterBound(nameof(RemediatedDeviceCount)))
        body.RemediatedDeviceCount = RemediatedDeviceCount;

    if (this.IsParameterBound(nameof(Setting)))
        body.Setting = Setting;

    if (this.IsParameterBound(nameof(SettingName)))
        body.SettingName = SettingName;

    if (this.IsParameterBound(nameof(UnknownDeviceCount)))
        body.UnknownDeviceCount = UnknownDeviceCount;

    if (this.IsParameterBound(nameof(PlatformType)))
        body.PlatformType = PlatformType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicySettingStateSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicySettingStateSummaries.PostAsync(body, requestConfiguration =>
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
