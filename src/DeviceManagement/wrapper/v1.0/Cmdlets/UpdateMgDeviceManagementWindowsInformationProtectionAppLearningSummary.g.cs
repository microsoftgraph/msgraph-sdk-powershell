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
    [GraphRoute("PATCH", "/deviceManagement/windowsInformationProtectionAppLearningSummaries/{windowsInformationProtectionAppLearningSummary-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementWindowsInformationProtectionAppLearningSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsInformationProtectionAppLearningSummary))]
    public class UpdateMgDeviceManagementWindowsInformationProtectionAppLearningSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WindowsInformationProtectionAppLearningSummaryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ApplicationName { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ApplicationType? ApplicationType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsInformationProtectionAppLearningSummaryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsInformationProtectionAppLearningSummary();

    if (this.IsParameterBound(nameof(ApplicationName)))
        body.ApplicationName = ApplicationName;

    if (this.IsParameterBound(nameof(DeviceCount)))
        body.DeviceCount = DeviceCount;

    if (this.IsParameterBound(nameof(ApplicationType)))
        body.ApplicationType = ApplicationType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsInformationProtectionAppLearningSummary? result;
            try
            {
                result = client.DeviceManagement.WindowsInformationProtectionAppLearningSummaries[WindowsInformationProtectionAppLearningSummaryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WindowsInformationProtectionAppLearningSummaryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.WindowsInformationProtectionAppLearningSummaries[WindowsInformationProtectionAppLearningSummaryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WindowsInformationProtectionAppLearningSummaryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
