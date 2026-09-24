#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("PATCH", "/deviceManagement/userExperienceAnalyticsNotAutopilotReadyDevice/{userExperienceAnalyticsNotAutopilotReadyDevice-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementUserExperienceAnalyticNotAutopilotReadyDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UserExperienceAnalyticsNotAutopilotReadyDevice))]
    public class UpdateMgDeviceManagementUserExperienceAnalyticNotAutopilotReadyDeviceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserExperienceAnalyticsNotAutopilotReadyDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AutoPilotProfileAssigned { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AutoPilotRegistered { get; set; }

        [Parameter(Mandatory = false)]
        public string? AzureAdJoinType { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AzureAdRegistered { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedBy { get; set; }

        [Parameter(Mandatory = false)]
        public string? Manufacturer { get; set; }

        [Parameter(Mandatory = false)]
        public string? Model { get; set; }

        [Parameter(Mandatory = false)]
        public string? SerialNumber { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserExperienceAnalyticsNotAutopilotReadyDeviceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UserExperienceAnalyticsNotAutopilotReadyDevice();

    if (this.IsParameterBound(nameof(AutoPilotProfileAssigned)))
        body.AutoPilotProfileAssigned = AutoPilotProfileAssigned;

    if (this.IsParameterBound(nameof(AutoPilotRegistered)))
        body.AutoPilotRegistered = AutoPilotRegistered;

    if (this.IsParameterBound(nameof(AzureAdJoinType)))
        body.AzureAdJoinType = AzureAdJoinType;

    if (this.IsParameterBound(nameof(AzureAdRegistered)))
        body.AzureAdRegistered = AzureAdRegistered;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(ManagedBy)))
        body.ManagedBy = ManagedBy;

    if (this.IsParameterBound(nameof(Manufacturer)))
        body.Manufacturer = Manufacturer;

    if (this.IsParameterBound(nameof(Model)))
        body.Model = Model;

    if (this.IsParameterBound(nameof(SerialNumber)))
        body.SerialNumber = SerialNumber;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UserExperienceAnalyticsNotAutopilotReadyDevice? result;
            try
            {
                result = client.DeviceManagement.UserExperienceAnalyticsNotAutopilotReadyDevice[UserExperienceAnalyticsNotAutopilotReadyDeviceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserExperienceAnalyticsNotAutopilotReadyDeviceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.UserExperienceAnalyticsNotAutopilotReadyDevice[UserExperienceAnalyticsNotAutopilotReadyDeviceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UserExperienceAnalyticsNotAutopilotReadyDeviceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
