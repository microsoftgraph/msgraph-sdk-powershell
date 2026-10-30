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
    [GraphRoute("PATCH", "/deviceAppManagement/mobileApps/{mobileApp-id}/graph.win32LobApp/contentVersions/{mobileAppContent-id}/scripts/{mobileAppContentScript-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementMobileAppAsWin32LobAppContentVersionScript", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentScript))]
    public class UpdateMgDeviceAppManagementMobileAppAsWin32LobAppContentVersionScriptCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MobileAppContentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MobileAppContentScriptId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Content { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentScriptState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppContentScriptId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentScript();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppContentScript? result;
            try
            {
                result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphWin32LobApp.ContentVersions[MobileAppContentId].Scripts[MobileAppContentScriptId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MobileAppContentScriptId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.MobileApps[MobileAppId].GraphWin32LobApp.ContentVersions[MobileAppContentId].Scripts[MobileAppContentScriptId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MobileAppContentScriptId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
