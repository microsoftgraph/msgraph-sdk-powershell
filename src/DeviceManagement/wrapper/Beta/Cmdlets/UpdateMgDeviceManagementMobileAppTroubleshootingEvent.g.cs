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

        [Parameter(Mandatory = false)]
        public string? CorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EventDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? EventName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ApplicationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedDeviceIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.KeyValuePair[]? AdditionalInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementTroubleshootingErrorDetails? TroubleshootingErrorDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MobileAppTroubleshootingHistoryItem[]? History { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppTroubleshootingEventId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MobileAppTroubleshootingEvent();

    if (this.IsParameterBound(nameof(CorrelationId)))
        body.CorrelationId = CorrelationId;

    if (this.IsParameterBound(nameof(EventDateTime)))
        body.EventDateTime = EventDateTime;

    if (this.IsParameterBound(nameof(EventName)))
        body.EventName = EventName;

    if (this.IsParameterBound(nameof(ApplicationId)))
        body.ApplicationId = ApplicationId;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(ManagedDeviceIdentifier)))
        body.ManagedDeviceIdentifier = ManagedDeviceIdentifier;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(AdditionalInformation)))
        body.AdditionalInformation = AdditionalInformation!.ToList();

    if (this.IsParameterBound(nameof(TroubleshootingErrorDetails)))
        body.TroubleshootingErrorDetails = TroubleshootingErrorDetails;

    if (this.IsParameterBound(nameof(History)))
        body.History = History!.ToList();


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
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
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
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
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
