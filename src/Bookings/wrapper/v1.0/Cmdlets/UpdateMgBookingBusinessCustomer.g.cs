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
    [GraphRoute("PATCH", "/solutions/bookingBusinesses/{bookingBusiness-id}/customers/{bookingCustomerBase-id}")]
    [Cmdlet(VerbsData.Update, "MgBookingBusinessCustomer", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomerBase))]
    public class UpdateMgBookingBusinessCustomerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BookingCustomerBaseId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingCustomerBaseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomerBase();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomerBase? result;
            try
            {
                result = client.Solutions.BookingBusinesses[BookingBusinessId].Customers[BookingCustomerBaseId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, BookingCustomerBaseId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BookingBusinesses[BookingBusinessId].Customers[BookingCustomerBaseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, BookingCustomerBaseId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
