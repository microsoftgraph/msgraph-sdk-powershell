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
    [GraphRoute("POST", "/deviceManagement/intents/{deviceManagementIntent-id}/deviceSettingStateSummaries")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementIntentDeviceSettingStateSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementIntentDeviceSettingStateSummary))]
    public class NewMgDeviceManagementIntentDeviceSettingStateSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementIntentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? CompliantCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ConflictCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NonCompliantCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotApplicableCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? RemediatedCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementIntentId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementIntentDeviceSettingStateSummary();

    if (this.IsParameterBound(nameof(CompliantCount)))
        body.CompliantCount = CompliantCount;

    if (this.IsParameterBound(nameof(ConflictCount)))
        body.ConflictCount = ConflictCount;

    if (this.IsParameterBound(nameof(ErrorCount)))
        body.ErrorCount = ErrorCount;

    if (this.IsParameterBound(nameof(NonCompliantCount)))
        body.NonCompliantCount = NonCompliantCount;

    if (this.IsParameterBound(nameof(NotApplicableCount)))
        body.NotApplicableCount = NotApplicableCount;

    if (this.IsParameterBound(nameof(RemediatedCount)))
        body.RemediatedCount = RemediatedCount;

    if (this.IsParameterBound(nameof(SettingName)))
        body.SettingName = SettingName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementIntentDeviceSettingStateSummary? result;
            try
            {
                result = client.DeviceManagement.Intents[DeviceManagementIntentId].DeviceSettingStateSummaries.PostAsync(body, requestConfiguration =>
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
