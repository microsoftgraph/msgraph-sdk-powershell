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
    [GraphRoute("PATCH", "/deviceManagement/deviceHealthScripts/{deviceHealthScript-id}/runSummary")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceHealthScriptRunSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptRunSummary))]
    public class UpdateMgDeviceManagementDeviceHealthScriptRunSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceHealthScriptId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? DetectionScriptErrorDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? DetectionScriptNotApplicableDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? DetectionScriptPendingDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? IssueDetectedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? IssueRemediatedCumulativeDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? IssueRemediatedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? IssueReoccurredDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastScriptRunDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? NoIssueDetectedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? RemediationScriptErrorDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? RemediationSkippedDeviceCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceHealthScriptId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptRunSummary();

    if (this.IsParameterBound(nameof(DetectionScriptErrorDeviceCount)))
        body.DetectionScriptErrorDeviceCount = DetectionScriptErrorDeviceCount;

    if (this.IsParameterBound(nameof(DetectionScriptNotApplicableDeviceCount)))
        body.DetectionScriptNotApplicableDeviceCount = DetectionScriptNotApplicableDeviceCount;

    if (this.IsParameterBound(nameof(DetectionScriptPendingDeviceCount)))
        body.DetectionScriptPendingDeviceCount = DetectionScriptPendingDeviceCount;

    if (this.IsParameterBound(nameof(IssueDetectedDeviceCount)))
        body.IssueDetectedDeviceCount = IssueDetectedDeviceCount;

    if (this.IsParameterBound(nameof(IssueRemediatedCumulativeDeviceCount)))
        body.IssueRemediatedCumulativeDeviceCount = IssueRemediatedCumulativeDeviceCount;

    if (this.IsParameterBound(nameof(IssueRemediatedDeviceCount)))
        body.IssueRemediatedDeviceCount = IssueRemediatedDeviceCount;

    if (this.IsParameterBound(nameof(IssueReoccurredDeviceCount)))
        body.IssueReoccurredDeviceCount = IssueReoccurredDeviceCount;

    if (this.IsParameterBound(nameof(LastScriptRunDateTime)))
        body.LastScriptRunDateTime = LastScriptRunDateTime;

    if (this.IsParameterBound(nameof(NoIssueDetectedDeviceCount)))
        body.NoIssueDetectedDeviceCount = NoIssueDetectedDeviceCount;

    if (this.IsParameterBound(nameof(RemediationScriptErrorDeviceCount)))
        body.RemediationScriptErrorDeviceCount = RemediationScriptErrorDeviceCount;

    if (this.IsParameterBound(nameof(RemediationSkippedDeviceCount)))
        body.RemediationSkippedDeviceCount = RemediationSkippedDeviceCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptRunSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceHealthScripts[DeviceHealthScriptId].RunSummary.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceHealthScriptId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceHealthScripts[DeviceHealthScriptId].RunSummary.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceHealthScriptId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
