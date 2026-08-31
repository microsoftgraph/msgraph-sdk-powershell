#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Bookings.Client;
using Microsoft.Graph.PowerShell.Bookings.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Bookings
{
    [GraphRoute("PATCH", "/solutions/virtualEvents/events/{virtualEvent-id}")]
    [Cmdlet(VerbsData.Update, "MgVirtualEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEvent))]
    public class UpdateMgVirtualEventCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRegistrationRequired { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.CommunicationsIdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.ItemBody? Description { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.DateTimeTimeZone? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventExternalInformation[]? ExternalEventInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventSettings? Settings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.DateTimeTimeZone? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEvent();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsRegistrationRequired)))
        body.IsRegistrationRequired = IsRegistrationRequired;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(ExternalEventInformation)))
        body.ExternalEventInformation = ExternalEventInformation!.ToList();

    if (this.IsParameterBound(nameof(Settings)))
        body.Settings = Settings;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEvent? result;
            try
            {
                result = client.Solutions.VirtualEvents.Events[VirtualEventId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, VirtualEventId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.VirtualEvents.Events[VirtualEventId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, VirtualEventId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
