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
    [GraphRoute("PATCH", "/solutions/bookingBusinesses/{bookingBusiness-id}/customers/{bookingCustomer-id}")]
    [Cmdlet(VerbsData.Update, "MgBookingBusinessCustomer", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomer))]
    public class UpdateMgBookingBusinessCustomerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BookingCustomerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? EmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.PhysicalAddress[]? Addresses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.Phone[]? Phones { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingCustomerId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomer();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EmailAddress)))
        body.EmailAddress = EmailAddress;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(Addresses)))
        body.Addresses = Addresses!.ToList();

    if (this.IsParameterBound(nameof(Phones)))
        body.Phones = Phones!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomer? result;
            try
            {
                result = client.Solutions.BookingBusinesses[BookingBusinessId].Customers[BookingCustomerId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, BookingCustomerId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BookingBusinesses[BookingBusinessId].Customers[BookingCustomerId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, BookingCustomerId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
