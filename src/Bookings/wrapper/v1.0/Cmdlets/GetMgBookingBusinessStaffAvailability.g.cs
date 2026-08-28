#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Bookings.Client;
using Microsoft.Graph.PowerShell.Bookings.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Bookings
{
    [GraphRoute("POST", "/solutions/bookingBusinesses/{bookingBusiness-id}/getStaffAvailability")]
    [Cmdlet(VerbsCommon.Get, "MgBookingBusinessStaffAvailability", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Bookings.Client.Solutions.BookingBusinesses.Item.GetStaffAvailability.GetStaffAvailabilityPostResponse))]
    public class GetMgBookingBusinessStaffAvailabilityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? StaffIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.DateTimeTimeZone? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.DateTimeTimeZone? EndDateTime { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingBusinessId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Bookings.Client.Solutions.BookingBusinesses.Item.GetStaffAvailability.GetStaffAvailabilityPostRequestBody();

    if (this.IsParameterBound(nameof(StaffIds)))
        body.StaffIds = StaffIds!.ToList();
    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Bookings.Client.Solutions.BookingBusinesses.Item.GetStaffAvailability.GetStaffAvailabilityPostResponse? result;
            try
            {
                result = client.Solutions.BookingBusinesses[BookingBusinessId].GetStaffAvailability.PostAsGetStaffAvailabilityPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, BookingBusinessId);
                return;
            }

            WriteObject(result);
        }
    }
}
