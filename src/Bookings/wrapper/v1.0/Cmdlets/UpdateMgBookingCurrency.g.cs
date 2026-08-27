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
    [GraphRoute("PATCH", "/solutions/bookingCurrencies/{bookingCurrency-id}")]
    [Cmdlet(VerbsData.Update, "MgBookingCurrency", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCurrency))]
    public class UpdateMgBookingCurrencyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingCurrencyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Symbol { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingCurrencyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCurrency();

    if (this.IsParameterBound(nameof(Symbol)))
        body.Symbol = Symbol;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCurrency? result;
            try
            {
                result = client.Solutions.BookingCurrencies[BookingCurrencyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, BookingCurrencyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BookingCurrencies[BookingCurrencyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, BookingCurrencyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
