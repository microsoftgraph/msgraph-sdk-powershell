#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("PATCH", "/deviceManagement/virtualEndpoint/userSettings/{cloudPcUserSetting-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementVirtualEndpointUserSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcUserSetting))]
    public class UpdateMgDeviceManagementVirtualEndpointUserSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPcUserSettingId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? LocalAdminEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ResetEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcRestorePointSetting? RestorePointSetting { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPcUserSettingId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcUserSetting();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(LocalAdminEnabled)))
        body.LocalAdminEnabled = LocalAdminEnabled;

    if (this.IsParameterBound(nameof(ResetEnabled)))
        body.ResetEnabled = ResetEnabled;

    if (this.IsParameterBound(nameof(RestorePointSetting)))
        body.RestorePointSetting = RestorePointSetting;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.CloudPcUserSetting? result;
            try
            {
                result = client.DeviceManagement.VirtualEndpoint.UserSettings[CloudPcUserSettingId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CloudPcUserSettingId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.VirtualEndpoint.UserSettings[CloudPcUserSettingId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, CloudPcUserSettingId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
