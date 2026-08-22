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
    [GraphRoute("POST", "/solutions/bookingBusinesses/{bookingBusiness-id}/appointments/{bookingAppointment-id}/cancel")]
    [Cmdlet(VerbsLifecycle.Stop, "MgBookingBusinessAppointment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StopMgBookingBusinessAppointmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BookingAppointmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CancellationMessage { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingAppointmentId, "Stop"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Bookings.Client.Solutions.BookingBusinesses.Item.Appointments.Item.Cancel.CancelPostRequestBody();

    if (this.IsParameterBound(nameof(CancellationMessage)))
        body.CancellationMessage = CancellationMessage;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Solutions.BookingBusinesses[BookingBusinessId].Appointments[BookingAppointmentId].Cancel.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, BookingAppointmentId);
                return;
            }

        }
    }
}
