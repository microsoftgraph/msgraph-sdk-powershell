#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("PATCH", "/admin/windows/updates/policies/{policy-id}/applicableContent/{applicableContent-catalogEntryId}/matchedDevices/{applicableContentDeviceMatch-deviceId}")]
    [Cmdlet(VerbsData.Update, "MgWindowsUpdatesPolicyApplicableContentMatchedDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ApplicableContentDeviceMatch))]
    public class UpdateMgWindowsUpdatesPolicyApplicableContentMatchedDeviceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ApplicableContentCatalogEntryId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ApplicableContentDeviceMatchDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RecommendedBy { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicableContentDeviceMatchDeviceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ApplicableContentDeviceMatch();

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(RecommendedBy)))
        body.RecommendedBy = RecommendedBy!.ToList();



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ApplicableContentDeviceMatch? result;
            try
            {
                result = client.Admin.Windows.Updates.Policies[PolicyId].ApplicableContent[ApplicableContentCatalogEntryId].MatchedDevices[ApplicableContentDeviceMatchDeviceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ApplicableContentDeviceMatchDeviceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.Windows.Updates.Policies[PolicyId].ApplicableContent[ApplicableContentCatalogEntryId].MatchedDevices[ApplicableContentDeviceMatchDeviceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ApplicableContentDeviceMatchDeviceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
