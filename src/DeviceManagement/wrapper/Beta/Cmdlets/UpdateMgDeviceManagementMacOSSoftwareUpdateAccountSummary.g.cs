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
    [GraphRoute("PATCH", "/deviceManagement/macOSSoftwareUpdateAccountSummaries/{macOSSoftwareUpdateAccountSummary-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementMacOSSoftwareUpdateAccountSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateAccountSummary))]
    public class UpdateMgDeviceManagementMacOSSoftwareUpdateAccountSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MacOSSoftwareUpdateAccountSummaryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? FailedUpdateCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public int? SuccessfulUpdateCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalUpdateCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MacOSSoftwareUpdateAccountSummaryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateAccountSummary();

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FailedUpdateCount)))
        body.FailedUpdateCount = FailedUpdateCount;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(OsVersion)))
        body.OsVersion = OsVersion;

    if (this.IsParameterBound(nameof(SuccessfulUpdateCount)))
        body.SuccessfulUpdateCount = SuccessfulUpdateCount;

    if (this.IsParameterBound(nameof(TotalUpdateCount)))
        body.TotalUpdateCount = TotalUpdateCount;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MacOSSoftwareUpdateAccountSummary? result;
            try
            {
                result = client.DeviceManagement.MacOSSoftwareUpdateAccountSummaries[MacOSSoftwareUpdateAccountSummaryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MacOSSoftwareUpdateAccountSummaryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.MacOSSoftwareUpdateAccountSummaries[MacOSSoftwareUpdateAccountSummaryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MacOSSoftwareUpdateAccountSummaryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
