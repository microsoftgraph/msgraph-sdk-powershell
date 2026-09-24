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
    [GraphRoute("PATCH", "/deviceManagement/deviceConfigurationConflictSummary/{deviceConfigurationConflictSummary-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceConfigurationConflictSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationConflictSummary))]
    public class UpdateMgDeviceManagementDeviceConfigurationConflictSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceConfigurationConflictSummaryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? ContributingSettings { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeviceCheckinsImpacted { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SettingSource[]? ConflictingDeviceConfigurations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceConfigurationConflictSummaryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationConflictSummary();

    if (this.IsParameterBound(nameof(ContributingSettings)))
        body.ContributingSettings = ContributingSettings!.ToList();

    if (this.IsParameterBound(nameof(DeviceCheckinsImpacted)))
        body.DeviceCheckinsImpacted = DeviceCheckinsImpacted;

    if (this.IsParameterBound(nameof(ConflictingDeviceConfigurations)))
        body.ConflictingDeviceConfigurations = ConflictingDeviceConfigurations!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationConflictSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceConfigurationConflictSummary[DeviceConfigurationConflictSummaryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceConfigurationConflictSummaryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceConfigurationConflictSummary[DeviceConfigurationConflictSummaryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceConfigurationConflictSummaryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
