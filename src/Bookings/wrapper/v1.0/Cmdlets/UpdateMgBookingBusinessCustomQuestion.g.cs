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
    [GraphRoute("PATCH", "/solutions/bookingBusinesses/{bookingBusiness-id}/customQuestions/{bookingCustomQuestion-id}")]
    [Cmdlet(VerbsData.Update, "MgBookingBusinessCustomQuestion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomQuestion))]
    public class UpdateMgBookingBusinessCustomQuestionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BookingBusinessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BookingCustomQuestionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? AnswerOptions { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Bookings.Client.Models.AnswerInputType? AnswerInputType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BookingCustomQuestionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomQuestion();

    if (this.IsParameterBound(nameof(AnswerOptions)))
        body.AnswerOptions = AnswerOptions!.ToList();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(AnswerInputType)))
        body.AnswerInputType = AnswerInputType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Bookings.Client.Models.BookingCustomQuestion? result;
            try
            {
                result = client.Solutions.BookingBusinesses[BookingBusinessId].CustomQuestions[BookingCustomQuestionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, BookingCustomQuestionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Solutions.BookingBusinesses[BookingBusinessId].CustomQuestions[BookingCustomQuestionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, BookingCustomQuestionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
