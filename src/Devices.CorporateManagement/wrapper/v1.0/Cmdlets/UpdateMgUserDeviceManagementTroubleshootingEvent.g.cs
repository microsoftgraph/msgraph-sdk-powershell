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
    [GraphRoute("PATCH", "/users/{user-id}/deviceManagementTroubleshootingEvents/{deviceManagementTroubleshootingEvent-id}")]
    [Cmdlet(VerbsData.Update, "MgUserDeviceManagementTroubleshootingEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceManagementTroubleshootingEvent))]
    public class UpdateMgUserDeviceManagementTroubleshootingEventCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementTroubleshootingEventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EventDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementTroubleshootingEventId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceManagementTroubleshootingEvent();

    if (this.IsParameterBound(nameof(CorrelationId)))
        body.CorrelationId = CorrelationId;

    if (this.IsParameterBound(nameof(EventDateTime)))
        body.EventDateTime = EventDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceManagementTroubleshootingEvent? result;
            try
            {
                result = client.Users[UserId].DeviceManagementTroubleshootingEvents[DeviceManagementTroubleshootingEventId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementTroubleshootingEventId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].DeviceManagementTroubleshootingEvents[DeviceManagementTroubleshootingEventId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementTroubleshootingEventId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
