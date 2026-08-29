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
    [GraphRoute("PATCH", "/deviceManagement")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagement", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagement))]
    public class UpdateMgDeviceManagementCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.Guid? IntuneAccountId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceProtectionOverview? DeviceProtectionOverview { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.IntuneBrand? IntuneBrand { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettings? Settings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSubscriptionState? SubscriptionState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.UserExperienceAnalyticsSettings? UserExperienceAnalyticsSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsMalwareOverview? WindowsMalwareOverview { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagement();

    if (this.IsParameterBound(nameof(IntuneAccountId)))
        body.IntuneAccountId = IntuneAccountId;

    if (this.IsParameterBound(nameof(DeviceProtectionOverview)))
        body.DeviceProtectionOverview = DeviceProtectionOverview;

    if (this.IsParameterBound(nameof(IntuneBrand)))
        body.IntuneBrand = IntuneBrand;

    if (this.IsParameterBound(nameof(Settings)))
        body.Settings = Settings;

    if (this.IsParameterBound(nameof(SubscriptionState)))
        body.SubscriptionState = SubscriptionState;

    if (this.IsParameterBound(nameof(UserExperienceAnalyticsSettings)))
        body.UserExperienceAnalyticsSettings = UserExperienceAnalyticsSettings;

    if (this.IsParameterBound(nameof(WindowsMalwareOverview)))
        body.WindowsMalwareOverview = WindowsMalwareOverview;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagement? result;
            try
            {
                result = client.DeviceManagement.PatchAsync(body, requestConfiguration =>
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
                    result = client.DeviceManagement.GetAsync().GetAwaiter().GetResult();
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
