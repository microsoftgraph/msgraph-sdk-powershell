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
    [GraphRoute("PATCH", "/solutions/virtualEvents/webinars/{virtualEventWebinar-id}/registrations/{virtualEventRegistration-id}")]
    [Cmdlet(VerbsData.Update, "MgVirtualEventWebinarRegistration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistration))]
    public class UpdateMgVirtualEventWebinarRegistrationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VirtualEventWebinarId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string VirtualEventRegistrationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CancelationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Email { get; set; }

        [Parameter(Mandatory = false)]
        public string? FirstName { get; set; }

        [Parameter(Mandatory = false)]
        public string? LastName { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredTimezone { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RegistrationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventExternalRegistrationInformation? ExternalRegistrationInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistrationQuestionAnswer[]? RegistrationQuestionAnswers { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventAttendeeRegistrationStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VirtualEventRegistrationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistration();

    if (this.IsParameterBound(nameof(CancelationDateTime)))
        body.CancelationDateTime = CancelationDateTime;

    if (this.IsParameterBound(nameof(Email)))
        body.Email = Email;

    if (this.IsParameterBound(nameof(FirstName)))
        body.FirstName = FirstName;

    if (this.IsParameterBound(nameof(LastName)))
        body.LastName = LastName;

    if (this.IsParameterBound(nameof(PreferredLanguage)))
        body.PreferredLanguage = PreferredLanguage;

    if (this.IsParameterBound(nameof(PreferredTimezone)))
        body.PreferredTimezone = PreferredTimezone;

    if (this.IsParameterBound(nameof(RegistrationDateTime)))
        body.RegistrationDateTime = RegistrationDateTime;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(ExternalRegistrationInformation)))
        body.ExternalRegistrationInformation = ExternalRegistrationInformation;

    if (this.IsParameterBound(nameof(RegistrationQuestionAnswers)))
        body.RegistrationQuestionAnswers = RegistrationQuestionAnswers!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.VirtualEventRegistration? result;
            try
            {
                result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].Registrations[VirtualEventRegistrationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, VirtualEventRegistrationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.VirtualEvents.Webinars[VirtualEventWebinarId].Registrations[VirtualEventRegistrationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, VirtualEventRegistrationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
