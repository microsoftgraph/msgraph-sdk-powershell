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
    [GraphRoute("POST", "/solutions/virtualEvents/townhalls")]
    [Cmdlet(VerbsCommon.New, "MgVirtualEventTownhall", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventTownhall))]
    public class NewMgVirtualEventTownhallCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRegistrationRequired { get; set; }

        [Parameter(Mandatory = false)]
        public int? Capacity { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsInviteOnly { get; set; }

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

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.MeetingAudience? Audience { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.CommunicationsUserIdentity[]? CoOrganizers { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.Identity[]? InvitedAttendees { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventTownhall();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsRegistrationRequired)))
        body.IsRegistrationRequired = IsRegistrationRequired;

    if (this.IsParameterBound(nameof(Capacity)))
        body.Capacity = Capacity;

    if (this.IsParameterBound(nameof(IsInviteOnly)))
        body.IsInviteOnly = IsInviteOnly;

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

    if (this.IsParameterBound(nameof(Audience)))
        body.Audience = Audience;

    if (this.IsParameterBound(nameof(CoOrganizers)))
        body.CoOrganizers = CoOrganizers!.ToList();

    if (this.IsParameterBound(nameof(InvitedAttendees)))
        body.InvitedAttendees = InvitedAttendees!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventTownhall? result;
            try
            {
                result = client.Solutions.VirtualEvents.Townhalls.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
