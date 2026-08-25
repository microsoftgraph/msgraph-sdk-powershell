#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/mobileApps/{mobileApp-id}/assignments/{mobileAppAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementMobileAppAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppAssignment))]
    public class UpdateMgDeviceAppManagementMobileAppAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MobileAppAssignmentId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.InstallIntent? Intent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppAssignmentSettings? Settings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAndAppManagementAssignmentTarget? Target { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppAssignment();


    if (this.IsParameterBound(nameof(Intent)))
        body.Intent = Intent;

    if (this.IsParameterBound(nameof(Settings)))
        body.Settings = Settings;

    if (this.IsParameterBound(nameof(Target)))
        body.Target = Target;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppAssignment? result;
            try
            {
                result = client.DeviceAppManagement.MobileApps[MobileAppId].Assignments[MobileAppAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, MobileAppAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.MobileApps[MobileAppId].Assignments[MobileAppAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, MobileAppAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
