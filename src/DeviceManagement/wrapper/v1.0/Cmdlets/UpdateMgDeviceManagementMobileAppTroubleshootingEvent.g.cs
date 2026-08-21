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
    [GraphRoute("PATCH", "/deviceManagement/mobileAppTroubleshootingEvents/{mobileAppTroubleshootingEvent-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementMobileAppTroubleshootingEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MobileAppTroubleshootingEvent))]
    public class UpdateMgDeviceManagementMobileAppTroubleshootingEventCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppTroubleshootingEventId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppTroubleshootingEventId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MobileAppTroubleshootingEvent();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MobileAppTroubleshootingEvent? result;
            try
            {
                result = client.DeviceManagement.MobileAppTroubleshootingEvents[MobileAppTroubleshootingEventId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, MobileAppTroubleshootingEventId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.MobileAppTroubleshootingEvents[MobileAppTroubleshootingEventId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, MobileAppTroubleshootingEventId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
