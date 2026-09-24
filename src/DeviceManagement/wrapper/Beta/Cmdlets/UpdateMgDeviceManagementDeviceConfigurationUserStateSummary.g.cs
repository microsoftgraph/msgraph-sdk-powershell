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
    [GraphRoute("PATCH", "/deviceManagement/deviceConfigurationUserStateSummaries")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceConfigurationUserStateSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationUserStateSummary))]
    public class UpdateMgDeviceManagementDeviceConfigurationUserStateSummaryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? CompliantUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ConflictUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NonCompliantUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotApplicableUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? RemediatedUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnknownUserCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationUserStateSummary();

    if (this.IsParameterBound(nameof(CompliantUserCount)))
        body.CompliantUserCount = CompliantUserCount;

    if (this.IsParameterBound(nameof(ConflictUserCount)))
        body.ConflictUserCount = ConflictUserCount;

    if (this.IsParameterBound(nameof(ErrorUserCount)))
        body.ErrorUserCount = ErrorUserCount;

    if (this.IsParameterBound(nameof(NonCompliantUserCount)))
        body.NonCompliantUserCount = NonCompliantUserCount;

    if (this.IsParameterBound(nameof(NotApplicableUserCount)))
        body.NotApplicableUserCount = NotApplicableUserCount;

    if (this.IsParameterBound(nameof(RemediatedUserCount)))
        body.RemediatedUserCount = RemediatedUserCount;

    if (this.IsParameterBound(nameof(UnknownUserCount)))
        body.UnknownUserCount = UnknownUserCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationUserStateSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceConfigurationUserStateSummaries.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceConfigurationUserStateSummaries.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
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
